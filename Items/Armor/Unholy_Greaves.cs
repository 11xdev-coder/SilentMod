using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Unholy_Greaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unholy Greaves");
		}

		public override void SetDefaults() // object properties
		{ 
			item.width = 18; // sprite width
			item.height = 18; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.defense = 12;
		}

		public static void Effects(Player player)
		{
			player.moveSpeed += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Shadow_Greaves"), 1);
			recipe.AddIngredient(ItemID.TitaniumBar, 7);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}