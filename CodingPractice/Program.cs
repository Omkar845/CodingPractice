using CodingPractice;

public class Program
{
    
    public static void Main(string[] args)
    {
        InsertAtAnyPosition IP = new InsertAtAnyPosition();

        int[] arr = { 1, 2, 4, 6, 8, 0 };

        int[] newarr = IP.InsertElementAtAnyPosition(arr,12,2);

       foreach(int ar in arr) 
        {
            Console.Write("" + arr);
        }


    }
}