using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooERP.Services
{
    public class ReportService
    {
        public void PrintFoodReport(ZooService zoo)
        {
            Console.WriteLine($"Всего нужно еды: {zoo.GetTotalFood()} кг/день.");
        }
    }
}
