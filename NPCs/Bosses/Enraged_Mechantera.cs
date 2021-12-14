
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SilentMod.NPCs.Bosses
{
    [AutoloadBossHead]
    public class Enraged_Mechantera : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enraged Mechantera");
        }

        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.friendly = false;
            npc.lifeMax = 30000;
            npc.damage = 170;
            npc.defense = 55;
            npc.knockBackResist = 0f;
            npc.width = 145;
            npc.height = 181;
            npc.npcSlots = 10f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.buffImmune[20] = true;
            npc.buffImmune[69] = true;
            npc.buffImmune[31] = true;
            npc.buffImmune[24] = true;
            npc.buffImmune[39] = true;
            music = MusicID.Boss3;
            bossBag = mod.ItemType("MechanteraTreasureBag");
        }

        public override void AI()
        {
            npc.TargetClosest(true);
            // MOVEMENT
            Player player = Main.player[npc.target];
            Vector2 targetPosition = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center; // get a local copy of the targeted player's position

            float velRotation = npc.velocity.ToRotation();

            npc.rotation = velRotation + MathHelper.ToRadians((float)Math.Tan(player.velocity.X)) + MathHelper.ToRadians(90f);

            // Handles Despawning
            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active)
            {
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.1f;
                if (npc.timeLeft > 20)
                {
                    npc.timeLeft = 20;
                    return;
                }
            }

            //if (targetPosition.X < npc.position.X // IF the target is to my left
            //    && npc.velocity.X > -8) // AND I'm not at max "left" velocity
            //{
            //    npc.velocity.X -= 0.22f; // accelerate to the left
            //}
            //if (targetPosition.X > npc.position.X // IF the target is to my right
            //    && npc.velocity.X < 8) // AND I'm not at max "right" velocity
            //{
            //    npc.velocity.X += 0.22f; // accelerate to the right
            //}

            //if (targetPosition.Y < npc.position.Y + 300) // IF the target is higher than "300 below my height"
            //{
            //    if (npc.velocity.Y < 0 // IF I'm already moving up 
            //        && npc.velocity.Y > -4) // AND I'm not at max "up" velocity
            //        npc.velocity.Y -= 0.7f; // THEN accelerate up
            //    else // otherwise, I'm not moving up already
            //        npc.velocity.Y -= 0.8f; // THEN accelerate up (faster)
            //}

            //if (targetPosition.Y > npc.position.Y + 300) // IF the target is lower than "300 below my height"
            //{
            //    if (npc.velocity.Y > 0 // IF I'm already moving down 
            //        && npc.velocity.Y < 4) // AND I'm not at max "down" velocity
            //        npc.velocity.Y += 0.7f; // THEN accelerate down
            //    else // otherwise, I'm not moving down already
            //        npc.velocity.Y += 0.8f; // THEN accelerate down (faster)
            //}

            //npc.position += npc.velocity; // update our position using the velocity

            MoveTowards(npc, targetPosition, 20f, 30f);

            // FIRING
            npc.ai[0]++;
            npc.ai[1]++;

            if (npc.ai[0] >= 60)
            {
                float speed = 12f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 100;
                int type = 258;
                Main.PlaySound(SoundID.Item, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * speed) * -1), (float)((Math.Sin(rotation) * speed) * -1), type, damage, 0f, 0);
                npc.ai[0] = 0;
            }
            else if (npc.ai[1] >= 90)
            {
                float speed = 12f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 100;
                int type = 96;
                Main.PlaySound(SoundID.Item, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * speed) * -1), (float)((Math.Sin(rotation) * speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
        }

        public override void NPCLoot()
        {
            SilentNPCWorld.downedMechantera = true;
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
            else
            {

            }
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;
        }

        private void MoveTowards(NPC npc, Vector2 playerTarget, float speed, float turnResistance)
        {
            var move = playerTarget - npc.Center;
            float length = move.Length();
            if (length > speed)
            {
                move *= speed / length;
            }
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            length = move.Length();
            if (length > speed)
            {
                move *= speed / length;
            }
            npc.velocity = move;
        }
    }
}