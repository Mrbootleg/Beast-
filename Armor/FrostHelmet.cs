using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class FrostHelmet : ModItem
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
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("FrostBreastplate") && legs.type == mod.ItemType("FrostLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "FrostRage, 20% increased melee and ranged damage.";
			player.meleeDamage *= 1.2f;
			player.rangedDamage *= 1.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FrostBar", 10);
			recipe.AddTile(null, "WorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}