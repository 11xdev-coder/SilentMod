using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Boss
{
    public class Flower_Bulb : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flower Bulb");
            Tooltip.SetDefault("Summon Plantera \nExpert");
        }

        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 128;
            item.maxStack = 20;
            item.rare = ItemRarityID.Expert;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(NPCID.Plantera);
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position, 0);
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
            }
            return true;
        }
    }
}