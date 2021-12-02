using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.NPCs
{
    public class SilentModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.LihzahrdCrawler)
            {
                if (Main.rand.Next(20) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Soul_of_Bright"));
                }
            }
        }
    }
}