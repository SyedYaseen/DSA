namespace DSA.Leetcode;

public class TrapWaterBFSComplicated
{
}
//     private bool[][] matrix ;
//     private int maxVal = 0;
//     Queue<Pair> q = new Queue<Pair>();
//     private HashSet<String> visited = new HashSet<String>();
//     private int _result = 0;
//
//
//     public int TrapWaters(int[] height)
//     {
//         // Create matrix
//         for (int i = 0; i < height.Length; i++)
//         {
//             if (maxVal < height[i])
//                 maxVal = height[i];
//         }
//         matrix = new bool[height.Length][];
//         for (int i = 0; i < height.Length; i++)
//         {
//             matrix[i] = new Boolean[maxVal];
//             for (int j = 0; j < height[i]; j++)
//             {
//                 matrix[i][j] = true; 
//             }
//         }
//         
//         // Bfs
//         // Traverse through items
//         for (int row = 0; row < height.Length; row++)
//         {
//             for (int col = 0; col < maxVal; col++)
//             {
//                 Pair current = new Pair(row, col);
//                 if (matrix[row][col] == false && !visited.Contains(row+","+col))
//                 {
//                     q.Enqueue(current);
//                     _result += getWater();
//                 }
//             }
//         }
//         
//         return _result;
//     }
//
//     private int getWater()
//     {
//         int smallCount = 0;
//
//         while (q.Count > 0)
//         {
//             Pair current = q.Dequeue();
//             smallCount += 1;
//             
//             
//             int r = current.Row;
//             int c = current.Col;
//             visited.Add(r+","+c);
//             
//             Pair top = new Pair(r - 1, c);
//             Pair bottom = new Pair(r + 1, c);
//             Pair left = new Pair(r, c - 1);
//             Pair right = new Pair(r, c + 1);
//             
//             if (inBounds(left))
//                 q.Enqueue(left);
//             
//             if (inBounds(right))
//                 q.Enqueue(right);
//
//             if (inBounds(top))
//                 q.Enqueue(top);
//             
//             if (inBounds(bottom))
//                 q.Enqueue(bottom);
//         }
//
//         return smallCount;
//     }
//
//     private bool inBounds(Pairbfs node)
//     {
//         if (node.Row < 0 || node.Row >= matrix.Length || node.Col < 0  || node.Col >= maxVal || matrix[node.Row][node.Col] )
//             return false;
//         bool containsNode = visited.Contains(node.Row+","+node.Col);
//         return !containsNode;
//     }
// }
//
// public class Pairbfs
// {
//     public int Row, Col;
//     public Pairbfs(int row, int col)
//     {
//         this.Col = col;
//         this.Row = row;
//     }
// }