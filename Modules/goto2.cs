using System;
class goto2
{
	static void Main()
	{
		string jenispaket;
		Console.Clear();
		Console.WriteLine("jenis Paket Pengiriman Barang");
		Console.WriteLine("1 : reguler ");
		Console.WriteLine("2 : Kilat ");
		Console.WriteLine("3 : Kilat khusus");
		Console.WriteLine();
		Console.Write("masukkan pilihan anda : ");
		jenispaket= Console.ReadLine();
		jenispaket=jenispaket.ToLower();
		int harga = 0;
		switch (jenispaket)
		{
			case "1":
			case "regular":
			harga = harga + 10000;
			break;

			case "2":
			case "Kilat":
			harga = harga + 15000;
			break;

			case "3":
			case "Kilat khusus":
			harga = harga + 20000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
		}
		
		if (harga !=0)
		{
			Console.WriteLine("Harga yang harus dibayar:"+ harga);
		Console.WriteLine("Terima kasih atas kepercayan anda");
		}
	}
}