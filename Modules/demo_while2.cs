using System;
class demo_while2
{
	static void Main()
	{
		for (int a = 1; a <= 10; a++)
 
 {
   if (a == 6)
   {
    goto label_kondisi;
   }
	 
  Console.WriteLine(a);
  }	
	
  label_kondisi:
   Console.WriteLine("Red Is The New Black");
		}
	}
}