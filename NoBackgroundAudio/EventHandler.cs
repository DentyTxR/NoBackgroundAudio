using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace NoBackgroundAudio
{
    public class EventHandler
    {
        public void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player != null && Plugin.Singleton.Config.RemoveBackgroundSfxOnJoin)
                Server.ExecuteCommand($"/pfx mutesoundtrack {Plugin.Singleton.Config.EffectIntensity} 0 {ev.Player.Id}", Server.Host.Sender);
        }

        public void OnChangeRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player != null && Plugin.Singleton.Config.RemoveBackgroundSfxOnRole)
                Server.ExecuteCommand($"/pfx mutesoundtrack {Plugin.Singleton.Config.EffectIntensity} 0 {ev.Player.Id}", Server.Host.Sender);
        }
    }
}
