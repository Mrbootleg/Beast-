using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class StoneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Bar");
            Tooltip.SetDefault("I guess you could say its 'Rock Hard?'");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 5);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();


        }
    }
}