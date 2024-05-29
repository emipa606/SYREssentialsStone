using HarmonyLib;
using Verse;

namespace SYR_StoneRebalance;

[StaticConstructorOnStartup]
public static class Main
{
    static Main()
    {
        new Harmony("SYR.StoneRebalance").PatchAll();
    }
}