using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main (string []args)
        {
        var numberToGuess = new Random().Next(1,10);

    
        
        while(true){
        
        Console.WriteLine("Introduceti un numar");
        
        var x  =Convert.ToInt32(Console.ReadLine());

        if(x==numberToGuess)
        {
            Console.WriteLine("Felicitari!Ati ghicit numarul!");
            ok = true;
        }
        else 
        {
            if(x<numberToGuess )
            {
                Console.WriteLine("Numarul introdus este prea mic!");
                break;
            }
           // else
            //{
            //Console.WriteLine("Numarul introdus este prea mare!");
            //}

        }

        }
    Console.ReadLine();
         }
         

        }

        }

    

