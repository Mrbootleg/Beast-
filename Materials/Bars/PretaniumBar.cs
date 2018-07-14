using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class PretaniumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pretanium Bar");
            Tooltip.SetDefault("This will come in very useful...");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 50);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(null, "SunplateBar", 1);
            recipe.AddIngredient(null, "FrostBar", 1);
            recipe.AddIngredient(null, "StoneBar", 1);
            recipe.AddIngredient(null, "WoodenBar", 1);
            recipe.AddIngredient(null, "CloudBar", 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();


        }
    }
}