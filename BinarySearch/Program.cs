using System;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputArray = new int[] {1,2,3,4,5,6,7,8,9,10 };
			//var r = new Random();
			//for (int i = 0; i < inputArray.Length; i++)
			//{
			//	inputArray[i] = r.Next(0, 2000);
			//}
			//Array.Sort(inputArray);
			int key = 2;

			int min = 0;
			int max = inputArray.Length - 1;
			int numberOfTry = 0;
			do
			{
				numberOfTry++;
				int mid = (min + max) / 2;
				var number = inputArray[mid];
				if (key == number)
				{
					Console.WriteLine($"Found, under: {numberOfTry} ");
					break;
				}
				else if (key < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			} while (true);
			Console.ReadKey();
		}
	}
}
