using System;
class switch2 
{
	 static void Main() 
	 {
		 string s, namahari;
		 int nohari = 0;
		 Console.Write("Masukkan nama hari: ");
		 s = Console.ReadLine();
		 // mengubah nama hari menjadi huruf kecil
		 namahari = s.ToLower();
		 switch (namahari) 
		 {
			case "senin": nohari = 1; break;
			case "selasa": nohari = 2; break;
			case "rabu": nohari = 3; break;
			case "kamis": nohari = 4; break;
			case "jumat": nohari = 5; break;
			case "sabtu": nohari = 6; break;
			case "minggu": nohari = 7; break;
			default:
			{
				Console.WriteLine(s + " bukan nama hari");
				Environment.Exit(1);
				break;
			}
		 }
			 Console.WriteLine(s + " adalah " + "hari ke-" 
			 	+ nohari);
	 }
}