using RimWorld;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
	public static class BoneUtility
	{
		public static ThingDef GetBoneProductFor(Pawn pawn)
		{
			ThingDef specialBoneProduct = pawn.def.GetModExtension<BoneProductExt>()?.boneDef;

			if (specialBoneProduct != null)
			{
				return specialBoneProduct;
			}
			else if (pawn.def.race.FleshType == FleshTypeDefOf.Insectoid)
			{
				return MyDefOf.LuluBones_Chitin;
			}
			else
			{
				return MyDefOf.LuluBones_Bone;
			}
		}
	}
}
