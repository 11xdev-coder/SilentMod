using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Materials
{
    public class Soul_of_Bright : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Bright"); 
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightRed;
        }

    }
}