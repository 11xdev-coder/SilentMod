using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using SilentMod.NPCs;
using SilentMod.Events;

namespace SilentMod.Items.Event
{
    public class Doomsday_Emblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doomsday Emblem");
            Tooltip.SetDefault("Summons Apocalypse");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 20;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.rare = ItemRarityID.Yellow;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position, 0);
            Main.NewText("Apocalypse is approaching!", 175, 75, 255, false);
            Apocalypse.StartApocalypse();
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DestroyerEmblem, 1);
            recipe.AddIngredient(mod.ItemType("Apocalypse_Charm"), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}