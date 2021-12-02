using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Boss
{
    public class Mechanical_Bulb : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mechanical Bulb");
            Tooltip.SetDefault("Summon Mechantera");
        }

        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 128;
            item.maxStack = 20;
            item.rare = ItemRarityID.LightRed;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(mod.NPCType("Mechantera"));
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position, 0);
            if(Main.netMode != NetmodeID.MultiplayerClient)
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Mechantera"));
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 25);
            recipe.anyIronBar = true;
            recipe.AddIngredient(mod.ItemType("Soul_of_Bright"), 10);
            recipe.AddIngredient(ItemID.SoulofNight, 10); 
            recipe.AddIngredient(ItemID.BeetleHusk, 2);
            recipe.AddIngredient(ItemID.Fireblossom, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}