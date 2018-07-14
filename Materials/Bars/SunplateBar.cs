using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class SunplateBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunplate Bar");
            Tooltip.SetDefault("Another heavenly bar...");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 30);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.SunplateBlock, 75);
            recipe.AddTile(null, "SkyForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();


        }
    }
}