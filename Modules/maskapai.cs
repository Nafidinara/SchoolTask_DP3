using System;
class f
{
	static void Main()
	{
		string nama,kelas,tujuan,username,password;
		int total;
		const string USERNAME= "Alfara";
		const string PASSWORD= "Alfara";

		Console.Clear();
		for( ; ;)
		{
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
		Console.Write("Masukkan nama anda: ");
		nama=Console.ReadLine();
		Console.WriteLine("Selamat datang "+ nama +", pilih jenis kelas anda: ");
		Console.WriteLine();
		Console.WriteLine("1 : Ekonomi ");
		Console.WriteLine("2 : Bisnis ");
		Console.WriteLine("3 : Eksekutif ");
		Console.Write("Anda memilih pilihan ke - ");
		kelas= Console.ReadLine();
		kelas= kelas.ToLower();
		int harga1 = 0;

		Console.WriteLine("Pilih tujuan anda: ");
		Console.WriteLine();
		Console.WriteLine("1 : Jakarta - Denpasar ");
		Console.WriteLine("2 : Jakarta - Papua");
		Console.WriteLine("3 : Jakarta - Madinah");
		Console.Write("Anda memilih tujuan ke - ");
		tujuan= Console.ReadLine();
		tujuan= tujuan.ToLower();
		int harga2 = 0;
		switch (kelas)
		{
			case "1":
			case "Ekonomi":
			harga1 = harga1 + 90000;
			break;

			case "2":
			case "Bisnis":
			harga1 = harga1 + 150000;
			break;

			case "3":
			case "Eksekutif":
			harga1 = harga1 + 400000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
		}
		switch (tujuan)
		{
			case "1":
			case "Jakarta - Denpasar":
			harga2 = harga2 + 90000;
			break;

			case "2":
			case "Jakarta - Papua":
			harga2 = harga2 + 150000;
			break;

			case "3":
			case "Jakarta - Madinah":
			harga2 = harga2 + 400000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
			}
		
		if (harga1 !=0)
		{
			Console.WriteLine("Harga kelas : "+ harga1);
		}
		if (harga1 !=0)
		{
			Console.WriteLine("Tarif jarak tempuh : "+ harga2);
		}
		total=harga1+harga2;
		Console.WriteLine("Uang yang harus anda bayarkan adalah : "+total);
		}
	}