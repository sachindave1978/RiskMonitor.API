using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RiskMonitor.Entity;

namespace RiskMonitor.MockData
{
    public static class Mock
    {
        public static IQueryable<MarginEntity> initializeMarginData()
        {
            List<MarginEntity> objLstMarginEntity = new List<MarginEntity>();
            MarginEntity item = new MarginEntity();
            item.sampleDate = DateTime.Now;
            item.TotalRevenue = 211125.2;
            item.TotalExpenses = 2120.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            DateTime temp = DateTime.Now;
            item.sampleDate = temp.AddDays(-1);
            item.TotalRevenue = 221128.2;
            item.TotalExpenses = 2218.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-4);
            item.TotalRevenue = 231148.2;
            item.TotalExpenses = 2302.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-7);
            item.TotalRevenue = 241149.2;
            item.TotalExpenses = 2100.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-10);
            item.TotalRevenue = 251168.2;
            item.TotalExpenses = 2100.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-13);
            item.TotalRevenue = 241155.2;
            item.TotalExpenses = 2102.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-16);
            item.TotalRevenue = 251170.2;
            item.TotalExpenses = 2198.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-19);
            item.TotalRevenue = 261170.2;
            item.TotalExpenses = 2098.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-22);
            item.TotalRevenue = 271123.2;
            item.TotalExpenses = 2102.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-25);
            item.TotalRevenue = 261111.2;
            item.TotalExpenses = 2092.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-28);
            item.TotalRevenue = 271198.2;
            item.TotalExpenses = 1976.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-31);
            item.TotalRevenue = 271190.2;
            item.TotalExpenses = 1768.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-34);
            item.TotalRevenue = 281190.2;
            item.TotalExpenses = 1768.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-37);
            item.TotalRevenue = 271190.2;
            item.TotalExpenses = 1868.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-40);
            item.TotalRevenue = 281190.2;
            item.TotalExpenses = 1568.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-43);
            item.TotalRevenue = 291120.2;
            item.TotalExpenses = 1472.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-46);
            item.TotalRevenue = 3021128.2;
            item.TotalExpenses = 1674.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            item = new MarginEntity();
            item.sampleDate = temp.AddDays(-49);
            item.TotalRevenue = 321140.2;
            item.TotalExpenses = 1575.1;
            item.NetIncome = item.TotalRevenue - item.TotalExpenses;
            objLstMarginEntity.Add(item);

            return objLstMarginEntity.AsQueryable();
        }

        public static IQueryable<RiskEntity> initializeRiskData()
        {
            List<RiskEntity> objLstRiskEntity = new List<RiskEntity>();
            RiskEntity item = new RiskEntity();
            item.sampleDate = DateTime.Now;
            item.TotalRisk1 = 211125.2;
            item.TotalRisk2 = 2120.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            DateTime temp = DateTime.Now;
            item.sampleDate = temp.AddDays(-1);
            item.TotalRisk1 = 221128.2;
            item.TotalRisk2 = 2218.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-4);
            item.TotalRisk1 = 231148.2;
            item.TotalRisk2 = 2302.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-7);
            item.TotalRisk1 = 241149.2;
            item.TotalRisk2 = 2100.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-10);
            item.TotalRisk1 = 251168.2;
            item.TotalRisk2 = 2100.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-13);
            item.TotalRisk1 = 241155.2;
            item.TotalRisk2 = 2102.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-16);
            item.TotalRisk1 = 251170.2;
            item.TotalRisk2 = 2198.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-19);
            item.TotalRisk1 = 261170.2;
            item.TotalRisk2 = 2098.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-22);
            item.TotalRisk1 = 271123.2;
            item.TotalRisk2 = 2102.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-25);
            item.TotalRisk1 = 261111.2;
            item.TotalRisk2 = 2092.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-28);
            item.TotalRisk1 = 271198.2;
            item.TotalRisk2 = 1976.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-31);
            item.TotalRisk1 = 271190.2;
            item.TotalRisk2 = 1768.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-34);
            item.TotalRisk1 = 281190.2;
            item.TotalRisk2 = 1768.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-37);
            item.TotalRisk1 = 271190.2;
            item.TotalRisk2 = 1868.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-40);
            item.TotalRisk1 = 281190.2;
            item.TotalRisk2 = 1568.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-46);
            item.TotalRisk1 = 3021128.2;
            item.TotalRisk2 = 1674.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            item = new RiskEntity();
            item.sampleDate = temp.AddDays(-49);
            item.TotalRisk1 = 321140.2;
            item.TotalRisk2 = 1575.1;
            item.Risk = item.TotalRisk1 - item.TotalRisk2;
            objLstRiskEntity.Add(item);

            return objLstRiskEntity.AsQueryable();
        }
    }
}