using Terraria;
using Terraria.ModLoader;

namespace BeastPack.Items.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class SunplateShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A cloud shield just wouldnt work.");
		}

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
            item.defense = 4;
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.name == "Mrbootleg")
			{
				player.meleeDamage += 19f;
				player.thrownDamage += 19f;
				player.rangedDamage += 19f;
				player.magicDamage += 19f;
				player.minionDamage += 19f;
				player.endurance = 1f - 0.1f * (1f - player.endurance);
			}
			else
			{
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SunplateBar", 10);
			recipe.AddTile(null, "SkyForge");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}