﻿using System;
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
            if (numbers == "")
                return 0;
            List<String> delimiterList = new List<String>();
            delimiterList.Add(",");
            delimiterList.Add("\n");
            if(numbers.Length >=2 && numbers.Substring(0,2) == "//")
            {
                int index = numbers.IndexOf("\n")-2;
                delimiterList.Add(numbers.Substring(2,index));
                delimiterList.Remove("\n");
                numbers = numbers.Substring(numbers.IndexOf("\n"));
            }
            string[] delimiters = delimiterList.ToArray();
            string[] a = numbers.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
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
