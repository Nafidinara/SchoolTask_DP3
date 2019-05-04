using System;
class variabel3
{
		static void Main()
		{
				//variabel dengan tipe var
				var a=-1;
				var b=1.11;
			
				//menampilkan nilai awal
				Console.WriteLine("Nilai Awal:");
				Console.WriteLine("a="+a);
				Console.WriteLine("b="+b);
				Console.WriteLine();
			
				//menampilkan tipe data dari a dan b
				Console.WriteLine("Tipe Data:");
				Console.WriteLine("Tipe a "+a.GetType());
				Console.WriteLine("Tipe b "+b.GetType());
				Console.WriteLine();
			
				//mengubah nilai a dan b
				a=13;
				b=4.44;
				
				//mengubah nilai a dan b
				Console.WriteLine("Nilai Setelah Diubah");
				Console.WriteLine("a="+a);
				Console.WriteLine("b="+b);
				Console.WriteLine();
				
				//gettype menginisialissasi
		}
}