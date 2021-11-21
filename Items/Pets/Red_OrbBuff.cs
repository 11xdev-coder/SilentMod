using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Pets
{
	public class Red_OrbBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Red Orb");
			Description.SetDefault("Red orb is follows you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
        {
			player.buffType[buffIndex] = 18000;
			player.GetModPlayer<MyPlayer>().Pet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Red_OrbProj")] <= 0;
			if(petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Red_OrbProj"), 0, 0f, player.whoAmI, 0f, 0f);
			}
        }
	}
}