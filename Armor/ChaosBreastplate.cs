using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ChaosBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Chaos Breastplate");
			Tooltip.SetDefault("It glows...");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
            player.AddBuff(BuffID.Shine, 2);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChaosBar", 15);
			recipe.AddTile(null, "AdvancedWorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}