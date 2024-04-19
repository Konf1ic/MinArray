public class MinValue
{
    public static int MinInArray(int[] array)
    {
        int min = array[0];
        int index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        return index;
    }

    public static void Main(String[] args)
    {
        int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
        int index = MinInArray(arr);
        Console.WriteLine("Vị trí của phần tử nhỏ nhất trong mảng là: " + index);
    }
}
