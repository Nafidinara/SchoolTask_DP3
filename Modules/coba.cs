using System;
class coba
{
	static void Main()
	{
		int[,] aTahun = new int[,] { { 2001, 2002, 2003 }, { 2005, 2006, 2007 } };
Console.WriteLine(aTahun[1, 2]); //Akan menampilkan 2003
Console.ReadKey();
	}
}