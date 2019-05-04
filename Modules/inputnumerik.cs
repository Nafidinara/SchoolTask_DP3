using System;
class inputnumerik//nama class
{
	static void Main()
	{
		string input;
		int i;
		double d;
		Console.Clear();
		//membaca data bilangan bulat
		Console.Write("masukkan bilangan bulat : ");
		input=Console.ReadLine();
		if(int.TryParse(input, out i))//true
		{
			Console.WriteLine("Anda memasukkan bilangan "+ i);
		}else//false
			{	
				Console.WriteLine("Salah : " + "konversike integer gagal");
		}
		//membaca data bilangan riil
			Console.Write("\n Masukkan bilangan bulat : ");
			input= Console.ReadLine();
			if(double.TryParse(input, out d))
		{
			Console.WriteLine("Anda memasukkan bilangan"+ d);
		}else
			{
				Console.WriteLine("Salah :" + "konversi ke double gagal");
			}
		Console.ReadLine();
	}
}