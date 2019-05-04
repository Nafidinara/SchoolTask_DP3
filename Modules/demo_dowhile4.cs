using System;
class demo_dowhile2
{
	static void Main()
	{
		Console.Clear();
		Console.WriteLine("menggunakkan do while : ");
		int x;
		x=1;
		do
		{
			Console.WriteLine(x);
			x=x*2;
		}while (x<=256);
	}
}