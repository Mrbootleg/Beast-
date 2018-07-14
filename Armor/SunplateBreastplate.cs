using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SunplateBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sunplate Breastplate");
			Tooltip.SetDefault("+40 mana");
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
			player.buffImmune[BuffID.OnFire] = false;
			player.statManaMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SunplateBar", 25);
			recipe.AddTile(null, "SkyForge");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}