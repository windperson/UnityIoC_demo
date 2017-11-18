using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;
using Unity;
using HRlib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                section.Configure(container, "containerEmployee");
                var SC = container.Resolve<SalaryCalculator>();
                //工時 , 時薪,  請假天數
                float amount = SC.Calculate(8 * 19, 200, 8);
                Console.WriteLine("normal amount:" + amount);
            }

            using (var container = new UnityContainer())
            {
                var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                section.Configure(container, "containerHack");
                var SC = container.Resolve<SalaryCalculator>();
                //工時 , 時薪,  請假天數
                float amount = SC.Calculate(8 * 19, 200, 30);
                Console.WriteLine("hack amount:" + amount);
            }
            Console.WriteLine("press any key to end.");
            Console.ReadKey();
        }
    }
}
