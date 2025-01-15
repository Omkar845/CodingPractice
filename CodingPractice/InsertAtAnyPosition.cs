using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class InsertAtAnyPosition
    {


        public int[] InsertElementAtAnyPosition(int[] arr, int x, int pos) 
        {
            // {1, 2, 4, 6, 8, 0 }
            int[] newarr = new int[arr.Length + 1];

            for(int i = 0;i< newarr.Length - 1; i++)
            {
                if(i < pos)
                {
                    newarr[i] = arr[i];
                }
                else if(i == pos)
                {
                    newarr[i] = x;
                }
                else
                {
                    newarr[i] = arr[i - 1];
                }

            }
            return newarr;       
        }

    }
}
