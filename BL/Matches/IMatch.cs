using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Matches
{
    public interface IMatch
    {
        public bool Insert(MatchVM matchVM);

        public bool Update(MatchVM matchVM);


        public List<MatchVM> GetMatchesByWorkDay(int workDayId);
    }
}
