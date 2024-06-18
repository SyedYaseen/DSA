using DSA.Leetcode.Easy;

namespace DSA.Leetcode.Easy
{
    public class BinaryGap
    {
        public int Soln(int n)
        {

            int result = 0;
            int current = 0;
            bool left = false;

            while (n > 0)
            {  
                var mod = n % 2;
                if (left)
                {
                    current += 1;

                    if (mod == 1)
                    {
                        if (current > result) result = current;

                        current = 0;
                        left = true;
                    }
                }
                else
                {
                    if (mod == 1) left = true;
                    
                }
                n = n / 2;
            }


            return result;

        }


        // Bad time complexity

            public int Soln2(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            int result = 0;
            string binary = string.Empty;

            while (n > 0)
            {
                if (n == 2)
                {
                    binary = "10" + binary;
                    break;
                }
                else if (n == 1) {
                    binary = "1" + binary;
                    break;
                }
                binary = (n % 2).ToString() + binary;
                n = n / 2;
            }

            int i = 0;
            int j = 1;

            while (j < binary.Length)
            {
                if (binary[j] == '0')
                {
                    j++;

                }
                else if (binary[j] == '1')
                {
                    result = j - i > result ? j - i : result;
                    i = j;
                    j++;
                }
            }

            return result;
        }
    }
}

//var cl = new BinaryGap();

//var inputs = new List<int>()
//{
//   1, 22, 8, 5, 6
//};
//// 01101
////1,1,2,0,2

//foreach (var i in inputs)
//{
//    var a = cl.Soln(i);
//}
