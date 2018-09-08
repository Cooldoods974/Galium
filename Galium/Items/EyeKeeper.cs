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
			item.damage = 20;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.crit = 0;
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
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
