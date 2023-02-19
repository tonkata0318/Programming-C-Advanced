using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class Date_Modifier
    {
        public int DiffInDays(string startDate,string endDate)
        {
            DateTime firstDate= DateTime.Parse(startDate);
            DateTime secondDate= DateTime.Parse(endDate);
            TimeSpan diff=firstDate.Subtract(secondDate);
            return Math.Abs(diff.Days);
        }
    }
}
