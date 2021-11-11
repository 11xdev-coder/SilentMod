using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Tools
{
	public class Shadow_Pickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can mine Mythril and Orichalcum");
		}

		public override void SetDefaults() // object properties
		{
			item.damage = 14; // damage
			item.melee = true; // weapon type
			item.width = 28; // sprite width
			item.height = 28; // sprite height
			item.useTime = 21; // animation speed
			item.useAnimation = 21; // animation speed
			item.useStyle = ItemUseStyleID.SwingThrow; // using type
			item.knockBack = 3; // item knockback
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Orange; // item rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // auto attack
			item.useTurn = true;
			item.maxStack = 1;
			item.pick = 110;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Desert_Digger"), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}