//using Terraria;
//using Terraria.ID;
//using Terraria.ModLoader;

//namespace SilentMod.Items.Ammo
//{
//    public class Amber_Bullet : ModItem
//    {
//        public override void SetStaticDefaults()
//        {
//            DisplayName.SetDefault("Amber Bullet");
//            Tooltip.SetDefault("Just a bullet what do you want to see here???");
//        }

//        public override void SetDefaults()
//        {
//            item.damage = 9;
//            item.ranged = true;
//            item.width = 8;
//            item.height = 8;
//            item.maxStack = 999;
//            item.consumable = true;
//            item.knockBack = 1.5f;
//            item.value = 10;
//            item.rare = ItemRarityID.Green;
//            item.shoot = ModContent.ProjectileType<Amber_Bullet_Projectile>();
//            item.shootSpeed = 16f;
//            item.ammo = AmmoID.Bullet;
//        }


//    }
//}