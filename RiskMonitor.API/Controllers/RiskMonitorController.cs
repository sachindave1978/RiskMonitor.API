using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using RiskMonitor.Entity;
using System.Web.Http.Description;
using RiskMonitor.MockData;

namespace RiskMonitor.Controllers
{
    public class RiskMonitorController : ApiController
    {
        [HttpGet]
        [Route("api/get-risk-monitor")]
        [ResponseType(typeof(RiskMonitorEntity))]
        public IHttpActionResult GetRiskMonitorHeader()
        {
            RiskMonitorEntity riskMonitorEntity = new RiskMonitorEntity();
            riskMonitorEntity.TotalMargin = 1231462.57;
            riskMonitorEntity.TotalMarginPercent = +12.5;

            riskMonitorEntity.TotalRisk = 1456432.34;
            riskMonitorEntity.TotalMarginPercent = -25.65;

            riskMonitorEntity.TotalExposure = 3865345.76;
            riskMonitorEntity.TotalExposurePercent = +14.67;

            riskMonitorEntity.TotalPortfolio = 2783938.67;
            riskMonitorEntity.TotalPortfolioPercent = +8.45;

            return Ok(riskMonitorEntity);
        }

        [HttpGet]
        [Route("api/get-risk-monitor-margin")]
        [ResponseType(typeof(RiskMonitorEntity))]
        public IHttpActionResult GetRiskMonitorMarginData([FromUri] DateTime startDate, [FromUri] DateTime endDate )
        {
            Console.WriteLine(startDate);  Console.WriteLine(endDate);

            RiskMonitorEntity riskMonitorEntity = new RiskMonitorEntity();            
            riskMonitorEntity.objMarginData = Mock.initializeMarginData().Where(s=>s.sampleDate<=startDate && s.sampleDate>=endDate);
            
            double NetIncome = 0.00;
            double TotalRevenue = 0.00;
            for (int i=0; i< riskMonitorEntity.objMarginData.Count(); i++) {
                NetIncome += riskMonitorEntity.objMarginData.ElementAt(i).NetIncome;
                TotalRevenue += riskMonitorEntity.objMarginData.ElementAt(i).TotalRevenue;
            }
            //Note: Values calculated are mock
            riskMonitorEntity.TotalMargin = (NetIncome / TotalRevenue)*10000000;
            riskMonitorEntity.TotalMarginPercent = ((NetIncome / TotalRevenue)*1000)*0.01;

            riskMonitorEntity.TotalRisk = 1456432.34;
            riskMonitorEntity.TotalRiskPercent = -25.65;
            riskMonitorEntity.TotalExposure = 3865345.76;
            riskMonitorEntity.TotalExposurePercent = +14.67;
            riskMonitorEntity.TotalPortfolio = 2783938.67;
            riskMonitorEntity.TotalPortfolioPercent = +8.45;

            return Ok(riskMonitorEntity);
        }

        [HttpGet]
        [Route("api/get-risk-monitor-risk")]
        [ResponseType(typeof(RiskMonitorEntity))]
        public IHttpActionResult GetRiskMonitorRiskData([FromUri] DateTime startDate, [FromUri] DateTime endDate)
        {
            Console.WriteLine(startDate); Console.WriteLine(endDate);

            RiskMonitorEntity riskMonitorEntity = new RiskMonitorEntity();
            riskMonitorEntity.objRiskData = Mock.initializeRiskData().Where(s => s.sampleDate <= startDate && s.sampleDate >= endDate);

            double TotalRisk1 = 0.00;
            double TotalRisk2 = 0.00;
            for (int i = 0; i < riskMonitorEntity.objRiskData.Count(); i++)
            {
                TotalRisk1 += riskMonitorEntity.objRiskData.ElementAt(i).TotalRisk1;
                TotalRisk2 += riskMonitorEntity.objRiskData.ElementAt(i).TotalRisk2;
            }
            //Note: Values calculated are mock
            riskMonitorEntity.TotalMargin = 00.00;
            riskMonitorEntity.TotalMarginPercent = 00.00;
            riskMonitorEntity.TotalRisk = (TotalRisk1 / TotalRisk2) * 10000000; 
            riskMonitorEntity.TotalRiskPercent = ((TotalRisk1 / TotalRisk2) * 1000) * 0.01;
            riskMonitorEntity.TotalExposure = 00.00;
            riskMonitorEntity.TotalExposurePercent = 00.00;
            riskMonitorEntity.TotalPortfolio = 00.00;
            riskMonitorEntity.TotalPortfolioPercent = 00.00;

            return Ok(riskMonitorEntity);
        }

    }
}
