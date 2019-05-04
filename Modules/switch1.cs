using System;
class switch1 
{
	 static void Main() 
	 {
		 int nohari;
		 string s, namahari = "";
		 Console.Clear();
		 Console.Write("Masukkan nomor hari: ");
		 s = Console.ReadLine();
		 nohari = int.Parse(s);
		 switch (nohari) 
		 {
			case 1: namahari = "Senin"; break;
			case 2: namahari = "Selasa"; break;
			case 3: namahari = "Rabu"; break;
			case 4: namahari = "Kamis"; break;
			case 5: namahari = "Jumat"; break;
			case 6: namahari = "Sabtu"; break;
			case 7: namahari = "Minggu"; break;
			default: Console.WriteLine("Maaf kode salah...");
			break;
		 }
		 if (namahari != "")
		 {
			 Console.WriteLine("Hari ke-" + nohari +
			 " adalah " + namahari);
		 } else 
		 {
		 	Console.WriteLine("Tidak ada hari ke-" + nohari);//set path="C:\Windows\Microsoft.NET\Framework\v4.0.30319";%path%
	 	 }
 	}
}
}