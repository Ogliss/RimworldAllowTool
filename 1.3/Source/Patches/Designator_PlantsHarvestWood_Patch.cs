﻿using HarmonyLib;
using RimWorld;
using Verse;

namespace AllowTool.Patches {
	/// <summary>
	/// Prevents the Anima tree from being designated when dragging the Chop wood tool
	/// </summary>
	[HarmonyPatch(typeof(Designator_PlantsHarvestWood), "CanDesignateThing", typeof(Thing))]
	internal static class Designator_PlantsHarvestWood_Patch {
		[HarmonyPostfix]
		public static void PreventAnimaTreeMassDesignation(Thing t, ref AcceptanceReport __result) {
			__result = AnimaTreeMassDesignationFix.RejectAnimaTreeMassDesignation(t, __result);
		}
	}
}