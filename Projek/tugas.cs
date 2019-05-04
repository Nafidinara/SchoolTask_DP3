using System;
class tugas_final
{
	static void Main()
	{
		string nama,nik,tanggal,waktu,kelas="",maskapai="",tujuan="",username,password,bayar;//untuk memasukkan data nama,nik,kelas,dst.
		int total,kembalian,x,kursi;//untuk menyatakan bilangan total, kembalian, x, dan kursi.
		const string USERNAME= "a";
		const string PASSWORD= "a";
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
				Console.ReadLine();
			}

			else
			{
				Console.WriteLine("maaf salah");
				continue;
			}

		Console.Write("Masukkan nama anda: ");
		nama=Console.ReadLine();
		Console.Write("Masukkan NIK anda: ");
		nik=Console.ReadLine();
		Console.Write("Masukkan tanggal penerbangan anda: ");
		tanggal=Console.ReadLine();
		Console.Write("Masukkan waktu penerbangan anda: ");
		waktu=Console.ReadLine();
		Console.WriteLine("Selamat datang "+ nama +", pilih jenis kelas anda : ");
		Console.WriteLine();
		Console.WriteLine("1 : Ekonomi ");
		Console.WriteLine("2 : Bisnis ");
		Console.WriteLine("3 : Eksekutif ");
		Console.Write("Anda memilih pilihan ke : ");
		kelas= Console.ReadLine();
		kelas= kelas.ToLower();
		int harga1 = 0;

		Console.WriteLine("Pilih maskapai anda : ");
		Console.WriteLine("1 : Garuda Indonesia ");
		Console.WriteLine("2 : Citilink ");
		Console.WriteLine("3 : Lion Air ");
		Console.Write("Anda memilih pilihan ke : ");
		maskapai= Console.ReadLine();
		maskapai= maskapai.ToLower();
		int harga2 = 0;

		Console.WriteLine("Pilih tujuan anda : ");
		Console.WriteLine("1 : Jakarta - Denpasar ");
		Console.WriteLine("2 : Jakarta - Papua");
		Console.WriteLine("3 : Jakarta - Madinah");
		Console.Write("Anda memilih tujuan ke : ");
		tujuan= Console.ReadLine();
		tujuan= tujuan.ToLower();
		int harga3 = 0;
		Console.WriteLine();
		switch (kelas)
		{
			case "1": kelas="Ekonomi";
			harga1 = harga1 + 500000;
			break;

			case "2": kelas="Bisnis";
			harga1 = harga1 + 750000;
			break;

			case "3": kelas="Eksekutif";
			harga1 = harga1 + 1000000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
		}
		switch (maskapai)
		{
			case "1": maskapai = "Garuda Indonesia";
			harga2 = harga2 + 900000;
			break;

			case "2": maskapai = "Citilink";
			harga2 = harga2 + 1500000;
			break;

			case "3": maskapai = "Lion Air";
			harga2 = harga2 + 4000000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
			}
		switch (tujuan)
		{
			case "1": tujuan ="Jakarta - Papua";
			harga3 = harga3 + 900000;
			break;

			case "2": tujuan ="Jakarta - Denpasar";
			harga3 = harga3 + 1500000;
			break;

			case "3": tujuan ="Jakarta - Madinah";
			harga3 = harga3 + 4000000;
			break;

			default:
			Console.Write("Pilihan tidak tersedia");
			Console.WriteLine("Silahkan pilih 1, 2, atau 3!");
			break;
			}
			Console.Clear();
		
		if (harga3 !=0)
		{
			Console.WriteLine("============================================");
			Console.WriteLine("Nama : "+ nama);
			Console.WriteLine("NIK : "+ nik);
			Console.WriteLine("Maskapai: "+ maskapai);
			Console.WriteLine("Tujuan : "+ tujuan);
        	{
            Random rand = new Random();
            kursi = rand.Next(50);           
            Console.WriteLine("Kursi : " + kursi.ToString());
        	}
        	Console.WriteLine("Tanggal penerbangan "+ tanggal);
        	Console.WriteLine("Waktu "+ waktu);
			Console.WriteLine("Tarif kelas yang anda pilih : "+harga1);
			Console.WriteLine("Tarif maskapai yang anda pilih : "+harga2);
			Console.WriteLine("Tarif tujuan yang anda pilih : "+harga3);
			total=harga1+harga2+harga3;
		Console.WriteLine("Uang yang harus anda bayarkan adalah : "+total);
		
		for( ; ;)
		{
			Console.Write ("masukkan uang yang akan anda bayarkan : ");
			bayar=Console.ReadLine();
			x= int.Parse(bayar);

			if(x >= total)
			{
				kembalian=x-total;
				Console.WriteLine("Anda menerima uang kembali sejumlah : "+kembalian);
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("maaf uang yang anda masukkan kurang!");
				continue;
			}
			Console.WriteLine("Kode Transaksi Anda : "+ nama + maskapai + kursi);
			Console.WriteLine("Terima Kasih!");
			Console.WriteLine("==============================================");
			break;
		}
		break;
	}
}
}
}