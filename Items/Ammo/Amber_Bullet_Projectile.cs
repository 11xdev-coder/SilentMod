using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Ammo
{
    public class Amber_Bullet_Projectile : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Bullet");
            Tooltip.SetDefault("Just a bullet what do you want to see here???");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(8);
            item.value = Item.buyPrice(copper: 20);
            item.rare = ItemRarityID.Blue;

            item.consumable = true;
            item.maxStack = 999;

            item.ranged = true;
            item.damage = 2;
            item.knockBack = 3.25f;

            item.shoot = mod.ProjectileType("Star");
            item.shootSpeed = 5.25f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 70);
            recipe.AddIngredient(ItemID.Amber, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 70);
            recipe.AddRecipe();
        }
    }
}