using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BeastPack.Items.Weapons
{
    public class BookOfBombs: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BookOfBombs");
            Tooltip.SetDefault("Dont use this inside...");
        }

        public override void SetDefaults()
        {
            item.damage = 0;
            item.noMelee = true;
            item.magic = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.mana = 30;
            item.rare = 5;
            item.width = 28;
            item.height = 30;
            item.useTime = 40;
            item.UseSound = SoundID.Item1;
            item.useStyle = 5;
            item.shootSpeed = 14f;
            item.useAnimation = 40;
            item.shoot = ProjectileID.StickyBomb;
            item.value = Item.sellPrice(silver: 99);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.StickyBomb, 99);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}