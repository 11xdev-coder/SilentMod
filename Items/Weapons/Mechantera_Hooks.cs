using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Weapons
{
	public class Mechantera_Hooks : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechantera Hooks");
			Tooltip.SetDefault("Expert");
		}

		public override void SetDefaults()
		{
			item.damage = 56; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 20; // hitbox width of the item
			item.height = 40; // hitbox height of the item
			item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noUseGraphic = true;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Expert; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item1; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = ProjectileID.ChainGuillotine; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f; // the speed of the projectile (measured in pixels per frame)
		}
	}
}