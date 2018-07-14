using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class PretaniumLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You feel as if you could run a mile in seconds. move speed +%55");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.55f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PretaniumBar", 10);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}