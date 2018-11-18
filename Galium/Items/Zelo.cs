using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Zelo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zelo");
			Tooltip.SetDefault("Fire and Flames");
		}
		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 8;
			item.crit = 27;
			item.value = 100000;
			item.rare = -12;
			item.shoot = 296; 
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.useTurn = true;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.DayBreak);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.AddIngredient(mod.ItemType("Glowmite"), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 5; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
     
		}
		public override void MeleeEffects( Player player, Rectangle hitbox)
        {
            Lighting.AddLight(new Vector2(hitbox.Center.X, hitbox.Center.Y), .5f, .5f, .5f);
            
           
        }
	}
}
