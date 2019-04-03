using Harmony;
using RimWorld;
using System.Collections.Generic;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var harmony = HarmonyInstance.Create("rimworld.loonyladle.bones");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(Corpse), nameof(Corpse.SpecialDisplayStats))]
    public static class HarmonyPatch_Corpse_SpecialDisplayStats
    {
        public static IEnumerable<StatDrawEntry> Postfix(IEnumerable<StatDrawEntry> entries, Corpse __instance)
        {
            foreach (StatDrawEntry entry in entries)
            {
                yield return entry;
            }
            StatDef BoneAmount = MyDefOf.BoneAmount;
            float pawnBoneCount = __instance.InnerPawn.GetStatValue(BoneAmount);
            yield return new StatDrawEntry(BoneAmount.category, BoneAmount, pawnBoneCount, StatRequest.For(__instance.InnerPawn));
        }
    }

    [HarmonyPatch(typeof(Pawn), nameof(Pawn.ButcherProducts))]
    public static class HarmonyPatch_Pawn_ButcherProducts
    {
        public static IEnumerable<Thing> Postfix(IEnumerable<Thing> products, Pawn __instance, float efficiency)
        {
            foreach (Thing product in products)
            {
                yield return product;
            }

            int boneCount = GenMath.RoundRandom(__instance.GetStatValue(MyDefOf.BoneAmount) * efficiency);
            if (boneCount > 0)
            {
                Thing bones = ThingMaker.MakeThing(BoneUtility.GetBoneProductFor(__instance));
                bones.stackCount = boneCount;
                yield return bones;
            }
        }
    }
}
