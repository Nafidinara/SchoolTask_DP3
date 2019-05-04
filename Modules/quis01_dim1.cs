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
			string[] hari=new string [7] {"senin","selasa","rabu","kamis","jumat","sabtu","minggu"};
			Console.WriteLine("\n hari yang anda masukan adalah :");
			for (int a = 0; a<7; a++)
			{
				Console.WriteLine(a + "  " +hari[a] + "  ");
			}
			Console.ReadLine();
		}
	}
}