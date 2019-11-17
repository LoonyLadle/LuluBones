﻿using System.Collections.Generic;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace LoonyLadle.Bones
{
	public class BoneProductExt : DefModExtension
	{
		public ThingDef boneDef;

		public override IEnumerable<string> ConfigErrors()
		{
			if (boneDef == null)
			{
				yield return "null boneDef";
			}
			yield break;
		}
	}
}
