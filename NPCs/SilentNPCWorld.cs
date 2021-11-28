using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SilentMod.NPCs
{
    public class SilentNPCWorld : ModWorld
    {
        public static bool downedMechantera = false;

        public override void Initialize()
        {
            downedMechantera = false;
        }

        public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedMechantera) downed.Add("Mechantera");

            return new TagCompound
            {
                {
                    "Version", 0
                },
                {
                    "Downed", downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("Downed");
            downedMechantera = downed.Contains("Mechantera");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                downedMechantera = flags[0];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedMechantera;

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedMechantera = flags[0];
        }
    }
}