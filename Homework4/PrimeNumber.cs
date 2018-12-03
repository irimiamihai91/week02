using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static int a, b; // a number given by user; b number of times a could be didided by i
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++) // i starts from 1 and goes until equal with a
            {
                if (a % i == 0) //if a can be divided by i than increase b
                {
                    b++;
                }
            }
            if(0<b && b < 3) // prime (didived by 1 and itself).If b is greater than 0 and less than 3 or(b==1 and b==2) is prime 
            {
                Console.WriteLine(a + " is a prime number");
            }
            else
            {
                Console.WriteLine(a + " is not a prime number");

            }

           // Console.WriteLine(isPrime(2));
            Console.ReadKey();



            
        }
       // public static bool isPrime(int n)
       //{
       //  if (n == 2)
       //{
       //  return true;
       //}
       //if (n%2==0)
       //{
       //  return false;
       //}
       //for(int i = 3;i*i <= n; i += 2)
       //{
       //  if(n%i == 0)
       //{
       //  return false;
       //}
       //}
       //return true;
        //}
    }
}
