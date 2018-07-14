using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PretaniumBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Pretanium Breastplate");
			Tooltip.SetDefault("You are immune to lava wearing this.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.AddBuff(BuffID.ObsidianSkin, 2);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PretaniumBar", 20);
			recipe.AddTile(null, "AdvancedWorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}