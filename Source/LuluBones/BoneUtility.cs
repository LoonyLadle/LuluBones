using RimWorld;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
    public static class BoneUtility
    {
        public static ThingDef GetBoneProductFor(Pawn pawn)
        {
            if (pawn.def.race.FleshType == FleshTypeDefOf.Insectoid)
            {
                return MyDefOf.LuluBones_Chitin;
            }
            /*
            if (pawn.def.race.intelligence == Intelligence.Humanlike)
            {
                return MyDefOf.LuluBones_BoneHumanlike;
            }
            */
            return MyDefOf.LuluBones_Bone;
        }
    }
}
