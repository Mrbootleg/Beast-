using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BeastPack.Items.Weapons
{
	public class BookOfPumpkins : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Book Of Pumpkins");
            Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item12;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
            item.shoot = ProjectileID.FlamingJack;
            item.value = Item.sellPrice(silver: 20);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.Pumpkin, 10);
            recipe.AddIngredient(ItemID.Torch, 10);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
