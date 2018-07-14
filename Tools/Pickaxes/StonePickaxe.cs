 using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Pickaxes
{
	public class StonePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Smashy Smashy!");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.pick = 35;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "StoneBar", 10);
            recipe.AddIngredient(null, "WoodenBar", 1);
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