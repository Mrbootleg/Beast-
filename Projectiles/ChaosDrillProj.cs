using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Projectiles
{
    public class ChaosDrillProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 48;
            projectile.height = 40;
            projectile.aiStyle = 20;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.hide = true;
            projectile.ownerHitCheck = true; //so you can't hit enemies through walls
            projectile.melee = true;
        }
    }
}