using Exiled.API.Interfaces;
using System.ComponentModel;

namespace NoBackgroundAudio
{
    public class Config : IConfig
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug logs be enabled?")]
        public bool Debug { get; set; } = false;

        [Description("Effect intensity (255 max)")]
        public ushort EffectIntensity { get; set; } = 255;

        [Description("Should the plugin automatically remove background audio when joining the server?")]
        public bool RemoveBackgroundSfxOnJoin { get; set; } = true;

        [Description("Should the plugin automatically remove background audio when changing a players role?")]
        public bool RemoveBackgroundSfxOnRole { get; set; } = true;
    }
}
