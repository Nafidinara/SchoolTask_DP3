using System;
class if6
{
	static void Main()
	{
		
		string gender;

		Console.Clear();
		Console.Write("Masukkan Kode Gender (P/p/L/l) : ");
		gender = Console.ReadLine();
		
		if((gender=="P")||(gender=="p")) //logika OR
		{
			Console.WriteLine( "Anda Seorang Perempuan");
			Environment.Exit(1);
		}else if((gender=="L")||(gender=="l"))
		{
			Console.WriteLine("Anda Seorang Laki-laki");
			Environment.Exit(1);
		}else
		{
			Console.WriteLine("Maaf Kode tidak terdefinisi");
			Environment.Exit(1);
		}
	}
}