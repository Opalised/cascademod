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
    public class EmeraldSlimeBossBag : ModItem
    {
        public override int BossBagNPC => mod.NPCType("EmeraldSlime");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 32;
            item.maxStack = 999;
            item.rare = 4;
            item.consumable = true;
            item.rare = -12;
            item.expert = true;

        }

        public override void OpenBossBag(Player player)
        {
            player.QuickSpawnItem(ItemID.GoldCoin, 5);
            player.QuickSpawnItem(ModContent.ItemType<Accessories.SlimyBooster>());
            player.QuickSpawnItem(ItemID.Gel, 50);
        }
    }
}
