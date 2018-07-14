using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BeastPack.Items.Weapons
{
	public class BookOfSharks : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Book Of Sharks");
            Tooltip.SetDefault("Chomps down on your foes");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 16;
			item.UseSound = SoundID.Item21;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 16;
            item.shoot = ProjectileID.MiniSharkron;
            item.value = Item.sellPrice(silver: 30);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.SharkFin, 5);
            recipe.AddIngredient(ItemID.Glowstick, 10);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
