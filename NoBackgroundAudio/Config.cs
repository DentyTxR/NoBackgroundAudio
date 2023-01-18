using Exiled.API.Interfaces;
using System.ComponentModel;

namespace NoBackgroundAudio
{
    public class Config : IConfig
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Effect intensity (255 max)")]
        public ushort EffectIntensity { get; set; } = 255;
    }
}
