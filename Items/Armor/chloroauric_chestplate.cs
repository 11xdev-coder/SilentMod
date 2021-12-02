using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class chloroauric_chestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloroauric Chestplate"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("5% increased damage");
		}

		public override void SetDefaults() // object properties
		{
			item.width = 30; // sprite width
			item.height = 20; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Lime; // item rarity
			item.defense = 21;
		}
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.5f;
			player.rangedDamage += 0.5f;
			player.magicDamage += 0.5f;
			player.minionDamage += 0.5f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("chloroauric_bar"), 18);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}