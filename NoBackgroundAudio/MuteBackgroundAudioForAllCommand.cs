using CommandSystem;
using System;
using Exiled.Permissions.Extensions;
using Exiled.API.Features;

namespace NoBackgroundAudio
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class MuteBackgroundAudioForAllCommand : ICommand
    {
        public string Command { get; } = "muteall";
        public string[] Aliases { get; } = { string.Empty };
        public string Description { get; } = "Mutes background audio for all players";
        public bool SanitizeResponse => false;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("nba.muteall"))
            {
                response = "No permission";
                return true;
            }

            Player ply = Player.Get(sender);
            int totalPlayers = 0;

            foreach (Player player in Player.List)
            {
                Server.ExecuteCommand($"/pfx mutesoundtrack {Plugin.Singleton.Config.EffectIntensity} 0 {player.Id}", ply.Sender);
                totalPlayers++;
            }

            response = $"Muted {totalPlayers} players background audio";
            return true;
        }
    }
}