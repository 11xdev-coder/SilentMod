using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Weapons
{
	public class Desert_Sword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Desert Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 14; // damage
			item.melee = true; // weapon type
			item.width = 38; // sprite width
			item.height = 38; // sprite height
			item.useTime = 18; // animation speed
			item.useAnimation = 18; // animation speed
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 5; // item knockback
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false; // auto attack
			item.maxStack = 1;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.Sandstone, 25);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}