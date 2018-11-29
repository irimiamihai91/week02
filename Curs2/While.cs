using System;

namespace Curs2
{
    public class WhileExample
    {
        public static void Main(string [] args )
            
        {
            int number1 = Convert.ToInt32(Console.ReadLine());

            while(number1>0){

                Console.WriteLine(number1 + "     ");
                number1--;
            }
           
    }
}

}
