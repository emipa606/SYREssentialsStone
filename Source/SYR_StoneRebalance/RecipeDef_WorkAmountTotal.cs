using HarmonyLib;
using Verse;

namespace SYR_StoneRebalance;

[HarmonyPatch(typeof(RecipeDef), nameof(RecipeDef.WorkAmountTotal))]
public class RecipeDef_WorkAmountTotal
{
    public static void Postfix(ref float __result, RecipeDef __instance)
    {
        if (__instance == StoneRebalanceDefOf.Make_StoneBlocksAny)
        {
            __result = 1500f;
        }
    }
}