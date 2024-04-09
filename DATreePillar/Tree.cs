using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATreePillar
{
    internal static class Tree
    {
        public static List<string> IDs = new List<string>()
        {
             {"f004cb77-d6a7-4f88-9f8d-3e3328c0491f" },
             {"ab508d4f-89a5-4c84-8e24-a53c94a2bd97" },
             {"67c8a191-9ff6-4d4d-ab27-632262d813ea" },
             {"84d11540-4c0b-4e7e-a2cc-7d6f8023467a" },
             {"dbe8aa4e-b911-49ff-9dd7-ed68090b2bd8" },
             {"24f1a986-3db9-48f3-845f-7ed893e702a9" },
             {"38941089-e9da-431f-994b-c9ca99b7358d" },
             {"8133020c-4290-4671-96fd-b81e58337ab2" },
             {"ec2cf766-1085-4cef-9a12-bd248ba94293" },
             {"ee5ed2a7-f6b6-479c-8208-55770c78f46b" },
             {"0db6a0c2-24c0-46d2-b1be-38e82f23c83c" },
             {"35d7f44d-67ff-4434-b4cc-b1655743fec6" },
             {"4db46af2-aa61-4005-8d59-98a9c4eacd75" },
             {"54cc2a7a-aaba-4e87-994c-80023356f09c" },
             {"7054a62f-953c-4465-b13a-a8743a5c9b29" },
             {"73ba645d-b1f8-48f9-b46a-41f8a6fcf4d4" },
             {"820409ee-3b1f-4fde-b8a1-d2a68ebd7cc6" },
             {"b3b09b49-acbd-4f51-99bc-212e974bc867" },
             {"e75fc134-ff18-4186-9719-66f7573e22ed" },
             {"e29fb699-5dfe-4ca4-87e2-8ee2260244ec" },
             {"d8c1a2ac-a667-47a6-bf45-f398e0f37daf" },
             {"eeae66b7-9aa9-4aee-b280-5f5625e9fc90" },
             {"fe88801b-12aa-4c35-ae87-3f284e0f5776" },
             {"90007b46-af3d-4ce1-961a-21a9d0d9efde" },
             {"3a1fc997-e799-4fcc-88f2-e7bae8986c10" },
             {"aa85ce75-bc9a-4d9f-8c1c-4cc4a9be9650" },
             {"b5820849-9f98-4736-a451-88635fc5f67d" },
             {"d5bb8468-5354-42cb-95d8-bb34cf71f577" },
             {"9354afc6-0c64-402a-a497-6bf1bb2aeba6" },
             {"8a120a46-1782-4998-8758-9625302248c9" }
        };

        // Aborted attempt to use bespoke objects per tree type.
        //public static Dictionary<string, (string id, double x, double y, double rotation, double scale)[]> IDsWithObjs = 
        //    new Dictionary<string, (string id, double x, double y, double rotation, double scale)[]>()
        //{
        //     {
        //        "ab508d4f-89a5-4c84-8e24-a53c94a2bd97", 
        //        new[] 
        //        { 
        //            ("b97b118b-cc23-49b8-9c24-f1e3b4c9c452", -0.3, -0.25, -22.5, 0.87),
        //            ("b97b118b-cc23-49b8-9c24-f1e3b4c9c452", -0.3, 0.75, 157.5, 0.87)
        //        } 
        //     },
        //     {
        //        "84d11540-4c0b-4e7e-a2cc-7d6f8023467a",
        //        new[]
        //        {
        //            ("37fb2c60-c81e-433e-89e9-dc71f5d473dd", -0.03, 0.05, -157.5, 0.71)
        //        }
        //     },
        //};
    }
}
