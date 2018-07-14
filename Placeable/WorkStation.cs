using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Placeable
{
	public class WorkStation : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It even has a light!");
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
			item.createTile = mod.TileType("WorkStation");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench, 1);
            recipe.AddIngredient(ItemID.Chain, 5);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}