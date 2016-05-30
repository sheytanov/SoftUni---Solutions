using System;

namespace LargestCommonEnd
{
	public class LargestCommonEnd
	{
		public static void Main()
		{
			string[] firstArray = Console.ReadLine().Split();
			string[] secondArray = Console.ReadLine().Split();
	
			int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);
	
			int leftCounter = 0;
			int rightCounter = 0;
	
			for (int i = 0; i < smallerArrayLenght; i++)
			{
				if (firstArray[i] == secondArray[i])
				{
					leftCounter++;
				}
			}
	
			for (int i = 0; i < smallerArrayLenght; i++)
			{
				if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
				{
					rightCounter++;
				}
			}
	
			Console.WriteLine(Math.Max(rightCounter, leftCounter));
		}
	}
}