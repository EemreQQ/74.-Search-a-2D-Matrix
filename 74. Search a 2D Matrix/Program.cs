public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {       
        var end = (matrix.GetLength(0) * matrix[0].Length); 
        int start, midRow, midColumn, mid;
        start = 0;
        
        while (end >= start)
        {           
            mid = (end + start) / 2; // 6
            midRow = mid / matrix[0].Length ;
            midColumn = mid % matrix[0].Length;
            
            if (matrix.Length == midRow) return false;
            
            if (matrix[midRow][midColumn] == target) { return true; }
            if (matrix[midRow][midColumn] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }            
        }
        return false;
    }
    static void Main()
    {
        Solution solution = new Solution();
        int[][] matrix = 
            {
            new int[]   {1,3,5,7,},
            new int[]   {10,11,16,20},
            new int[]   {23,30,34,60},
        };

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int h = 0; h < matrix[0].Length; h++)
            {
                Console.Write((10 + i + h) + " ");
                Console.Write("{0,5}",solution.SearchMatrix(matrix, (10 + i + h)) + " ");
                Console.Write(matrix[i][h] + " ");
                Console.Write("{0,5}",solution.SearchMatrix(matrix, matrix[i][h]));
                Console.WriteLine();

            }
           
        }
    }
}