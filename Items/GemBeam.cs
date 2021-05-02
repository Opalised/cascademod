
using Cascade.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cascade.Items
{
	public class GemBeam : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Prism");
			Tooltip.SetDefault(@"A prism forged from the residue of the Gem Incarnates");
		}

		public override void SetDefaults()
		{
			// Start by using CloneDefaults to clone all the basic item properties from the vanilla Last Prism.
			// For example, this copies sprite size, use style, sell price, and the item being a magic weapon.
			item.CloneDefaults(ItemID.LastPrism);
			item.mana = 4;
			item.damage = 95;
			item.shoot = ModContent.ProjectileType<Projectiles.GemPrismHoldout>();
			item.shootSpeed = 30f;
		}
		// Because this weapon fires a holdout projectile, it needs to block usage if its projectile already exists.
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.GemPrismHoldout>()] <= 0;
	}
}