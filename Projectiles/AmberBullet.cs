using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Cascade.Projectiles
{
    public class Amberbullet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Bullet");
        }


        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 12;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = 20;
            projectile.ranged = true;
        }

        public override void Kill(int timeLeft)
        {
            if (projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem(projectile.getRect(), mod.ItemType("Amberarrow")) : 0;
            }
        }


        public override void AI()
        {
            if (projectile.ai[0] == 0f)
            {
                projectile.ai[0] = 1f;
                Main.PlaySound(SoundID.Item37, projectile.position);
            }

            projectile.rotation += (float)projectile.direction * 1f;
            projectile.ai[1] += 1f;
            if (projectile.ai[1] > 30f)
            {
                if (projectile.ai[1] < 100f)
                {
                    projectile.velocity.X *= 1.2f;
                }
                else
                {
                    projectile.ai[1] = 200f;

                }

            }
        }





    }
}