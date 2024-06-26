using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    internal class MC1
    {
        public int Soln(int[] A)
        {

            int i = 0;
            int l = 0;
            int r = 0;
            int result = 0;
            while (i < A.Length - 1)
            {

                l = i - 1;
                r = i + 1;

                int sum = A[i];
                if (l >= 0) sum += A[l];
                if (r < A.Length - 1) sum += A[r];


                if (sum < 0)
                {
                    sum = Math.Abs(sum);
                    if (l < 0)
                    {
                        A[r] += sum;

                    }
                    else if (r > A.Length - 1)
                    {
                        A[l] += sum;
                    }
                    else if (A[l] < 0 && A[r] < 0)
                    {
                        A[i] += sum;
                    }

                    
                    result += Math.Abs(sum);

                }


                i++;
            }
            return result;
        }
    }
}
