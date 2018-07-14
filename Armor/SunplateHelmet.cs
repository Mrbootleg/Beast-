using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SunplateHelmet : ModItem
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
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("SunplateBreastplate") && legs.type == mod.ItemType("SunplateLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "SunFury, 10% increased ranged and magic damage.";
			player.rangedDamage *= 1.10f;
			player.magicDamage *= 1.10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SunplateBar", 15);
			recipe.AddTile(null, "SkyForge");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}