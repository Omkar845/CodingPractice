using CodingPractice;

public class Program
{
    
    public static void Main(string[] args)
    {
        #region Insertion of array
        // InsertAtAnyPosition IP = new InsertAtAnyPosition();

        // int[] arr = { 1, 2, 4, 6, 8, 0 };

        // int[] newarr = IP.InsertElementAtAnyPosition(arr,12,2);

        //foreach(int ar in arr) 
        // {
        //     Console.Write("" + arr);
        // }
        #endregion



        #region Second Largest Element

        SecondLargestElement  sc = new SecondLargestElement();

        int[] arr = { 1, 2, 32, 4, 26, 17, 8 };

        int Element = sc.SecondLargest(arr);

        Console.WriteLine(Element);

        #endregion



    }
}