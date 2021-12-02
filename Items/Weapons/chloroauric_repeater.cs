using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SilentMod.Items.Weapons
{
	public class chloroauric_repeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloroauric Repeater");
			Tooltip.SetDefault("Shoot 3-5 arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 49; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 54; // hitbox width of the item
			item.height = 24; // hitbox height of the item
			item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Lime; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item5; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = ProjectileID.WoodenArrowFriendly; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("chloroauric_bar"), 13);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2); // 3 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
										 																		// If you want to randomize the speed to stagger the projectiles
																												// float scale = 1f - (Main.rand.NextFloat() * .3f);
																												// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}