using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using SilentMod.Events;

namespace SilentMod.NPCs
{
    public class SilentModGlobalNPC : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            //If the custom invasion is up and the invasion has reached the spawn pos
            if (SilentNPCWorld.ApocalypseUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                //Clear pool so that only the stuff you want spawns
                //pool.Clear();

                //key = NPC ID | value = spawn weigh

                //For every ID inside the invader array in our CustomInvasion file
                foreach (int i in Apocalypse.invaders)
                {
                    pool.Add(i, 10f);//Add it to the pool with the same weight of 1
                    //pool.Add(mod.NPCType("Indigo_Slime"), 1f);
                }
            }
        }

        //Changing the spawn rate
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            //Change spawn stuff if invasion up and invasion at spawn
            if (SilentNPCWorld.ApocalypseUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                spawnRate = 60;
                maxSpawns = 1000; //Max spawns of NPCs depending on NPC value
            }
        }

        //Adding to the AI of an NPC
        public override void PostAI(NPC npc)
        {
            //Changes NPCs so they do not despawn when invasion up and invasion at spawn
            if (SilentNPCWorld.ApocalypseUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                npc.timeLeft = 1000;
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.LihzahrdCrawler)
            {
                if (Main.rand.Next(20) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Soul_of_Bright"));
                }
            }

            if (SilentNPCWorld.ApocalypseUp)
            {
                //Gets IDs of invaders from CustomInvasion file
                foreach (int invader in Apocalypse.invaders)
                {
                    //If npc type equal to invader's ID decrement size to progress invasion
                    if (npc.type == invader)
                    {
                        Main.invasionSize -= 1;
                    }
                }
            }
        }
    }
}