using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace SilentMod
{
	public class SilentMod : Mod
	{
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Aglet);
            recipe.AddRecipe();
        }
    }
}