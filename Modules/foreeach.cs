using System;
class foreach1
{
	static void Main()
	{
		Console.Clear();
		int[]data= {75, 80, 85, 90};

		int jumlah;
		double ratarata;
		jumlah=0;

		foreach (int elemen in data)
		{
			jumlah=jumlah=elemen;
		}
		ratarata=(double)jumlah/data.Length;
		Console.WriteLine("data yang ada pada array (75, 80, 85, 90)");
		Console.WriteLine("total nilai = "+ jumlah);
	}
}