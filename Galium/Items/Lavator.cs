using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Lavator : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lavator");
			Tooltip.SetDefault("Caution! Hot Object!");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 2;
			item.crit = 13;
			item.value = 5000;
			item.rare = 5;
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
