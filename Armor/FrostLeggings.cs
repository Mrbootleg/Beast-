using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class FrostLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Your feet are freezing!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FrostBar", 10);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}