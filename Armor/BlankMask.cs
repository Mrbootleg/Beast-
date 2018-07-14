using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BlankMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It doesn't really leave alot to to the imagination...");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 2;
            item.vanity = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(null, "WorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}