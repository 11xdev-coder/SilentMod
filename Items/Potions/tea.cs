using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Potions
{
    public class tea : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tea");
            Tooltip.SetDefault("Cool!");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 30;
            item.value = 500;
            item.rare = 3;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.useTurn = true;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("burning_aliveDebuff"), 28800);

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddIngredient(ItemID.Fireblossom, 1);
            recipe.AddIngredient(ItemID.Daybloom, 1);
            recipe.AddIngredient(ItemID.Blinkroot, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}