using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CloutHoodie : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Clout Hoodie");
            Tooltip.SetDefault("Issa Lit! +2 maximum minions and 10% increased minion damage!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 4);
            item.rare = 2;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage *= 1.10f;
            player.maxMinions += 2;
        }
    }
}