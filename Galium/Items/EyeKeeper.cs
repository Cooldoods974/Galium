using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class EyeKeeper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye Keeper");
			Tooltip.SetDefault("The All Seeing Eye");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 65;
			item.height = 65;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.crit = 10;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Retina"));
			recipe.AddIngredient(ItemID.Lens, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
