using System;
class if2
{
	static void Main()
	{
		int x;
		string s;

		Console.Clear();
		Console.Write("Masukkan sebuah bilangan : ");
		s = Console.ReadLine();
		x = int.Parse(s);

		if(x<0)
		{
			Console.WriteLine(x + "merupakan bilangan negatif");
			Environment.Exit(1);
		}else if (x>0)
		{
			Console.WriteLine(x + "merupakan bilangan positif");
			Environment.Exit(1);
		}
		{
			Console.WriteLine("anda memasukkan bilangan" + x);
			Environment.Exit(1);
		}
	}
}