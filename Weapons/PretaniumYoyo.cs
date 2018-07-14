using BeastPack.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Weapons
{
    public class PretaniumYoyo : ModItem
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
            item.useAnimation = 17;
            item.useTime = 17;
            item.shootSpeed = 18f;
            item.knockBack = 4f;
            item.damage = 28;
            item.rare = 4;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(silver: 1);
            item.shoot = mod.ProjectileType<PretaniumYoyoProjectile>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PretaniumBar", 5);
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