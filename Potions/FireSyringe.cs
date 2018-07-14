﻿using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeastPack.Items.Potions
{
    public class FireSyringe : ModItem
    {
        public override void SetDefaults()
        {
            item.healLife = 5;
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 32;
            item.useTime = 32;
            item.maxStack = 50;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;
            item.rare = 2;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "EmptySyringe", 1);
            recipe.needLava = true;
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}