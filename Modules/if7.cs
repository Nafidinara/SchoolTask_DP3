using System;
class if7
{
	static void Main()
	{
		int nilai;
		string s;

		Console.Clear();
		Console.Write("Masukkan Nilai Anda  : ");
		s = Console.ReadLine();
		nilai = int.Parse(s);

		if((nilai>=90)&&(nilai<=100))
		{
			Console.WriteLine("Nilai " + nilai + " Sangat Baik");
			Environment.Exit(1);
		}else if((nilai>=80)&&(nilai<90))
		{
			Console.WriteLine("Nilai " + nilai + " Baik");
			Environment.Exit(1);
		}else if((nilai>=70)&&(nilai<80))
		{
			Console.WriteLine("Nilai " + nilai + " Cukup");
			Environment.Exit(1);
		}else if((nilai>=60)&&(nilai<70))
		{
			Console.WriteLine("Nilai " + nilai + " Kurang");
			Environment.Exit(1);
		}else 
		{
			Console.WriteLine("Nilai " + nilai + " Sangat Kurang ");
			Environment.Exit(1);
		}
		
	}
}