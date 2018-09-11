using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace Galium.Items
{
	public class LunarMiniGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Mini Gun");
            Tooltip.SetDefault("Legendary...");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
            item.crit = 10;
			item.ranged = true;
			item.width = 36;
			item.height = 15;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 0;
			item.value = Item.buyPrice(1, 0, 0, 0); 
            item.value = Item.sellPrice(5, 10, 0, 0);
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ISMGE"));
            recipe.AddIngredient(ItemID.IllegalGunParts, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 35);
            recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}
        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 1.0f;
    	}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
			type = ProjectileID.MoonlordBullet; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
        
    }
}


