using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class CrimstoneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimstone Bar");
            Tooltip.SetDefault("It pulses with dark energy...");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 35);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 1);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();


        }
    }
}