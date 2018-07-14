using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Ammo
{
	public class HallowedShot : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Hallowed Shot");
            Tooltip.SetDefault("Blessed by unicorns and fairy's");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1000;
			item.rare = 2;
            item.shoot = ProjectileID.Bullet;  //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
