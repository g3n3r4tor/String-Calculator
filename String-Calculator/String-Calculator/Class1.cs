using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if(numbers == "")
                return 0;
            string[] a = numbers.Split(',');
            int[] b = new int[a.Length];
            
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Convert.ToInt32(a[i]);
            }
            if (b.Length == 1)
                return b[0];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += b[i];
            }
            return sum;
        }

    }
}
