using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ChaosHoodie : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Chaos Hoodie");
            Tooltip.SetDefault("Issa Chaos! +3 maximum minions and 15% increased minion damage!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 6);
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.15f;
            player.maxMinions += 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaosBar", 5);
            recipe.AddIngredient(null, "LiquidClout", 10);
            recipe.AddIngredient(null, "CloutHoodie", 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}