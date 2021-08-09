
using System;

class main
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter Number");
		int iValue = Convert.ToInt32(Console.ReadLine());
		
		ArithmeticX aobj = new ArithmeticX();
		aobj.NonFactor(iValue);
	}
}

class ArithmeticX
{
	public void NonFactor(int iNo)
	{
		if(iNo < 0)
		{
			iNo = -iNo;
		}

		int i = 2;

		do
		{
			if(iNo % i != 0)
			{
				Console.Write(i+" ");
			}

			i++;
		}while(i < iNo);
		Console.WriteLine();
	}
}