using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Trophies
{
    public class Mechantera_Trophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mechantera Trophy");
            Tooltip.SetDefault("Cannot be placed");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 32;
            item.maxStack = 999;
            item.rare = ItemRarityID.Lime;
        }

    }
}