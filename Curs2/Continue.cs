using System;

namespace Curs2
{
    public class DoWhileExample
    {
        public static void Main(string [] args )
            
        {
          
            int i = 100;

            while(i>0){

                i--;
                 if(i%7 ==0){
                throw new Exception("It's over") ;
                }
                Console.WriteLine(i+1);
                
            }
            Console.WriteLine("Done!");
            
           }
}
}


