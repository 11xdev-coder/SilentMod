using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Buffs
{

    public class burning_aliveDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Burning Alive");
            Description.SetDefault("You are burning alive!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.bleed = true;
            player.noItems = true;
            player.slow = true;
            player.onFire = true;
            player.blind = true;
            player.brokenArmor = true;
        }
    }
}