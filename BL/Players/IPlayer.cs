using System;
using System.Collections.Generic;
using System.Text;
using Comm.ViewModels;

namespace BL.Players
{
    public interface IPlayer
    {
        public bool Insert(PlayerVM playerVM);

        public List<PlayerVM> GetAll();

        public PlayerVM Get(int playerId);

        public bool Update(PlayerVM playerVM);


    }
}
