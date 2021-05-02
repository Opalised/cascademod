using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cascade.Items.Accessories


{
    public class DryadsGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dryad's Gem");
            Tooltip.SetDefault("Things are grim indeed...");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 1;
            item.rare = 7;
            item.value = 10000;
            item.accessory = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.statDefense += 5;
            player.statLifeMax2 += 50;
            player.statManaMax += 50;
        }
    }
}
