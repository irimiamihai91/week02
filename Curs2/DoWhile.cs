using System;

namespace Curs2
{
    public class DoWhileExample
    {
        public static void Main(string [] args )
            
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            do {

                Console.WriteLine(number1 + "     ");
                number1--;

            }

            while(number1>0);
           
    }
}

}
