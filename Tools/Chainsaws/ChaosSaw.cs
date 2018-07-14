using Terraria;
using Terraria.ID;
using BeastPack.Projectiles;
using Terraria.ModLoader;

namespace BeastPack.Items.Tools.Chainsaws
{
    public class ChaosSaw : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chaos Saw");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 20;
            item.height = 12;
            item.useTime = 7;
            item.useAnimation = 25;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 15;
            item.useStyle = 5;
            item.knockBack = 4;
            item.rare = 5;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ChaosSawProj");
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