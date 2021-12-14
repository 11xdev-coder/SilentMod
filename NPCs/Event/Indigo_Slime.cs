using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SilentMod.NPCs.Bosses;

namespace SilentMod.NPCs.Event
{
    public class Indigo_Slime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Indigo Slime");
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;

            npc.lifeMax = 200;

            npc.damage = 60;
            npc.defense = 24;

            npc.value = 600f;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;

            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;

            //banner = Item.NPCtoBanner(NPCID.Zombie);
            //bannerItem = Item.BannerToItem(banner);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (SilentNPCWorld.ApocalypseUp)
            {
                return 1000f;
            }
            else
            {
                return 0f;
            }
        }
    }
}