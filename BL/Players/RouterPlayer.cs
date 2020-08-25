using BL.Players;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Players
{
    public class RouterPlayer
    {
        private readonly IPlayer _player;

        public RouterPlayer(IPlayer player)
        {
            _player = player;
        }

        public bool Insert(PlayerVM player)
        {
            return _player.Insert(player);
        }

        public List<PlayerVM> GetAll()
        {
            return _player.GetAll();
        }

        public PlayerVM Get(int playerId)
        {
            return _player.Get(playerId);
        } 

        public bool Update(PlayerVM player)
        {
            return _player.Update(player);
        }
    }
}
