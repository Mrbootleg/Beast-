using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class CloudBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cloud Bar");
            Tooltip.SetDefault("It's trying to fly out of your pocket!");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 25);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Cloud, 50);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();


        }
    }
}