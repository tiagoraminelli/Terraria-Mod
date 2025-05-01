
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TestMod.Content.Proyectiles
{
    internal class CavalierProyectile : ModProjectile
    {
    
        public override void SetDefaults() 
        {
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 10;
            Projectile.timeLeft = 720;
            Projectile.light = 0.1f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 0;
        }
        public override void AI()
        {
            Projectile.ai[0] += 1f;
            if (Projectile.ai[0] % 20 == 0) 
            {
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center,
                Projectile.velocity,ProjectileID.CursedFlameFriendly,20,7);
            
            }

        }
    }
}