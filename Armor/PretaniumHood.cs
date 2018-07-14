using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PretaniumHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("You see everything... Maxmium mana +60");
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
            player.statManaMax2 += 60;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PretaniumBreastplate") && legs.type == mod.ItemType("PretaniumLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "AllSeeing, Maximum mana increased by 150 and Spelunker, Shine and NightOwl buff gained.";
			player.AddBuff(BuffID.Spelunker, 2);
			player.AddBuff(BuffID.Shine, 2);
            player.AddBuff(BuffID.NightOwl, 2);
            player.statManaMax2 += 150;
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