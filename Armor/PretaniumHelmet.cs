using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PretaniumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PretaniumBreastplate") && legs.type == mod.ItemType("PretaniumLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "PowerfulHands, 80% increased Melee Damage.";
			player.meleeDamage *= 1.80f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PretaniumBar", 15);
			recipe.AddTile(null, "AdvancedWorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}