using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace Galium.Items
{
	public class ISMGE : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ISMGE");
            Tooltip.SetDefault("Will never use ammo!");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
            item.crit = 0;
			item.ranged = true;
			item.width = 36;
			item.height = 15;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 0;
			item.value = Item.buyPrice(0, 10, 0, 0); 
            item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Minishark);
            recipe.AddIngredient(ItemID.IllegalGunParts, 2);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
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
}   }	}