using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Ammo
{
	public class WoodenPellet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Wooden Pellet");
            Tooltip.SetDefault("Dont kill your foes, bruise them!");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
            item.shoot = ProjectileID.Bullet;  //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WoodenBar", 1);
            recipe.AddTile(null, "WorkStation");
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
