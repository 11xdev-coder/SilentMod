using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Pets
{
	public class Red_OrbProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
        {
			projectile.CloneDefaults(ProjectileID.DD2PetGato);
			aiType = ProjectileID.DD2PetGato;
        }

		public override bool PreAI()
        {
			Player player = Main.player[projectile.owner];
			player.petFlagDD2Gato = false;
			return true;
        }

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			MyPlayer modPlayer = player.GetModPlayer();
			if (player.dead)
			{
				modPlayer.Pet = false;
			}

			if (modPlayer.Pet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}