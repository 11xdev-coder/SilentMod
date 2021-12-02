using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class chloroauric_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloroauric Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Set Bonus: 7 defense");
		}

		public override void SetDefaults() // object properties
		{
			item.width = 30; // sprite width
			item.height = 23; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Lime; // item rarity
			item.defense = 13;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("chloroauric_bar"), 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<chloroauric_chestplate>() && legs.type == ItemType<chloroauric_greaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.statDefense += 7;
		}
	}
}