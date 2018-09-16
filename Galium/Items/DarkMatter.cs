using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class DarkMatter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Matter");
			Tooltip.SetDefault("That's Dark!");
        }

        public override void SetDefaults()
        {
			item.width = 30;
			item.height = 30;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 2, 50, 0);
            item.rare = 11;
            // Set other item.X values here
        }
    }
}