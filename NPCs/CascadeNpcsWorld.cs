using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.Localization;
using System.Threading;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using System.IO;
using NPCs;

namespace NPCs.CascadeNpcsWorld

{
    public class CascadeNpcsWorld : ModWorld
    {
        public static bool DownedEmeraldSlime = false;


        public override void Initialize()
        {
            DownedEmeraldSlime = false;
        }

        public override TagCompound Save()
        {
            var Downed = new List<string>();
            if (DownedEmeraldSlime) Downed.Add("emeraldSlime");

            return new TagCompound
            {
                {
                    "Version", 0
                },
                {
                     "Downed", Downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var Downed = tag.GetList<string>("Downed");
            DownedEmeraldSlime = Downed.Contains("emeraldSlime");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if (loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                DownedEmeraldSlime = flags[0];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = DownedEmeraldSlime;

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            flags[0] = DownedEmeraldSlime;
        }
    }
}

