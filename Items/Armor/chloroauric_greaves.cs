using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class chloroauric_greaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloroauric Greaves"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("2% increased movement speed");
		}

		public override void SetDefaults() // object properties
		{
			item.width = 22; // sprite width
			item.height = 18; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Lime; // item rarity
			item.defense = 15;
		}
        public override void UpdateEquip(Player player)
        {
			player.moveSpeed += 0.2f;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("chloroauric_bar"), 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}