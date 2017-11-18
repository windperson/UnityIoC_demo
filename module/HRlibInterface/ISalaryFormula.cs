using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRlib
{
    /// <summary>
    /// 計算薪資的公式的介面
    /// </summary>
    public interface ISalaryFormula
    {
        /// <summary>
        /// 實際計算薪資的方法
        /// </summary>
        /// <param name="workHours"></param>
        /// <param name="hour"></param>
        /// <param name="privateDayOff"></param>
        /// <returns></returns>
        float Execute(float workHours, float hour, int privateDayOff);
    }
}
