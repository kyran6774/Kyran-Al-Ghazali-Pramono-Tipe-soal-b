using System;
using System.Security.Cryptography.X509Certificates;


   // soal nomor 1
    // 1. Class Agen
    public class Agen
{
    private string agen;
    private string namaagen;
    private int stokagen;
    

    public void agen(string agen) 
    {
        Console.WriteLine(".");
    }

    public void TampilInfo()
    {
        Console.WriteLine(".");
    }

   
    }


// soal nomor 2
    public class ProdukAgen
{
    private string produk;
    private string namaproduk;
    private int stokgudang;

    public void 
    
     


}


// soal nomor 3

public class ProdukGalon
{
  

    public virtual void Harga()
    {
        Console.WriteLine("Lihat Harga");

    }
}

public class GalonAkua : ProdukGalon
{
    public override void Harga()
    {
        Console.WriteLine("Harganya adalah Rp, 20.000");
    }

}

public class GalonBerkeran : ProdukGalon
{

    public override void Harga()
    {
        Console.WriteLine("Harganya adalah Rp, 12.000");
    }

} 