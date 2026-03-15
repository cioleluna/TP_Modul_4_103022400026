using System;

public enum Kelurahan
{
    Batununggal, Kujangsari, Mengger, Wates, Cijaura,
    Jatisari, Margasari, Sekejati, Kebonwaru, Maleer
}

public class KodePos
{
    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] tableKodePos = {
            40266, // Batununggal
            40287, // Kujangsari
            40267, // Mengger
            40256, // Wates
            40287, // Cijaura
            40286, // Jatisari
            40286, // Margasari
            40286, // Sekejati
            40272, // Kebonwaru
            40274  // Maleer
        };

        return tableKodePos[(int)kelurahan];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== IMPLEMENTASI KODE POS ===");
        Kelurahan kelurahan1 = Kelurahan.Batununggal;
        Console.WriteLine("Kode Pos " + kelurahan1 + " adalah " + KodePos.getKodePos(kelurahan1));

        Kelurahan kelurahan2 = Kelurahan.Kujangsari;
        Console.WriteLine("Kode Pos " + kelurahan2 + " adalah " + KodePos.getKodePos(kelurahan2));

        Kelurahan kelurahan3 = Kelurahan.Mengger;
        Console.WriteLine("Kode Pos " + kelurahan3 + " adalah " + KodePos.getKodePos(kelurahan3));

        Kelurahan kelurahan4 = Kelurahan.Wates;
        Console.WriteLine("Kode Pos " + kelurahan4 + " adalah " + KodePos.getKodePos(kelurahan4));

        Kelurahan kelurahan5 = Kelurahan.Cijaura;
        Console.WriteLine("Kode Pos " + kelurahan5 + " adalah " + KodePos.getKodePos(kelurahan5));

        Kelurahan kelurahan6 = Kelurahan.Jatisari;
        Console.WriteLine("Kode Pos " + kelurahan6 + " adalah " + KodePos.getKodePos(kelurahan6));

        Kelurahan kelurahan7 = Kelurahan.Margasari;
        Console.WriteLine("Kode Pos " + kelurahan7 + " adalah " + KodePos.getKodePos(kelurahan7));

        Kelurahan kelurahan8 = Kelurahan.Sekejati;
        Console.WriteLine("Kode Pos " + kelurahan8 + " adalah " + KodePos.getKodePos(kelurahan8));

        Kelurahan kelurahan9 = Kelurahan.Kebonwaru;
        Console.WriteLine("Kode Pos " + kelurahan9 + " adalah " + KodePos.getKodePos(kelurahan9));

        Kelurahan kelurahan10 = Kelurahan.Maleer;
        Console.WriteLine("Kode Pos " + kelurahan10 + " adalah " + KodePos.getKodePos(kelurahan10));
    }
}