using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Axes
{
	public class EbonstoneAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Your hands are trembling...");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.axe = 16;			//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EbonstoneBar", 5);
            recipe.AddIngredient(null, "StoneBar", 10);
            recipe.AddTile(null, "AdvancedWorkStation");
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
