using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskMonitor.Entity
{
    public class MarginEntity
    {
        public DateTime? sampleDate { get; set; }        
        //public string sampleDate { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public double NetIncome { get; set; }
        public double MarginPercent { get; set; }
    }
}