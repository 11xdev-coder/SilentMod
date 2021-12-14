using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SilentMod.Items.Socials
{
	[AutoloadEquip(EquipType.Head)]
	public class Mechantera_Mask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechantera Mask");
		}

		public override void SetDefaults() // object properties
		{
			item.width = 34; // sprite width
			item.height = 32; // sprite height
			item.value = Item.sellPrice(silver: 33); // item sell price
			item.rare = ItemRarityID.Lime; // item rarity
		}
	}
}