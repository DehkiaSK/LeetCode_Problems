namespace MyAnswer;
public class Answer
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        int low = 0;
        int high = (rows * columns) - 1;

        while(low <= high)
        {
            int mid = low + ((high - low) / 2);

            int rowIndex = mid / columns;
            //Represents the row index of the element in the matrix
            //where the mid index points

            int columnIndex = mid % columns;
            //Represents the column index of the same element within
            //that row

            if(matrix[rowIndex][columnIndex] == target)
            {
                return true;
            }
            else if(matrix[rowIndex][columnIndex] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
}
