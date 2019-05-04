using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace cara_membuat_array_dengan_input
{
	class Program
	{
		static void Main(string[] args)
		{
			
				string[] nilai=new string [4];
				Console.WriteLine("masukkan nama : ");
				for (int x=0; x<4;x++)
				{
					Console.Write("Masukan nama index ke- "+ x + " :" );
					Console.Write("Masukan nilai );
				nilai[x] = Console.ReadLine();
				}
			
			string[] nama = new string [4];
			Console.WriteLine("Masukan 4 Mapel UN : ");
			for (int i = 0; i<4;i++) //looping input
			{
				Console.Write("Masukan Mapel UN ke - "+ i + " : " );
				nama[i] = Console.ReadLine();
			}
			Console.WriteLine("\n Nama dan nilai yang anda masukan adalah :");
			for (int a = 0; a<4; a++) //looping output
			{
				Console.WriteLine(a +" " +nama[a] +" : "+nilai[a]+" ");
			}
			Console.ReadLine();
		}
	}
}