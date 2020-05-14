using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
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
