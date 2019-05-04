using System;
class demo_while1
{
	static void Main()
	{
		Console.Clear();
		int x;
		string s;
		Console.Write("Masukkan nilai akhir : ");
		s = Console.ReadLine();
		x = int.Parse(s);
		do
		{
			Console.WriteLine(x);
			x=x-1;
		}while (x);
	}
}