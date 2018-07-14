using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Bars
{
    public class EbonstoneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ebonstone Bar");
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

            recipe.AddIngredient(ItemID.EbonstoneBlock, 10);
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();


        }
    }
}