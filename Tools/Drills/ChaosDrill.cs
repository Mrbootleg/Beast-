using Terraria;
using Terraria.ID;
using BeastPack.Projectiles;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Drills
{
    public class ChaosDrill : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chaos Drill");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.width = 20;
            item.height = 12;
            item.useTime = 7;
            item.useAnimation = 29;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.pick = 85;
            item.useStyle = 5;
            item.knockBack = 4;
            item.rare = 5;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ChaosDrillProj");
            item.shootSpeed = 40f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaosBar", 12);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    }