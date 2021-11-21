using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Unholy_Helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unholy Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Set Bonus: 20% to not consume ammo\n2% increased ranged damage\n2% increased movement speed");
		}

		public override void SetDefaults() // object properties
		{
			item.width = 18; // sprite width
			item.height = 18; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.defense = 13;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Shadow_Helmet"), 1);
			recipe.AddIngredient(ItemID.TitaniumBar, 4);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<Unholy_Chestplate>() && legs.type == ItemType<Unholy_Greaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.ammoBox = true;
			player.rangedDamage += 0.5f;
			player.moveSpeed += 0.5f;
		}
	}
}