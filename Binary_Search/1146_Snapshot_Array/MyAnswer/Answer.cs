namespace MyAnswer;
public class Answer
{
    private int[] _currentArray;
    private List<int[]> _snapshotList;
    private int _snap_id;

    public Answer(int length)
    {
        _currentArray = new int[length];
        _snapshotList = [];
        _snap_id = 0;

        Array.Fill(_currentArray, 0);
    }

    public void PrintCurrentArray()
    {
        foreach(int i in _currentArray)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
    }
    public void PrintSnapshotList()
    {
        int i = 0;

        foreach(int[] array in _snapshotList)
        {
            Console.WriteLine($"Array {i}: " + string.Join(", ", array));

            i++;
        }

        Console.WriteLine();
    }
    public void PrintSnapID()
    {
        Console.Write(_snap_id);

        Console.WriteLine();
    }
    public void Set(int index, int val)
    {
        _currentArray[index] = val;
    }
    public int Snap()
    {
        int[] clonedArray = (int[])_currentArray.Clone();

        _snapshotList.Insert(_snap_id, clonedArray);

        return _snap_id++;
    }
    public int Get(int index, int snap_id)
    {
        if(_snapshotList != null && snap_id >= 0 && _snapshotList[snap_id] != null)
        {
            var value = _snapshotList[snap_id].GetValue(index);

            if(value != null)
            {
                return (int)value;
            }
            else
            {
                Console.WriteLine("Value is null");

                return -1;
            }
        }
        else
        {
            Console.WriteLine("Snapshot List is empty, Snap ID does not exist, or " +
            "the Snapshot Array does not exist.");

            return -1;
        }
    }
}
