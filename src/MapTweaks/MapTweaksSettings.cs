using ModSettings;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable ConvertToConstant.Global

namespace MapTweaks
{
    internal class MapTweaksSettings : JsonModSettings
    {
        internal static MapTweaksSettings Instance;

        [Name("Override default map drawing range")]
        [Description("If disabled, the default map drawing range will be used. Enable this parameter to override the default range.")]
        public bool OverrideDrawingRange = false;

        [Name("Map drawing range")]
        [Description("Default map drawing range is 150 meters for most of the places and 500 meters for some top places (e.g. forester's house, radio tower hill etc). Drawing range should be in range from 1 up to 10000 meters.")]
        [Slider(1, 10000)]
        public float DrawingRange = 150;
    }
}
