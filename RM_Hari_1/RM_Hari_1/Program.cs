// See https://aka.ms/new-console-template for more information

Console.WriteLine("==================================================");
Console.WriteLine("               Pemesanan Perabotan                ");
Console.WriteLine("              --Semua Serba Rp25k--               ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();

int hargabarang = 25000;

Console.Write("Masukkan nama barang = ");
string? namabarang = Console.ReadLine();

Console.Write("Berapa jumlah barang = ");
int jumlahbarang = Convert.ToInt32(Console.ReadLine());

Console.Write("Nominal uang yang anda bayar = Rp");
int jumlahuang = Convert.ToInt32(Console.ReadLine());

int totalbayar = jumlahbarang * hargabarang;
int kembalian = jumlahuang - totalbayar;

if(jumlahuang >= totalbayar)
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("                  Data Pemesanan                  ");
    Console.WriteLine();

    Console.WriteLine($"Barang yang dipilih         = {namabarang}");
    Console.WriteLine($"Jumlah barang               = {jumlahbarang}");
    Console.WriteLine($"Nominal uang yang dibayar   = Rp{jumlahuang}");
    Console.WriteLine($"Nominal uang kembalian      = Rp{kembalian}");

    Console.WriteLine();
    Console.WriteLine("==================================================");
}

else
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Maaf, uang anda kurang untuk pembelian barang ini!");
    Console.WriteLine($"Karena uang anda hanya sebanyak Rp{jumlahuang}, nominal yang seharusnya dibayar Rp{totalbayar}");
    Console.WriteLine();
    Console.WriteLine("==================================================");
}
