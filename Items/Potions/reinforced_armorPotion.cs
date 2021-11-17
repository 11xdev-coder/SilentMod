using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Potions
{
    public class reinforced_armorPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reinforced Armor Potion");
            Tooltip.SetDefault("Gives player \"Reinforced Armor\" buff");
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
            item.useStyle = 4;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.useTurn = true;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("reinforced_armorBuff"), 28800);

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.IronOre, 1);
            recipe.AddIngredient(ItemID.Daybloom, 1);
            recipe.AddIngredient(ItemID.Blinkroot, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.LeadOre, 1);
            recipe.AddIngredient(ItemID.Daybloom, 1);
            recipe.AddIngredient(ItemID.Blinkroot, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}