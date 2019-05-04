using System;
class variabel1
{
    static void Main()
    {
        //mendeklarasikan variabel
        int panjang;
        int lebar;
        int luas;

        //mengisi nilai ke dalam variabel
        panjang = 8;
        lebar = 6;

        //melakukan perhitungan dan menampung hasilnya ke dalam variabel luas
        luas = panjang*lebar;

        //menampilkan informasi program
        Console.WriteLine("Persegi Panjang");

        //menampilkan nilai vairabel
        Console.WriteLine("Panjang=" + panjang);
        Console.WriteLine("Lebar=" + lebar);

        //menampilkan hasil perhitungan
        Console.WriteLine("Luas Persegi Panjang=" + luas);
        Console.ReadLine();
    }
}