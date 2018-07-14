using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class ChaosBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Issa ULTRA Lit! +4 Maximum minions, %35 increased minion damage and %125 increased move speed!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 3;
            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.35f;
            player.maxMinions += 4;
            player.moveSpeed += 1.25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaosBar", 10);
            recipe.AddIngredient(null, "LiquidClout", 15);
            recipe.AddIngredient(null, "UltimateBoots", 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}