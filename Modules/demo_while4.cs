using System;
class demo_while4
{
	static void Main()
	{
		Console.Clear();
		int x;
		x = 1;
		while(x<=256)
		{
			Console.Write(x + " ");
			x=x*2;
		}
	}
}