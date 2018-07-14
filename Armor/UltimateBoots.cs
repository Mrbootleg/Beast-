using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class UltimateBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Issa Super Lit! +3 Maximum minions, %25 increased minion damage and %100 increased move speed!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 8);
            item.rare = 2;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.25f;
            player.maxMinions += 3;
            player.moveSpeed += 1.00f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PretaniumBar", 5);
            recipe.AddIngredient(null, "LiquidClout", 10);
            recipe.AddIngredient(ItemID.HermesBoots, 1);
            recipe.AddIngredient(null, "HermesClout", 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}