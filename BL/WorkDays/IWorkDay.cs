using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.WorkDays
{
    public interface IWorkDay
    {
        public int Insert(WorkDayVM workDayVM);

        public List<WorkDayVM> GetWorkDays(int tournamentId);
    }
}
