using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Comm.ViewModels;
using BL.Players;

namespace DataAccessTournament.Players
{
    public class ImplementerPlayer : IPlayer
    {
        public bool Insert(PlayerVM playerVM)
        {
            var player = Mapper.MapFromVM(playerVM);
            return Repository.Insert(player);
        }

        public List<PlayerVM> GetAll()
        {
            var playersVM = Mapper.MapToVM(Repository.GetAll());

            return playersVM;
        }

        public PlayerVM Get(int playerId)
        {
            var player = Mapper.MapToVM(Repository.Get(playerId));

            return player;
        }

        public bool Update(PlayerVM playerVM)
        {
            var player = Mapper.MapFromVM(playerVM);

            return Repository.Update(player);
        }
    }
}
