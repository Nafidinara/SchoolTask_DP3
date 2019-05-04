using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace cara_membuat_array_dengan_input
{
	class Program
	{
		static void Main(string[] args)//sekumpulan data yang emiliki variabel yg sama
		{
			string[] nama = new string [5];
			Console.WriteLine("Masukan 5 Nama Teman Terdekat Anda :");
			for (int i = 0; i<5;i++) //looping input
			{
				Console.Write("Masukan nama index ke -  "+ i + " :" );
				nama[i] = Console.ReadLine();
			}
			Console.WriteLine("\n Nama yang anda masukan adalah :");
			for (int a = 0; a<5; a++) //looping output
			{
				Console.WriteLine(a +" " +nama[a] + " ");
			}
			Console.ReadLine();
		}
	}
}