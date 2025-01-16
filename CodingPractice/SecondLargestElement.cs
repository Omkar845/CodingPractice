using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class SecondLargestElement
    {

        public int SecondLargest(int[] arr)
        {

            int secondlargest = 0;


            int laregstElement = 0;

            for (int i = 0; i <= arr.Length - 1; i++) 
            {
                if (arr[i] > laregstElement)
                {
                    secondlargest = laregstElement;
                    laregstElement = arr[i];
                }
                if (arr[i] > secondlargest && arr[i]!= laregstElement)
                {
                    secondlargest = arr[i];
                }

            }
         

            return secondlargest;

        }



    }
}
