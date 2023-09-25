using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChazovaSR.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            var res =Math.Round(Math.Cos(x/y) / (3*(Math.Exp(x+y))),3);
            return res;
        }
    }
}
