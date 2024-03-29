using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Weapons
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
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 0; // item knockback
			item.value = Item.sellPrice(gold: 1); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.maxStack = 1;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}