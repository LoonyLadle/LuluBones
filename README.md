# Lulu's Bones and Chitin
Adds bones and chitin as new woody materials.

## Gameplay Notes
Bone has very similar properties to wood. It is better for sharp weapons and heat insulation compared to wood's blunt weapons and cold insulation. To allow the best use of bones campfires, passive coolers, and torches can now be made out of any woody stuff instead of just wood. Anything that can be refueled with wood (kitchens, smithies, wood-fired generators) can now take bone. Knives can now be made of woody materials. Bone and chitin can be mixed in when refining chemfuel from wood. The only thing that still requires wood and cannot take bone as a substitute is the butcher's table.

Chitin is obtained from insects. Statwise it does its own thing, being most effective when used to make structures (especially doors) and armor, and is comparatively poor as a weapon material. Unlike bone, it cannot be used as fuel.

Thrumbone is obtained from butchering thrumbos. It makes excellent sharp weapons, high-health and fast-opening doors, and beautiful sculptures; you'll probably have a hard time deciding what to use this rare material for!

## Mod Extensions
This mod exposes a ModExtension so that other modders (like you!) can add your own bone defs. To use it, just add the following code (or similar) to your patch file:

```xml
<Operation Class="PatchOperationFindMod">
  <mods>
    <li>Lulu's Bones and Chitin</li>
  </mods>
  <match Class="PatchOperationAddModExtension">
    <xpath>Defs/ThingDef[defName="YOUR_TARGET_HERE"]</xpath>
    <value>
      <li Class = "LoonyLadle.Bones.BoneProductExt">
        <boneDef>YOUR_BONE_DEF_HERE</boneDef>
      </li>
    </value>
  </match>
</Operation>
```
