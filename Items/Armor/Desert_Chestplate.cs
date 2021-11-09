using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Desert_Chestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Chestplate"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Deceptive at first glance");
		}

		public override void SetDefaults() // object properties
		{ 
			item.width = 18; // sprite width
			item.height = 18; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.defense = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.Sandstone, 20);
			recipe.AddIngredient(ItemID.AntlionMandible, 2);
			recipe.AddIngredient(ItemID.Amber, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}