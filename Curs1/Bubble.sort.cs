using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string [] args ){

            int [] array;
            array = new int [6] {6,9,1,4,10,3};
            int temp;

            for (int i = 0; i<array.Length ; i++){
                for (int j = 0; j<array.Length; j++){
                    if (array[i]<array[j]){
                        temp = array[i];
                        array[i] = array[j];
                        array[j]=temp;
                    }
                }
            }
        Console.WriteLine("the array is sorted :");

        for (int i = 0;i<array.Length;i++){
            Console.WriteLine(array[i]);
        }
        Console.ReadKey();


        }

    }

}