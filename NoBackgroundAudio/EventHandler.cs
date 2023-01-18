using CommandSystem;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBackgroundAudio
{
    public class EventHandler
    {
        public void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player != null)
                Server.RunCommand($"/pfx mutesoundtrack {Plugin.NoBackgroundAudio.Singleton.Config.EffectIntensity} 0 {ev.Player.Id}", Server.Host.Sender);
            GameConsoleCommandHandler.Create();
        }

        public void OnChangeRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player != null)
                Server.RunCommand($"/pfx mutesoundtrack {Plugin.NoBackgroundAudio.Singleton.Config.EffectIntensity} 0 {ev.Player.Id}", Server.Host.Sender);
        }
    }
}
