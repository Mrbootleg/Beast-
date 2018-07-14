using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Misc
{
    public class LiquidClout : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Liquid Clout");
            Tooltip.SetDefault("The Clout Master never revealed how he makes this stuff");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 5);
        }

        }
    }