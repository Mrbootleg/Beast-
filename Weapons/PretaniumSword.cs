using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
	public class PretaniumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pretanium Sword");
			Tooltip.SetDefault("");
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

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(null, "PretaniumBar", 10);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
