using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SilentMod.Items.Event
{
    public class Indigo_Gel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Indigo Gel");
            Tooltip.SetDefault("\"Tastes like blueberries... \nwait, is this safe to eat ? \"");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(copper: 5);
        }

    }
}