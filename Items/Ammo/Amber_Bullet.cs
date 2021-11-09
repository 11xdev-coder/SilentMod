using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Ammo
{
	public class Amber_Bullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amber Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 11; // damage
			item.ranged = true; // weapon type
			item.consumable = true;
			item.width = 8; // sprite width
			item.height = 8; // sprite height
			item.knockBack = 5; // item knockback
			item.value = Item.sellPrice(silver: 21); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.useTurn = true;
			item.maxStack = 999;

			item.shoot = ProjectileType<Projectiles.Ammo.Amber_Bullet>();
			item.shootSpeed = 6;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bullet, 70);
			recipe.AddIngredient(ItemID.Amber, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 70);
			recipe.AddRecipe();
		}
	}
}