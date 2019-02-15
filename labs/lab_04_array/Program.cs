using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_array
{
    public class Program
    {
        public int CreateArray(int size)
        {
            int[] myArray = new int[size];

            //insert squares
            for(int i = 0; i < size; i++)
            {
                myArray[i] = i * i;
            }

            //Check value
            int total = 0;
            for(int i = 0; i < size; i++)
            {
                total += i;
                Console.WriteLine(i);

            }
            return total;
        }


    }
}
