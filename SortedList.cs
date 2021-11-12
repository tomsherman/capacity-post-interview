using System;
using System.Collections.Generic;

namespace CapacityPostInterview
{
    class SortedList : List<Double>
    {
        public List<Double> pluckNumbersLessThanOrEqualTo(Double n)
        {
            var list = new List<Double>();

            while (this.Count > 0 && this[0] <= n)
            {
                list.Add(this[0]);
                this.RemoveAt(0);
            }

            return list;
        }
    }
}
