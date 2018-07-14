using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Materials.Misc
{
    public class Junk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Junk");
            Tooltip.SetDefault("I don't think it's useful.");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
        }

        }
    }