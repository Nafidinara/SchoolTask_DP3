using System;
class for1
{
	static void Main()
	{
		int n, x, jumlah;
		double ratarata;
		Console.Write("masukkan banyaknya data (nilai)");
		n=int.Parse(Console.ReadLine());
		jumlah=0;

		for (int i=1; i<=n; i++)
		{
			Console.Write("nilai ke- "+i+" : ");
			x=int.Parse(Console.ReadLine());
			jumlah=jumlah+x;
		}

		ratarata = (double) jumlah/n;
		Console.WriteLine("\n Total Nilai = " + jumlah);
		Console.Write("rata-rata= " + ratarata);
	}
}