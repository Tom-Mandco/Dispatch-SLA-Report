namespace MandCo.Applications.ws1160.Classes
{
    using Interfaces;
    using System;

    class App : IApp
    {
        private readonly ILog logger;
        private readonly IDataHandler dataHandler;

        public App(ILog logger, IDataHandler dataHandler)
        {
            this.logger = logger;
            this.dataHandler = dataHandler;
        }

        public void BindSLADataTableToDGVDataSource(MainForm mainForm)
        {
            mainForm.dgvDetailBreakdown.DataSource = dataHandler.BindSLAData_ToDataTable(DateTime.Now.AddHours(-24), DateTime.Now);
        }
    }
}
