using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFromArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[5] {11,17,15,13,9};
			Console.WriteLine("Enter number to remove from array {11,17,15,13,9}:");

			int x = Convert.ToInt32(Console.ReadLine());

			int[] aux = new int[numbers.Length - 1];
			int index = 0;          //index for aux array
			bool found = false;		//to check if element to be removed is found

			for (int i = 0; i <= numbers.Length - 1; i++)
			{
				if (numbers[i] == x)
				{
					found = true;
					continue;
				}
				else if (index >= aux.Length)
				{
					break;
				}
				else
				{
					aux[index] = numbers[i];
					index++;
				}
			}

			if (found)
			{
				WriteArray(aux);
			}
			else
			{
				Console.WriteLine("Element to be removed not found");
			}

			Console.ReadLine();
		}

		public static void WriteArray(int[] arr)
		{
			for (int i = 0; i <= arr.Length - 1; i++)
			{
				if (i == arr.Length - 1)
				{
					Console.Write(arr[i]);
				}
				else
				{
					Console.Write(arr[i] + ",");
				}
			}
		}
	}
}
