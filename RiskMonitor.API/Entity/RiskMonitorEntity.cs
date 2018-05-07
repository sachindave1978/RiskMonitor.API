using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiskMonitor.Entity
{
    public class RiskMonitorEntity
    {
        public double TotalMargin { get; set; }
        public double TotalMarginPercent { get; set; }        
        public double TotalRisk { get; set; }
        public double TotalRiskPercent { get; set; }
        public double TotalExposure { get; set; }
        public double TotalExposurePercent { get; set; }
        public double TotalPortfolio { get; set; }
        public double TotalPortfolioPercent { get; set; }

        public IQueryable<MarginEntity> objMarginData { get; set; }
        public IQueryable<RiskEntity> objRiskData { get; set; }
    }
}