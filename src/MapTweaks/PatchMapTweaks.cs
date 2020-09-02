using Harmony;

// ReSharper disable UnusedMember.Local

namespace MapTweaks
{
    [HarmonyPatch(typeof(Panel_Map))]
    [HarmonyPatch("DoNearbyDetailsCheck")]
    internal static class PatchMapTweaks
    {
        private static void Prefix(ref float radius)
        {
            if (MapTweaksSettings.Instance.OverrideDrawingRange && MapTweaksSettings.Instance.DrawingRange > 0)
            {
                radius = MapTweaksSettings.Instance.DrawingRange;
            }
        }
    }
}
