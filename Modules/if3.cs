using System;
class if3
{
	static void Main()
	{
		int x;
		string s;

		Console.Clear();
		Console.Write("Masukkan bilangan : ");
		s = Console.ReadLine();
		x = int.Parse(s);

		if(x%2==0)
		{
			Console.WriteLine("bilangan "+ x + " merupakan bilangan genap");
			Environment.Exit(1);
		}else
		{
			Console.WriteLine("bilangan "+ x + " merupakan bilangan ganjil");
			Environment.Exit(1);
		}
		{
			Console.WriteLine("anda memasukkan bilangan" + x);
			Environment.Exit(1);
		}
	}
}