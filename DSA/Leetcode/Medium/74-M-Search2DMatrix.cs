namespace DSA.Leetcode.Medium
{
    public class Search2DMatrix
    {

        // Decent performance
        public bool Soln(int[][] matrix, int target)
        {

            int l = 0;
            int r = matrix.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                var mid = matrix[m];

                if (target >= mid[0] && target <= mid[mid.Length - 1])
                {
                    l = 0;
                    r = mid.Length - 1;

                    while (l <= r)
                    {
                        var middle = l + (r - l) / 2;
                        if (mid[middle] == target) return true;
                        else if (target > mid[middle]) l = middle + 1;
                        else if (target < mid[middle]) r = middle - 1;
                    }
                }
                else if (target < mid[0]) r = m - 1;
                else if (target > mid[mid.Length - 1]) l = m + 1;
            }
            return false;
        }
    }
}

//var cl = new Search2DMatrix();

//var a = cl.Soln([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);
//var b = cl.Soln([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13);
//var c = cl.Soln([[1]], 2);
//var f = 'a';