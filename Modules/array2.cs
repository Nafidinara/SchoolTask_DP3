using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace cara_membuat_array_dimensil
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nama=new string [5] {"Adi","Budi","Caca","Deni","Lala"};
			Console.WriteLine("\n Nama yang adnda masukan adalah :");
			for (int a = 0; a<5; a++)
			{
				Console.WriteLine(a + "  " +nama[a] + "  ");
			}
			Console.ReadLine();
		}
	}
}