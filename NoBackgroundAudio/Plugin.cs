using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace NoBackgroundAudio
{
    public class Plugin : Plugin<Config>
    {

        private EventHandler EventHandler;
        public static Plugin Singleton;

        public override string Name { get; } = "NoBackgroundAudio";
        public override string Author { get; } = "Denty";
        public override string Prefix { get; } = "NoBackgroundAudio";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);


        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            Player.Verified += EventHandler.OnVerified;
            Player.ChangingRole += EventHandler.OnChangeRole;

            base.OnEnabled();
        }


        public override void OnDisabled()
        {
            Player.Verified -= EventHandler.OnVerified;
            Player.ChangingRole -= EventHandler.OnChangeRole;

            EventHandler = null;
            base.OnDisabled();
        }
    }
}