# GitHub Copilot Instructions for [SYR] Essentials: Stone (Continued)

## Mod Overview and Purpose
[SYR] Essentials: Stone (Continued) is a RimWorld mod that updates and rebalances the stone types, particularly focusing on granite and jade. The mod aims to give each stone type a clear purpose, making acquiring specific types worthwhile and choosing your starting tile more interesting. It also improves the colors of granite and adds two new jade floor types.

## Key Features and Systems
- **Rebalanced Stone Types**: All stone types are easier to mine, have the same mass, and sharp damage. Cutting stone blocks is faster depending on the type.
- **Granite**: Recolored to avoid looking like sandstone, it is more sturdy but requires more work.
- **Jade**: Recolored and two new jade floor types are added.
- **XML Integration**: The mod includes XML files for defining terrains and other mod components.
- **Harmony Patching**: The mod uses Harmony for patching existing game mechanics to implement the rebalances.

## Coding Patterns and Conventions
- **C# Files**: The mod includes three C# files:
  - `RecipeDef_WorkAmountTotal.cs`: Contains a postfix patch for adjusting work amounts.
  - `Main.cs`: Contains the main entry point for the mod.
  - `StoneRebalanceDefOf.cs`: Contains constant definitions for stone rebalances.
- **XML Files**: The mod includes four XML files:
  - `StoneRebalance_Patches.xml`: Defines Harmony patches.
  - `About.xml`: Provides mod metadata and dependencies.
  - `ModSync.xml`: Handles mod synchronization.
  - `TerrainDefs.xml`: Defines custom terrain types.

## XML Integration
The mod uses XML to define custom terrain types and patches. Key XML files include:

- **TerrainDefs.xml**: Contains definitions for new jade floor types.
- **StoneRebalance_Patches.xml**: Contains Harmony patches for rebalancing stone types.

## Harmony Patching
The mod uses Harmony to patch existing game mechanics. Key patches include:

- **RecipeDef_WorkAmountTotal.cs**: Adjusts the work amount for recipes related to stone.
- **Main.cs**: Initializes the mod and applies patches.

## Suggestions for Copilot
When working with [SYR] Essentials: Stone (Continued), consider the following suggestions for Copilot:

- **Use XML for Definitions**: When defining new terrain types or mod components, use the existing XML files as a reference.
- **Harmony Patches**: When creating new patches, refer to the existing Harmony patches in the C# files for guidance on how to structure and implement them.
- **Coding Conventions**: Follow the existing coding conventions, such as using postfix patches for modifying existing methods.

## Example Usage
Here is an example of how Copilot can be used to generate XML for a new terrain type:

xml
<TerrainDef>
    <defName>GraniteFloor</defName>
    <label>Granite Floor</label>
    <description>A sturdy floor made of granite.</description>
    <statBases>
        <Beauty>3.0</Beauty>
        <Mass>2.0</Mass>
    </statBases>
    <graphicData>
        <texPath>GraniteFloor</texPath>
        <color>0.5, 0.5, 0.5</color>
    </graphicData>
</TerrainDef>


And here is an example of how Copilot can be used to generate a Harmony patch in C#:

csharp
using HarmonyLib;
using RimWorld;
using Verse;

namespace SYR_StoneRebalance
{
    [HarmonyPatch(typeof(RecipeDef), "WorkAmountTotal", MethodType.Getter)]
    public static class RecipeDef_WorkAmountTotal
    {
        public static void Postfix(ref float __result)
        {
            // Adjust work amount based on stone type
            __result *= 0.9f;
        }
    }
}


By following these guidelines and using Copilot effectively, you can contribute to and expand the functionality of [SYR] Essentials: Stone (Continued).

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

