using Harmony;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
    [StaticConstructorOnStartup]
    static class MyStaticConstructor
    {
        static MyStaticConstructor()
        {
            var harmony = HarmonyInstance.Create("rimworld.loonyladle.bones");
            harmony.PatchAll();
        }
    }
}
