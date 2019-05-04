using System;
class foreach1
{
	static void Main()
	{
		Console.Clear();
		string[]huruf= {"Alfara", "nafi", "dinara", "aldo", "turman"};

		foreach (string elemen in huruf)
		{
			Console.WriteLine(elemen);		}
		{
			int[]angka={10,20,30,40};
			int jumlah;
			double rerata;
			jumlah=0;
			foreach (int elemen in angka)
			{
				jumlah=jumlah+elemen;
			}
			{
				rerata=(double)jumlah/angka.Length;
				Console.WriteLine("jumlah= "+jumlah);
				Console.WriteLine("rata-rata= "+rerata);
			}
		}
	}
}