using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class CloutPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clout Pants");
            Tooltip.SetDefault("Issa Lit! +1 maximum minions and %10 increased minion damage!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 3);
            item.rare = 2;
            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.10f;
            player.maxMinions += 1;
        }
    }
}