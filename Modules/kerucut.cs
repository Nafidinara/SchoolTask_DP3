using System;
class kerucut
{
	static void Main()
	{
		string input;
		const double PI=3.14;
		const double kons=0.333;
		double d1;
		double d2;
		double volume=kons*PI*d2*d2*d1;

		Console.Clear();
		Console.Write("masukkan nilai tinggi :");
		input=Console.ReadLine();
		d1=Convert.ToDouble(input);
		Console.WriteLine("Anda memasukkan tinggi "+d1);
		Console.ReadLine();
		Console.Write("masukkan nilai jari-jari : ");
		input=Console.ReadLine();
		d2=Convert.ToDouble(input);
		Console.WriteLine("Anda memasukkan bilangan "+d2);
		Console.ReadLine();
	}
}