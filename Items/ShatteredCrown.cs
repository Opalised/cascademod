using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cascade.Items


{
    public class ShatteredCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shattered Crown");
            Tooltip.SetDefault("Summons the old royal.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.rare = 4;
            item.value = 10000;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
        }

        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(mod.NPCType("EmeraldSlime"));
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position);
            if(Main.netMode !=1)
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("EmeraldSlime"));
            }
            return true;
        }
    }
}
