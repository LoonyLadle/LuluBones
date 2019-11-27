using RimWorld;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
	[DefOf]
	public static class MyDefOf
	{
		static MyDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(MyDefOf));

		public static StatDef BoneAmount;
		public static ThingDef LuluBones_Bone;
		public static ThingDef LuluBones_Chitin;
	}
}
