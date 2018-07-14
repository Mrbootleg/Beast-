using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
    public class CloutMansSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clout Mans Sword");
            Tooltip.SetDefault("How did you get this?");
        }
        public override void SetDefaults()
        {
            item.damage = 37;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 500000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}