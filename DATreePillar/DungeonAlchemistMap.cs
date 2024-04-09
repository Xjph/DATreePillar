using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DATreePillar.DungeonAlchemistMap;

namespace DATreePillar
{
    public class DungeonAlchemistMap
    {
        public int Version { get; set; }
        public int version { get; set; }
        public Settings settings { get; set; }
        public int lightingType { get; set; }
        public object customLightingData { get; set; }
        public string terrain { get; set; }
        public string waterMap { get; set; }
        public string caveTiles { get; set; }
        public bool legacyMapWithoutBlackCeiling { get; set; }
        public bool showCaveCeiling { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Origin origin { get; set; }
        public OriginalSize originalSize { get; set; }
        public int randSeed { get; set; }
        public List<Room> rooms { get; set; }
        public List<object> floors { get; set; }
        public List<object> pillars { get; set; }
        public List<object> walls { get; set; }
        public List<MapObject> objects { get; set; }
        public List<object> overlays { get; set; }
        public List<BuildingBlockInstance> buildingBlockInstances { get; set; }
        // public BinaryData binaryData { get; set; }
        // public UsedWorkshopItems usedWorkshopItems { get; set; }
        
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AttachmentPointDir
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class BinaryData
    {
    }

    public class BiomeData
    {
        public int Version { get; set; }
        public string biomeId { get; set; }
        public string elevationId { get; set; }
        public string vegetationId { get; set; }
        public string waterId { get; set; }
        public string weatherId { get; set; }
        public string lightId { get; set; }
        public double roomHeight { get; set; }
        public double minTerrainHeight { get; set; }
        public double maxTerrainHeight { get; set; }
    }

    public class BleedInMm
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class BuildingBlockInstance
    {
        public int Version { get; set; }
        public string blockId { get; set; }
        public Center center { get; set; }
        public double height { get; set; }
        public bool fixedHeight { get; set; }
        public double scale { get; set; }
        public double rotation { get; set; }
        public bool flipped { get; set; }
        public AttachmentPointDir attachmentPointDir { get; set; }
        public bool isAttached { get; set; }
        public string attachedWall { get; set; }
        public ModifierValues modifierValues { get; set; }
        public object? parentInstanceId { get; set; }
        public bool followParentWhenMoving { get; set; }
        public object? variantId { get; set; }
        public object? variantSetId { get; set; }
        public object? variantRootInstanceId { get; set; }
        public object? cutoutBackBlockId { get; set; }
        public object? cutoutFrontBlockId { get; set; }
        public object? backWallBlockId { get; set; }
        public int randSeed { get; set; }
        public string id { get; set; }
    }

    public class Center
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class CustomInteriorSafetyMarginWithoutTilesInMm
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CustomSafetyMarginInMm
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CustomSizeInMm
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class ModifierValues
    {
    }

    public class MapObject
    {
        public string roomInstanceId { get; set; }
        public string buildingBlockInstanceId { get; set; }
        public object? removedTiles { get; set; }
        public string id { get; set; }
    }

    public class Origin
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class OriginalSize
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Room
    {
        public int Version { get; set; }
        public string roomId { get; set; }
        public List<Tile> tiles { get; set; }
        public int placeOrder { get; set; }
        public bool exterior { get; set; }
        public int roomInstanceType { get; set; }
        public string id { get; set; }
    }



    public class Settings
    {
        public object layoutId { get; set; }
        public object externalLayoutProvider { get; set; }
        public object externalLayoutId { get; set; }
        public BiomeData biomeData { get; set; }
        public int orientation { get; set; }
        public bool customLayout { get; set; }
        public CustomSizeInMm customSizeInMm { get; set; }
        public CustomSafetyMarginInMm customSafetyMarginInMm { get; set; }
        public CustomInteriorSafetyMarginWithoutTilesInMm customInteriorSafetyMarginWithoutTilesInMm { get; set; }
        public BleedInMm bleedInMm { get; set; }
        public int tileSizeInMm { get; set; }
        public bool isClippingForced { get; set; }
    }

    public class Tile
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class UsedWorkshopItems
    {
    }


}
