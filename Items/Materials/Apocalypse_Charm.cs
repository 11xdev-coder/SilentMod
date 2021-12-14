using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Materials
{
    public class Apocalypse_Charm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Apocalypse Charm");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.rare = ItemRarityID.Green;
        }

    }
}