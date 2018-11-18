using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Superstition : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Stition");
			Tooltip.SetDefault("BRIGHTNESS 100");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 46;
			item.height = 46;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.crit = 0;
			item.value = Item.buyPrice(0, 0, 75, 0);
			item.rare = 1; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.useTurn = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("HadridionBar"), 6);
			recipe.AddIngredient(mod.ItemType("EyeKeeper"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
     
		
		public override void MeleeEffects( Player player, Rectangle hitbox)
        {
            Lighting.AddLight(new Vector2(hitbox.Center.X, hitbox.Center.Y), .0f, .3f, .7f);

			if (Main.rand.NextBool(3))
			{
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 88);
			}
        }
	}
}
