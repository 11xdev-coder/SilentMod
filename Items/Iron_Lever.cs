using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items
{
	public class Iron_Lever : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Iron Lever"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basic lever used to fight");
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 10; // damage
			item.melee = true; // weapon type
			item.width = 32; // sprite width
			item.height = 32; // sprite height
			item.useTime = 10; // animation speed
			item.useAnimation = 10; // animation speed
			item.useStyle = 1; // using type
			item.knockBack = 3; // item knockback
			item.value = 1000; // item sell price
			item.rare = 1; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.maxStack = 1;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}