using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22._05
{
    public class ForNum2<T> where T : Transaction
    {
        public List<T> list = new List<T>();
        public double Method(List<T> t, Dates start_day, Dates end_day)
        {
            List<T> list_for_ans = list.Where(l => (l.Date <= end_day) && (l.Date >= start_day)).ToList();
            return list_for_ans.Select(l => l.Amount).Sum() / list_for_ans.Count;
        }
        public List<T> Lis(List<T> t, Dates start_day, Dates end_day)
        {
            return list.Where(l => (l.Date <= end_day) && (l.Date >= start_day)).ToList();
        }
    }
}
