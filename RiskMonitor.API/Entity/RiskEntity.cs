using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskMonitor.Entity
{
    public class RiskEntity
    {
        public DateTime? sampleDate { get; set; }
        public double TotalRisk1 { get; set; }
        public double TotalRisk2 { get; set; }
        public double Risk { get; set; }
    }
}