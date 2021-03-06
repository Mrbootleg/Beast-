﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BeastPack.Items.Weapons
{
	public class BeamBook : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Beam Book");
            Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 54;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item33;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
            item.shoot = ProjectileID.EnchantedBeam;
            item.value = Item.sellPrice(gold: 5);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.UnicornHorn, 1);
            recipe.AddIngredient(ItemID.PixieDust, 5);
            recipe.AddIngredient(ItemID.CrystalShard, 5);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
