using System;

namespace Curs2
{
    public class BreakExample
    {
        public static void Main(string [] args ){

            for (int i = 0; i<50;i++){

                if(i==10){
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();


        }

    }
}