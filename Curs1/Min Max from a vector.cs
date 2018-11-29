using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string [] args ){

            int [] vector;
            vector = new int[5];
            vector[0] =8;
            vector[1] =7;
            vector[2] =22;
            vector[3] =3;
            vector[4] =5;

            int Min = vector[0];
            int Max = vector[0];

            for (int i = 0; i<vector.Length ; i ++){

                if(Min > vector[i])
                Min = vector[i];

                else if (Max < vector[i])
                Max = vector[i];
            }
            Console.WriteLine("Min" + "" + Min );
            Console.WriteLine("Max" + "" + Max );
            
                        }


        }
    }
