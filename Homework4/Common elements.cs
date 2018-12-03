using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] array = new int [] { 1, 2, 3, 4, 5, 6 };
            // int[] newArray = new int[] { 2, 3, 4 };
            // Console.WriteLine("Se afiseaza elementele comune intre { 1, 2, 3, 4, 5, 6 } si { 2, 3, 4} ");
            // var listCommon = array.Intersect(newArray);
            // foreach (int intersect in listCommon)
            // Console.WriteLine(s);
            // Console.ReadKey();

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] newArray = new int[] { 2, 3, 4 };
            Console.WriteLine("Se afiseaza elementele comune intre { 1, 2, 3, 4, 5, 6 } si { 2, 3, 4} ");

            for (int i = 0; i< array.Length; i++)
            {
                for(int j = 0; j < newArray.Length; j++)
                {
                    if(array[i] == newArray[j])
                    {
                        Console.WriteLine("Elementul " + array[i] + " se gaseste la indexul " + i + " in primul array si " + j + " in cel de-al doilea");
                    }
                }
                
            }
            Console.ReadKey();


        }
    }
}
