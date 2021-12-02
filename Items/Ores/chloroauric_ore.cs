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

namespace SilentMod.Items.Ores
{
    public class chloroauric_ore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chloroauric Ore");
            Tooltip.SetDefault("Cannot be placed");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.rare = ItemRarityID.Lime;
        }
    }
}