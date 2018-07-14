using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class FrostBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bar");
            Tooltip.SetDefault("'Cold to the touch' ");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver:25);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.IceBlock, 30);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();


        }
    }
}