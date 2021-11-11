using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Tools
{
	public class Shadow_Axe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 29; // damage
			item.melee = true; // weapon type
			item.width = 28; // sprite width
			item.height = 28; // sprite height
			item.useTime = 22; // animation speed
			item.useAnimation = 22; // animation speed
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 4; // item knockback
			item.value = Item.sellPrice(silver: 55); // item sell price
			item.rare = ItemRarityID.Orange; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.useTurn = true;
			item.maxStack = 1;
			item.axe = 14; // axe power but / 5
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Desert_Axe"), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}