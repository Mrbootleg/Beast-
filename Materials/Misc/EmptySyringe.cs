using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Misc
{
    public class EmptySyringe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empty Syringe");
            Tooltip.SetDefault("Could be used to make drug- i mean healing items.");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 1);
        }

        }
    }