using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Comm.ViewModels;

namespace DataAccessTournament.Players
{
    public class Mapper
    {

        public static Player MapFromVM(PlayerVM playerVM)
        {
            Player player = new Player()
            {
                Alias = playerVM.Alias,
                Name = playerVM.Name,
                PlayerId = playerVM.PlayerId
            };

            return player;
        }

        public static PlayerVM MapToVM(Player player)
        {
            PlayerVM playerVM = new PlayerVM()
            {
                Alias = player.Alias,
                Name = player.Name,
                PlayerId = player.PlayerId
            };

            return playerVM;
        }

        public static List<PlayerVM> MapToVM(List<Player> players)
        {
            var playersVM = new List<PlayerVM>();
            players.ForEach(x => playersVM.Add(MapToVM(x)));

            return playersVM;
        }
    }
}
