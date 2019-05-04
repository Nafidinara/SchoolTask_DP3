using System;
class break2
{
	static void Main()
	{
		const string USERNAME= "Alfara";
		const string PASSWORD= "kopi nikmat nyaman di lambung";
		string username, password;
		for( ; ;)
		{
			Console.WriteLine("Luwak White Coffe, paswwordnya");
			Console.Write ("username : ");
			username=Console.ReadLine();

			Console.Write("password : ");
			password=Console.ReadLine();
			Console.WriteLine();

			if((username==USERNAME)&&(password==PASSWORD))
			{
				break;
			}
		}
		Console.WriteLine("Selamat , 2 juta rupiyah");
	}
}