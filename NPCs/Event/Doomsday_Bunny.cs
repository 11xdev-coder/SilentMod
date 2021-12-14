using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.NPCs.Event
{
    public class Doomsday_Bunny : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doomsday Bunny");

            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny];
        }

        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 28;

            npc.lifeMax = 70;

            npc.damage = 20;
            npc.defense = 4;

            npc.value = 500f;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;

            npc.aiStyle = 3;
            aiType = NPCID.CorruptBunny;
            animationType = NPCID.Bunny;

            //banner = Item.NPCtoBanner(NPCID.Zombie);
            //bannerItem = Item.BannerToItem(banner);
        }
    }
}