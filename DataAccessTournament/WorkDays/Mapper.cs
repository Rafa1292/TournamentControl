using Comm.ViewModels;
using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.WorkDays
{
    public class Mapper
    {
        public static WorkDay MapFromVM(WorkDayVM workDayVM)
        {
            WorkDay workDay = new WorkDay()
            {
                Number = workDayVM.Number,
                State = workDayVM.State,
                TournamentId = workDayVM.TournamentId,
                WorkDayId = workDayVM.WorkDayId
            };

            return workDay;
        }

        public static WorkDayVM MapToVM(WorkDay workDay)
        {
            WorkDayVM workDayVM = new WorkDayVM()
            {
                Number = workDay.Number,
                State = workDay.State,
                TournamentId = workDay.TournamentId,
                WorkDayId = workDay.WorkDayId
            };

            return workDayVM;
        }

        public static List<WorkDayVM> MapToVM(List<WorkDay> workDays)
        {
            var workDaysVM = new List<WorkDayVM>();

            workDays.ForEach(x => workDaysVM.Add(MapToVM(x)));

            return workDaysVM;
        }
    }
}
