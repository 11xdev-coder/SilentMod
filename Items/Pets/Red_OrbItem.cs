using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Pets
{
	public class Red_OrbItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Orb");
			Tooltip.SetDefault("Summons a flying red orb");
		}

		public override void SetDefaults() // object properties
		{
			item.CloneDefaults(ItemID.DD2PetGato);
			item.shoot = mod.ProjectileType("Red_OrbProj");
			item.buffType = mod.BuffType("Red_OrbBuff");
		}

		public override void UseStyle(Player player)
        {
			if(player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
				player.AddBuff(item.buffType, 3600, true);
            }
        }

		//public override void AddRecipes()
		//{
		//	ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(ItemID.SandBlock, 50);
		//	recipe.AddIngredient(ItemID.Sandstone, 20);
		//	recipe.AddIngredient(ItemID.AntlionMandible, 1);
		//	recipe.AddIngredient(ItemID.Amber, 1);
		//	recipe.AddTile(TileID.Anvils);
		//	recipe.SetResult(this);
		//	recipe.AddRecipe();
		//}
	}
}