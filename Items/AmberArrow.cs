using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cascade.Items
{
	public class AmberArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amber Arrow");
			Tooltip.SetDefault("pew pew");
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Projectiles.Amberarrow>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 32f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}
	}
}