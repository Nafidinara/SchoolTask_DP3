using System;
class inputkonstanta
{
	static void Main()
	{
		//mendefinisikan konstanta
		const double PI=3.14;
		
		//jari-jari lingkaran
		double r=3;
		
		//rumus luas lingkaran
		double luas=PI*r*r;
		
		//mencetak ke layar monitor
		Console.WriteLine("nilai PHI="+PI);
		Console.WriteLine("nilai jari-jari lingkaran ="+r);
		Console.WriteLine("luas lingkaran ="+luas);
		Console.ReadLine();
	}
}