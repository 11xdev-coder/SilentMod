using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Desert_Helmet : ModItem
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
			item.defense = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.Sandstone, 20);
			recipe.AddIngredient(ItemID.AntlionMandible, 1);
			recipe.AddIngredient(ItemID.Amber, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<Desert_Chestplate>() && legs.type == ItemType<Desert_Boots>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage += 0.4f;
			player.moveSpeed += 0.4f;
		}
	}
}