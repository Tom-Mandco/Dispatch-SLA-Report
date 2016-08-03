namespace MandCo.Data.ws1160.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface IRepository
    {
        IEnumerable<SLA_Report_Details> GetAllOrderDetailsForSpecifiedTimes(DateTime dateFrom, DateTime dateTo);
    }
}
