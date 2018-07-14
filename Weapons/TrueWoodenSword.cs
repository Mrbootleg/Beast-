using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
	public class TrueWoodenSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Wooden Sword ");
			Tooltip.SetDefault("Well, it looks cooler than the original.");
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.WoodenSword, 1);
            recipe.AddIngredient(null, "WoodenBar", 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
