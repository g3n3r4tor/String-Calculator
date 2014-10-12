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
            if (numbers == "")
                return 0;
            List<String> delimiterList = new List<String>();
            delimiterList.Add(",");
            delimiterList.Add("\n");
            if(numbers.Length >=2 && numbers.Substring(0,2) == "//")
            {
                if(numbers.Substring(2,1) == "[")
                {
                    int index = numbers.IndexOf("]") - 3;
                    delimiterList.Add(numbers.Substring(3, index));
                    numbers = numbers.Substring(numbers.IndexOf("]") + 1);
                    while(true)
                    {
                        if (numbers.Substring(0, 1) == "[")
                        {
                            index = numbers.IndexOf("]") - 1;
                            delimiterList.Add(numbers.Substring(1, index));
                            numbers = numbers.Substring(numbers.IndexOf("]") + 1);
                        }
                        else
                            break;
                    }
                    
                }
                else
                {
                    int index = numbers.IndexOf("\n") - 2;
                    delimiterList.Add(numbers.Substring(2, index));
                }
                numbers = numbers.Substring(numbers.IndexOf("\n"));
                
            }
            string[] delimiters = delimiterList.ToArray();
            string[] a = numbers.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
            int[] b = new int[a.Length];
            int[] narr = new int[a.Length];
            int negcount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Convert.ToInt32(a[i]);
                if(b[i] < 0)
                {
                    narr[negcount] = b[i];
                    negcount++;
                }
            }
            if (b.Length == 1)
                return b[0];
            if(negcount > 0)
            {
                String s = "Negatives not allowed: ";
                for (int i = 0; i < narr.Length; i++)
                {
                    if (narr[i] != 0)
                    {
                        negcount--;
                        if (negcount == 0)
                            s += narr[i];
                        else
                            s += narr[i] + ",";
                    }
                }
                throw new NotSupportedException(s);
            }
            
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(b[i] < 1001)
                    sum += b[i];
            }
            return sum;
        }

    }
}
