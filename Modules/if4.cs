using System;

class if4
{
	static void Main()
	{
		int nobulan;
		string s, bulan="";

		Console.WriteLine("Menentukan Nama Bulan  ");
		Console.Write("Masukkan nomor bulan : ");
		s = Console.ReadLine();
		nobulan = int.Parse(s);

		if(nobulan==1)
		{
			bulan="Januari";
		}else if(nobulan==2)
		{
			bulan="februari";
		}else if(nobulan==3)
		{
			bulan="maret";
		}else if(nobulan==4)
		{
			bulan="april";
		}else if(nobulan==5)
		{
			bulan="mei";
		}else if(nobulan==6)
		{
			bulan="juni";
		}else if(nobulan==7)
		{
			bulan="juli";
		}else if(nobulan==8)
		{
			bulan="agustus";
		}else if(nobulan==9)
		{
			bulan="september";
		}else if(nobulan==10)
		{
			bulan="oktober";
		}else if(nobulan==11)
		{
			bulan="november";
		}else if(nobulan==12)
		{
			bulan="desember";
		}else
		{
			Console.WriteLine(" Maaf kode salah... ");
		}

		//menampilkan hasil
		if(bulan.Length!=0)
		{
			Console.WriteLine(" Bulan Ke - " + nobulan + " adalah " +bulan);
		}else
		{
			Console.WriteLine(" tidak ada bulan ke - " + nobulan);
		}

	}
}