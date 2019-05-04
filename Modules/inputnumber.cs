using System;
class inputnumber
{
	static void Main()
	{
		string input;
		double tinggi;
		double d2;
		
		Console.Clear();
		//menggunakan metode Parse()
		Console.WriteLine("input data menggunakan metode Parse");
		Console.Write("masukkan tinggi : ");
		input=Console.ReadLine();
		//nilai variabel yang telah diinput, sekarang disimpan pada variabel d1
		tinggi=double.Parse(input);
		Console.WriteLine("Anda memasukkan tinggi "+tinggi);
		Console.WriteLine("\n");
		
		//menggunakan kelas convert
		Console.WriteLine("input data menggunakan metode convert");
		Console.Write("masukkan bilangan bulat:");
		input=Console.ReadLine();
		//nilai variabel yang telah diinput, sekarang disimpan pada variabel d2
		//variabel input telah dikonversi menjadi tipe data double
		d2=Convert.ToDouble(input);
		Console.WriteLine("Anda memasukkan bilangan "+d2);
		Console.ReadLine();
	}
}