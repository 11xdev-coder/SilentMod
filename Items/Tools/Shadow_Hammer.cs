using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Tools
{
	public class Shadow_Hammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Hammer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 24; // damage
			item.melee = true; // weapon type
			item.width = 35; // sprite width
			item.height = 35; // sprite height
			item.useTime = 32; // animation speed
			item.useAnimation = 32; // animation speed
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 3; // item knockback
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Blue; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.useTurn = true;
			item.maxStack = 1;
			item.hammer = 70;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Desert_Hammer"), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}