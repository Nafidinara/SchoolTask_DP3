using System;//untuk import library(04)
class maskapai//nama class ini(04)
{
	static void Main()//mendeklarasikan method yang akan digunakan(04)
	{
		string nama,nik,tanggal,waktu,kelas="",maskapai="",tujuan="",username,password,bayar;//untuk memasukkan data nama,nik,kelas,dst.(04)
		int total,kembalian,x;//untuk menyatakan bilangan total, kembalian, x, dan kursi.(04)
		const string USERNAME= "a";//memasukkan konstanta username(04)
		const string PASSWORD= "a";//memasukkan konstanta password(04)
		Console.Clear();//untuk membersihkan pada jendela cmd(04)
		for( ; ;)//perintah perulangan(04)
		{
			Console.Write ("Username : ");//menginputkan username(04)
			username=Console.ReadLine();//inputan disimpan di string username(04)

			Console.Write("Password : ");//menginputkan password(04)
			password=Console.ReadLine();//inputan disimpan di string username(04)

			if((username==USERNAME)&&(password==PASSWORD))//jika username dan password yang dimasukkan sama seperti konstanta diatas maka dianggap true(04)
			{
				Console.ReadLine();//meminta input(04)
			}

			else//jika tidak maka(04)
			{
				Console.WriteLine("maaf salah");//akan memunculkan output tersebut(04)
				continue;//meneruskan ke selanjutnya(04)
			}

		Console.Write("Masukkan nama anda: ");//menginputkan nama(04)
		nama=Console.ReadLine();//inputan disimpan di string nama(04)
		Console.Write("Masukkan NIK anda: ");//mengunputkan NIK(04)
		nik=Console.ReadLine();//inputan disimpan di string nik(04)
		Console.Write("Masukkan tanggal penerbangan anda: ");//Memasukkan tanggal penerbangan(04)
		tanggal=Console.ReadLine();//inputan disimpan di string tanggal(04)
		Console.Write("Masukkan waktu penerbangan anda: ");//memasukkan waktu terbang(04)
		waktu=Console.ReadLine();//inputan disimpan di string waktu
		Console.WriteLine("Selamat datang "+ nama +", pilih jenis kelas anda : ");//mengeluarkan output tsb(04)
		Console.WriteLine();//untuk berganti baris(04)
		Console.WriteLine("1 : Ekonomi ");//mengeluarkan output disamping.(04)
		Console.WriteLine("2 : Bisnis ");//mengeluarkan output disamping.(04)
		Console.WriteLine("3 : Eksekutif ");//mengeluarkan output disamping.(04)
		Console.Write("Anda memilih pilihan ke : ");//memasukkan output dengan pilihan diatas(04)
		kelas= Console.ReadLine();//inputan disimpan di string kelas(04)
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
			Console.WriteLine("==================");
			Console.WriteLine("Nama : "+ nama);
			Console.WriteLine("NIK : "+ nik);
			Console.WriteLine("Kelas : "+ kelas);
			Console.WriteLine("Maskapai: "+ maskapai);
			Console.WriteLine("Tujuan : "+ tujuan);
        	{
            Random rand = new Random();
            int i = rand.Next(50);           
            Console.WriteLine("Kursi : " + i.ToString());
        	}
        	Console.WriteLine("Tanggal penerbangan : "+ tanggal);
        	Console.WriteLine("Waktu : "+ waktu);
			Console.WriteLine("Tarif kelas yang anda pilih : "+harga1);
			Console.WriteLine("Tarif maskapai yang anda pilih : "+harga2);
			Console.WriteLine("Tarif tujuan yang anda pilih : "+harga3);
			total=harga1+harga2+harga3;
		Console.WriteLine("Uang yang harus anda bayarkan adalah : "+total);
		
		for( ; ;)
		{
			Console.Write ("Masukkan uang yang akan anda bayarkan : ");
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
				Console.WriteLine("Maaf uang yang anda masukkan kurang!");
				continue;
			}
			{
            Random rand = new Random();
            int i = rand.Next(99999);           
            Console.WriteLine("Kode Transaksi Anda : "+ i.ToString());
        	}
			Console.WriteLine("Terima Kasih!");
			Console.WriteLine("====================");
			break;
		}
		break;
	}
}
}
}