using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HollowKnightItems.Players
{
    internal class SummonsPlayer : ModPlayer
    {
        public bool HasGrimmchild;

        public override void ResetEffects()
        {
            HasGrimmchild = false;
        }

        public override void PostSellItem(NPC vendor, Item[] shopInventory, Item item)
        {
            if (vendor.type == NPCID.Guide)
            {
                item.TurnToAir();
            }
        }
    }
}
