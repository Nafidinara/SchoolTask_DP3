using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Inheritance
{
class induk
{ //hak akses private berarti tidak dapat diakses oleh kls anak
public int var2 = 10; //hak akses public berarti dapat diakses oleh kls anak
public induk()
{ }
public void cetakData()
{ }
}
class anak : induk
{
public anak()
{ }
public void cetak()
{
cetakData();
}
}
class Program
{
static void Main(string[] args)
{
anak anak = new anak();
 
anak.cetak();
anak.cetakData();
 
Console.WriteLine("Inheritance Menggunakan C#");
Console.WriteLine("Isi Var 2 = " + anak.var2);
 
Console.ReadLine();
}
}
}