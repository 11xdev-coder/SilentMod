using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Buffs
{

    public class reinforced_armorBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Reinforced Armor");
            Description.SetDefault("Adds 10 armor units");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 10;
        }
    }
}