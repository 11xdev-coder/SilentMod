using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Ammo
{
    public class Ancient_Amber_Bullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Amber Bullet");
            Tooltip.SetDefault("Shoots powder");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.Blue;
            item.shoot = mod.ProjectileType("Ancient_Amber_Bullet");
            item.shootSpeed = 16f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.Amber, 5);
            recipe.AddIngredient(ItemID.AntlionMandible, 1);
            recipe.AddIngredient(ItemID.Obsidian, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }


    }
}