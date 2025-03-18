using System;

public class Program
{
    public static void Main(string[] args)
    {
        Marka bmw = new Marka("BMW");
        string model = "X5";
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("sedan");
        decimal fiyat = 2000000m;

        Araba bmwX5 = new Araba(bmw, model, kapi, pencere, kasa, fiyat);

        bmwX5.ArabaBilgisiYazdir();
    }
}
