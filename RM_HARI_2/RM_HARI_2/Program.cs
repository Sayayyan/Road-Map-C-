// See https://aka.ms/new-console-template for more information
Console.WriteLine("=================================================================");
Console.WriteLine("           Keterangan Lulus Berdasarkan Nilai Ujian              ");
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine();
Console.Write("Masukkan Nilai Ujian = ");
int nilaiujian = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(nilaiujian >= 75)
{
    Console.WriteLine("Anda dinyatakan lulus!");
}

else
{
    Console.WriteLine("Anda dinyatakan tidak lulus!");
}

Console.WriteLine();
Console.WriteLine();

//===============================================================================================================================================

Console.WriteLine("=================================================================");
Console.WriteLine("                Pembelian Buku Tulis (Rp7000)                    ");
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine();

Console.Write("Berapa jumlah buku tulis yang anda beli? ");
int jumbukutulis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int hargabukutulis = 7000;

if (jumbukutulis >= 5 && jumbukutulis < 15)
{
    Console.WriteLine("Selamat! anda mendapat diskon sebesar 10%");
    int harga = jumbukutulis * hargabukutulis * 10 / 100;
    Console.WriteLine($"Harga yang harus anda bayar adalah = RP{harga}");
}

else if (jumbukutulis >= 15)
{
    Console.WriteLine("Selamat! anda mendapat diskon sebesar 15%");
    int harga = jumbukutulis * hargabukutulis * 15 / 100;
    Console.WriteLine($"Harga yang harus anda bayar adalah = Rp{harga}");
}

else
{
    int harga = jumbukutulis * hargabukutulis;
    Console.WriteLine($"Harga yang harus anda bayar adalah = RP{harga}");
}

Console.WriteLine();

//===============================================================================================================================================
