using System.Runtime.Serialization.Formatters;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VlasenkoAE.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for ( i = startValue; i <= stopValue; i++ )
            {
                sumSeries = sumSeries + ((Math.Pow(value, i) + 0.25) * Math.Sin(i));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
