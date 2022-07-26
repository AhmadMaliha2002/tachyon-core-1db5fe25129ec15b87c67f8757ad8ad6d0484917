using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TACHYON.MultiTenancy.HostDashboard.Dto;

namespace TACHYON.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}