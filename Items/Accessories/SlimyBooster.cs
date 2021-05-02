using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cascade.Items.Accessories


{
    public class SlimyBooster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Booster");
            Tooltip.SetDefault("Increases jump height \nAllows the holder to double jump \nRemoves fall damage \nMakes the holder slide \nMassively increases fall speed" +
                "\nExpert");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 1;
            item.rare = -12;
            item.value = 10000;
            item.accessory = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.jumpBoost = true;
            player.doubleJumpFart = true;
            player.maxFallSpeed = 75;
            player.noFallDmg = true;
            player.slippy = true;
        }
    }
}
