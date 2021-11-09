using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;

namespace AgletCraft.Items
{
    public class Modbase : ModBase //Use ModBase instead of Items.
    {
        public override void OnLoad() //This will call the code when you load up the game.
        {
            Recipe.newRecipe.createItem.SetDefaults(1309, false); //This is where the item you want to add a recipe to goes. "1309" is the ID of the Slime Staff.
            Recipe.newRecipe.createItem.stack = 1; //This is how many are produced by this recipe.
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(9, false)); //This is the first item used in the recipe. "9" is the ID for Wood.
            Recipe.newRecipe.requiredItem[0].stack = 15; //This is how much Wood we need, 15. the [0] notes that this is the first material in the recipe.
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(23, false)); //This is the second item used in the recipe. "23" is the ID for Gel.
            Recipe.newRecipe.requiredItem[1].stack = 80; //We need 80 Gel. The [1] means it is the second material in the recipe. It goes up from there.
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(29, false)); //"29" is the ID for Life Crystal. Get it now?
            Recipe.newRecipe.requiredItem[2].stack = 1; //We need 1 Heart Crystal.
            Recipe.newRecipe.requiredTile.Add(18); //This is where the crafting station you need goes. "18" is the ID for the Work Bench.
            Recipe.AddRecipe(); //This tidbit of code adds the recipe into the game.
        }
    }
}
