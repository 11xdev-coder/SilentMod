using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Weapons
{
	public class Shadow_Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 45; // damage
			item.melee = true; // weapon type
			item.width = 38; // sprite width
			item.height = 38; // sprite height
			item.useTime = 25; // animation speed
			item.useAnimation = 25; // animation speed
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 6; // item knockback
			item.value = Item.sellPrice(silver: 45); // item sell price
			item.rare = ItemRarityID.Orange; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false; // auto attack
			item.maxStack = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Desert_Sword"), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}