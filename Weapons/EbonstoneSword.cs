using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
	public class EbonstoneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ebonstone Sword");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 28;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 500000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(null, "EbonstoneBar", 10);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
