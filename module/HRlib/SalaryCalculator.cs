using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRlib
{
    /// <summary>
    /// 計算薪資的類別
    /// </summary>
    public class SalaryCalculator
    {
        /// <summary>
        /// 計算薪資的公式物件
        /// </summary>
        private readonly ISalaryFormula _salaryFormula;
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="salaryFormula"></param>
        public SalaryCalculator(ISalaryFormula salaryFormula)
        {
            _salaryFormula = salaryFormula;
        }
        /// <summary>
        /// 計算薪資
        /// </summary>
        /// <param name="WorkHours">工時</param>
        /// <param name="Hourly">時薪</param>
        /// <param name="PrivateDayOff">請假天數</param>
        /// <returns></returns>
        public float Calculate(float WorkHours, int Hourly, int PrivateDayOffHours)
        {
            return _salaryFormula.Execute(WorkHours, Hourly, PrivateDayOffHours);
        }
    }

    public class SalaryFormula : ISalaryFormula
    {
        public float Execute(float workHours, float hour, int privateDayOff)
        {
            //薪資=工時*時薪-(事假時數*時薪)
            return workHours * hour - (privateDayOff * hour);
        }
    }    
}
