﻿namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    public interface IApp
    {
        void BindConfigDataToForm(MainForm mainForm);
        void BindSLADataTableToDGVDataSource(MainForm mainForm, bool useCustomDateTimes);
    }
}