using System;
class inputchar//nama class
{
	static void Main()//fungsi utama
	{
		char c;
		string s;
		Console.Clear();//membersihkan layar
		Console.Write("Masukkan karakter : ");
		s = Console.ReadLine();//perintah input 
		
		//konveksi dari tipe string ke karakter
		if(char.TryParse(s,out c))//true
		{
			Console.WriteLine
			("karakter yang dimasukkan adalah '"+c+"'");
		}else//false
			{
				Console.WriteLine
				("Data yang Anda Masukkan"+
				"tidak dapat konversi"+
				"ke tipe karakter");
			}
			Console.ReadLine();
	}
}