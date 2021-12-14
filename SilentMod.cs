using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using SilentMod.NPCs;

namespace SilentMod
{
	public class SilentMod : Mod
	{
        public void MMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void UpdateMusic(ref int music)
        {
            //Checks if the invasion is in the correct spot, if it is, then change the music
            if(SilentNPCWorld.ApocalypseUp)
            {
                music = MusicID.Eclipse;
            }
        }

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