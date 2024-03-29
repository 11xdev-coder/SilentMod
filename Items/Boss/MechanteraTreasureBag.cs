using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SilentMod.Items.Boss
{
    public class MechanteraTreasureBag : ModItem
    {
        public override int BossBagNPC => mod.NPCType("Enraged_Mechantera");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag (Mechantera)");
            Tooltip.SetDefault("<right click> to open");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
            item.consumable = true;
        }

        public override void OpenBossBag(Player player)
        {
            player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(20, 45));
            player.QuickSpawnItem(mod.ItemType("chloroauric_ore"), Main.rand.Next(16, 54));
            if(Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Mechantera_Hooks"), 1);
            }

            if (Main.rand.Next(199) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Flower_Bulb"), 1);
            }

            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Mechantera_Mask"), 1);
            }

            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(ItemID.TheAxe, 1);
            }

            if (Main.rand.Next(9) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Mechantera_Trophy"), 1);
            }

            if (Main.rand.Next((int)1.5f) == 0f)
            {
                player.QuickSpawnItem(ItemID.RocketIV, Main.rand.Next(40, 55));
            }
        }
    }
}