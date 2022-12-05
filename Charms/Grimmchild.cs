using HollowKnightItems.Buffs;
using HollowKnightItems.Projectiles;
using HollowKnightItems.Rarities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HollowKnightItems.Charms
{
    internal class Grimmchild : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grimmchild");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "格林之子");
            Tooltip.SetDefault("Symbol of a completed ritual. Contains a living, scarlet flame.");
            Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, "一场完成的仪式的标志。包含着一团跳动的猩红之火。");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ModContent.RarityType<CharmRarity>();

            Item.value = 100;
        }

        /*public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }*/

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<GrimmchildSummon>()] == 0)
            {
                Projectile.NewProjectile(player.GetSource_Accessory(Item),
                    player.Center,
                    new Vector2(0, 0),
                    ModContent.ProjectileType<GrimmchildSummon>(),
                    0,
                    0,
                    player.whoAmI);
            }
            player.AddBuff(ModContent.BuffType<GrimmchildBuff>(), 2);
        }
    }
}