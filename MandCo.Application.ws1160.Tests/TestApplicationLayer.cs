namespace MandCo.Applications.ws1160.Tests
{
    using MandCo.Data.ws1160.Models;
    using MandCo.Applications.ws1160.Interfaces;
    using MandCo.Service.ws1160.Interfaces;
    using System;
    using Xunit;
    using System.Collections;
    using System.Collections.Generic;

    public class TestApplicationLayer
    {
        IPerformLookup performLookup;
        IHandleCalculations calculationHandler;

        public TestApplicationLayer(IPerformLookup performLookup, IHandleCalculations calculationHandler)
        {
            this.performLookup = performLookup;
            this.calculationHandler = calculationHandler;
        }
        [Fact]
        public void PerformCalculation_WithPerfectData_Pass()
        {
            //Arrange
            DisplayData expected = new DisplayData
            {

            };
            DateTime dtFrom = new DateTime(2016,07,22,11,00,00);
            DateTime dtTo = new DateTime(2016,07,23,11,00,00);

            IEnumerable<Raw_SLA_Report_Details> rawReportDetails = performLookup.GetOrderDataFromSLATable(dtFrom, dtTo);
            Config_Information configInfo = performLookup.GetConfigurationInformation();

            //Act
            DisplayData actual = calculationHandler.CalculateSLADeadlines_ToDisplayData(rawReportDetails, configInfo);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
