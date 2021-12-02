using Terraria.ID;
using Terraria.ModLoader;

namespace SilentMod.Items.Weapons
{
	public class chloroauric_bow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloroauric Bow");
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
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Green; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item5; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = ProjectileID.WoodenArrowFriendly; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("chloroauric_bar"), 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}