using System.Text.Json;

namespace DATreePillar
{
    public partial class DATreePillarForm : Form
    {
        public DATreePillarForm()
        {
            InitializeComponent();
        }

        private DungeonAlchemistMap map;
        private List<BuildingBlockInstance> trees;

        private void InputFileBrowseButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                InputFileTextbox.Text = openFileDialog.FileName;
                string mapJson = File.ReadAllText(InputFileTextbox.Text);
                DungeonAlchemistMap? map = JsonSerializer.Deserialize<DungeonAlchemistMap>(mapJson);
                if (map != null )
                {
                    this.map = map;
                    trees = map.buildingBlockInstances.Where(block => Tree.IDs.Contains(block.blockId)).ToList();
                    SetOutput($"Map loaded from file \"{InputFileTextbox.Text}\", Trees: {trees.Count:n0}");
                }
            }
        }

        private void AddColumnsButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    
                    int currentTree = 0;
                    foreach (var tree in trees)
                    {
                        SetOutput($"Adding walls for tree {++currentTree:n0} of {trees.Count:n0}...");
                        
                        var addWall = (int rot) =>
                        {
                            var newId = Guid.NewGuid();
                            var col = new BuildingBlockInstance()
                            {
                                Version = tree.Version,
                                blockId = "7b421459-d37e-499b-872f-21ea701431da", // wall
                                center = tree.center,
                                height = tree.height,
                                fixedHeight = tree.fixedHeight,
                                scale = (double)ScaleSpinner.Value,
                                rotation = rot,
                                flipped = false,
                                attachmentPointDir = tree.attachmentPointDir,
                                isAttached = false,
                                attachedWall = string.Empty,
                                modifierValues = tree.modifierValues,
                                parentInstanceId = null,
                                followParentWhenMoving = true,
                                variantId = null,
                                variantSetId = null,
                                variantRootInstanceId = null,
                                cutoutBackBlockId = null,
                                cutoutFrontBlockId = null,
                                backWallBlockId = null,
                                randSeed = 494647983,
                                id = newId.ToString("D")
                            };
                            map.buildingBlockInstances.Add(col);
                            map.objects.Add(new MapObject()
                            {
                                roomInstanceId = map.objects.Where(o => o.buildingBlockInstanceId == tree.id).First().roomInstanceId,
                                buildingBlockInstanceId = newId.ToString("D"),
                                removedTiles = null,
                                id = Guid.NewGuid().ToString("D")
                            });
                        };

                        addWall(0);
                        addWall(90);
                        
                        AppendOutput($"done.\r\n");
                    }

                    string updatedMap = JsonSerializer.Serialize(map);
                    var saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Dungeon Alchemist Map|*.dam";
                    Invoke(() =>
                    {
                        var saveResult = saveDialog.ShowDialog();
                        if (saveResult == DialogResult.OK)
                        {
                            File.WriteAllText(saveDialog.FileName, updatedMap);
                        }
                    });

                    SetOutput($"Finished, walls added to {trees.Count:n0} trees.");
                }
                catch (Exception ex)
                {
                    SetOutput(ex.Message);
                }
            });
            
        }

        private void SetOutput(string outputLine)
        {
            OutputText.Invoke(() =>
            {
                OutputText.Text = outputLine;
            });
        }

        private void AppendOutput(string output)
        {
            OutputText.Invoke(() => 
            {
                OutputText.Text += output;
            });
        }
    }
}
