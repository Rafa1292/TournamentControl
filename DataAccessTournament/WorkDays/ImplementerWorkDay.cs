using BL.WorkDays;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.WorkDays
{
    public class ImplementerWorkDay : IWorkDay
    {
        public int Insert(WorkDayVM workDayVM)
        {
            var workDay = Mapper.MapFromVM(workDayVM);

            return Repository.Insert(workDay);
        }

        public List<WorkDayVM> GetWorkDays(int tournamentId)
        {
            var workDays = Repository.GetWorkDays(tournamentId);
            var workDaysVM = Mapper.MapToVM(workDays);

            return workDaysVM;
        }
    }
}
