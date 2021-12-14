using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.NPCs.Event
{
    public class Doomsday_Zombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doomsday Zombie");

            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }

        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 40;

            npc.lifeMax = 60;

            npc.damage = 20;
            npc.defense = 10;

            npc.value = 90f;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;

            npc.aiStyle = 3;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;

            //banner = Item.NPCtoBanner(NPCID.Zombie);
            //bannerItem = Item.BannerToItem(banner);
        }
    }
}