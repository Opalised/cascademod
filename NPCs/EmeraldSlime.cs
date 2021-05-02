using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using NPCs.CascadeNpcsWorld;

namespace Cascade.NPCs
{
    [AutoloadBossHead]
    public class EmeraldSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Slime");
        }

        public override void SetDefaults()
        {
            npc.width = 256;
            npc.height = 128;

            npc.boss = true;
            npc.aiStyle = 87;
            npc.npcSlots = 5f;

            npc.lifeMax = 1500;
            npc.damage = 50;
            npc.defense = 10;
            npc.knockBackResist = 0f;

            npc.value = Item.buyPrice(gold: 2, silver: 50);

            npc.lavaImmune = true;
            npc.noTileCollide = false;
            npc.noGravity = false;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss2;

            bossBag = mod.ItemType("EmeraldSlimeBossBag");
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
            npc.damage = (int)(npc.damage * 1.3f);
        }

        public override void NPCLoot()
        {
            CascadeNpcsWorld.DownedEmeraldSlime = true;
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
        }
    }
}