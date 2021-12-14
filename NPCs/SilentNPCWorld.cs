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
using SilentMod.Events;

namespace SilentMod.NPCs
{
    public class SilentNPCWorld : ModWorld
    {
        public static bool downedMechantera = false;
        public static bool ApocalypseUp = false;
        public static bool downedApocalypse = false;

        public override void Initialize()
        {
            downedMechantera = false;
            Main.invasionSize = 0;
            ApocalypseUp = false;
            downedApocalypse = false;
        }

        public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedMechantera) downed.Add("Mechantera");
            if (downedApocalypse) downed.Add("Apocalypse");

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
            downedApocalypse = downed.Contains("Apocalypse");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                downedMechantera = flags[0];
                downedApocalypse = flags[1];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedMechantera;
            flags[1] = downedApocalypse;
            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedMechantera = flags[0];
            downedApocalypse = flags[1];
        }
        public override void PostUpdate()
        {
            if (ApocalypseUp)
            {
                if (Main.invasionX == (double)Main.spawnTileX)
                {
                    //Checks progress and reports progress only if invasion at spawn
                    Apocalypse.CheckCustomInvasionProgress();
                }
                //Updates the custom invasion while it heads to spawn point and ends it
                Apocalypse.UpdateApocalypse();
            }
        }
    }
}