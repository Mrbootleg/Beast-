using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class HermesClout : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Issa Very Lit! +2 Maximum minions, %15 increased minion damage and %65 move speed!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 5);
            item.rare = 2;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.15f;
            player.maxMinions += 2;
            player.moveSpeed += 0.65f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HermesBoots, 1);
            recipe.AddIngredient(null, "CloutPants", 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}