using BeastPack.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
    public class Frostbite : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 29;
            item.useTime = 29;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = 11;
            item.rare = 2;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(silver: 1);
            item.shoot = mod.ProjectileType<FrostbiteProjectile>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FrostBar", 5);
            recipe.AddIngredient(ItemID.WoodYoyo);
            recipe.AddTile(null, "AdvancedWorkStation");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            int ConTrue = 0;
            if (Main.rand.Next(1) == 0)
            {
                ConTrue = Main.rand.Next(1, 5);
            }

            if (ConTrue == 1)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }
        }
    }
}