using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Placeable
{
	public class AdvancedWorkStation : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dabble in the complexity of elements!");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("AdvancedWorkStation");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bottle, 3);
            recipe.AddIngredient(null, "WorkStation", 1);
            recipe.AddIngredient(null, "EbonstoneBar", 5);
            recipe.AddIngredient(null, "WoodenBar", 5);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}