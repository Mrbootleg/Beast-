using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class FrostBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Frost Breastplate");
			Tooltip.SetDefault("Your chest begins to freeze... giving you immunity to fire blocks!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FrostBar", 15);
			recipe.AddTile(null, "WorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}