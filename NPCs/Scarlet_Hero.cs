//using Terraria.ID;
//using Terraria.ModLoader;
//using Terraria;

//namespace SilentMod.NPCs
//{
//    [AutoloadHead]
//    public class Scarlet_Hero : ModNPC
//    {
//        public override string Texture
//        {
//            get { return "SilentMod/NPCs/Scarlet_Hero";  }
//        }

//        public override bool Autoload(ref string name)
//        {
//            name = "Scarlet_Hero";
//            return mod.Properties.Autoload;
//        }

//        public override void SetStaticDefaults()
//        {
//            Main.npcFrameCount[npc.type] = 16;
//            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
//            NPCID.Sets.AttackFrameCount[npc.type] = 5;
//            NPCID.Sets.DangerDetectRange[npc.type] = 700;
//            NPCID.Sets.AttackType[npc.type] = 0;
//            NPCID.Sets.AttackTime[npc.type] = 90;
//            NPCID.Sets.AttackAverageChance[npc.type] = 30;
//            NPCID.Sets.HatOffsetY[npc.type] = 4;
//        }

//        public override void SetDefaults()
//        {
//            npc.townNPC = true;
//            npc.friendly = true;
//            npc.width = 20;
//            npc.height = 40;
//            npc.aiStyle = 7;
//            npc.damage = 0;
//            npc.defense = 22;
//            npc.lifeMax = 300;
//            npc.HitSound = 1;
//            npc.DeathSound = 1;
//            npc.knockBackResist = 3f;
//            npc.animationType = 28;
//        }

//        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
//        {
//            for(int k = 0; k < 255; k++)
//            {
//                Player player = Main.player[k];
//                if (!player.active)
//                {
//                    continue;
//                }

//                foreach(Item item in player.inventory)
//                {
//                    if(item.type == 61 || item.type == 836)
//                    {
//                        return true;
//                    }
//                }
//            }
//            return false;
//        }
//    }
//}