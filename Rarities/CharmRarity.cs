using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace HollowKnightItems.Rarities
{
    internal class CharmRarity : ModRarity
    {
        public override Color RarityColor => new(191, 158, 112);

        public override int GetPrefixedRarity(int offset, float valueMult)
        {
            if (offset > 0)
            {
                return ModContent.RarityType<CharmRarity>();
            }

            return Type;
        }
    }
}
