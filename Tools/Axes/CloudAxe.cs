using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Axes
{
	public class CloudAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Its VERY light");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.axe = 13;			//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 3000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CloudBar", 5);
            recipe.AddIngredient(null, "StoneBar", 10);
            recipe.AddTile(null, "SkyForge");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
            }
		}
	}
}
