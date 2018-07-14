using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Axes
{
	public class StoneAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Choppy Choppy!");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 22;
			item.useAnimation = 22;
			item.axe = 10;			//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WoodenBar", 1);
            recipe.AddIngredient(null, "StoneBar", 10);
            recipe.AddTile(null, "WorkStation");
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
