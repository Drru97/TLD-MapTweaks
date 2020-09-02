using MelonLoader;
using UnityEngine;

namespace MapTweaks
{
    internal class MapTweaksMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            MapTweaksSettings.Instance = new MapTweaksSettings();
            MapTweaksSettings.Instance.AddToModSettings("Map Tweaks");

            Debug.Log($"[{Info.Name}] version {Info.Version} loaded!");
        }
    }
}
