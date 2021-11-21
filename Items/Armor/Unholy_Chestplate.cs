using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Unholy_Chestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unholy Chestplate"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{ 
			item.width = 18; // sprite width
			item.height = 18; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.defense = 17;
		}

		public static void Effects(Player player)
		{
			player.rangedDamage += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Shadow_Chestplate"), 1);
			recipe.AddIngredient(ItemID.TitaniumBar, 9);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}