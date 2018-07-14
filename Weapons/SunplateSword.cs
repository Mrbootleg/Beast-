using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
	public class SunplateSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sunplate Sword");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 800;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(null, "SunplateBar", 10);
            recipe.AddTile(null, "SkyForge");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
