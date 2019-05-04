using System;
class g
{
    static void Main()
    {
        string nama,kamar,type;
        int harga,lama,total;
        

        try
        {
            Console.WriteLine("masukkan data : ");
            Console.WriteLine("=================");
            Console.WriteLine("masukkan nama anda : ");
            nama=Console.ReadLine();
            Console.Write("masukkan type kamar : ");
            
            Console.Write("masukkan lama anda menginap");
            lama=int.Parse(Console.ReadLine());
            {
                int harga=int.Parse(Console.ReadLine());
            }

            if (type == "A")
            {
                kamar = "biasa";
                harga = "500000";
            }
            else if (type == "B")
            {
                kamar ="sedang";
                harga ="600000";
            }
            else
            {
                kamar="khusus";
                harga="700000";
            }

            total= harga*lama;

            Console.WriteLine("");
            Console.WriteLine("nama pelanggan");
            Console.WriteLine("==============");
            Console.WriteLine("Nama = "+nama);
            Console.WriteLine("Lama Menginap = "+lama);
            Console.WriteLine("Nama kamar = "+kamar);
            Console.WriteLine("Total pembayaran = "+total);
            Console.ReadKey(true);
        }
        catch(Exception e) {Console.WriteLine(e);}
    }
}