using BL.Matches;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Matches
{
    public class ImplementerMatch : IMatch
    {
        public bool Insert(MatchVM matchVM)
        {
            var match = Mapper.MapFromVM(matchVM);
            return Repository.Insert(match);
        }

        public List<MatchVM> GetMatchesByWorkDay(int workDayId)
        {
            var matches = Repository.GetMatchesByWorkDay(workDayId);
            var matcesVM = Mapper.MapToVM(matches);

            return matcesVM;
        }

        public bool Update(MatchVM matchVM)
        {
            var match = Mapper.MapFromVM(matchVM);
            return Repository.Update(match);
        }
    }
}
