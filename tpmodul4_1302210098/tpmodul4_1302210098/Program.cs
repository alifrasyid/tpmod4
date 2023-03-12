using System;

public class KodePos
{
    public enum Kelurahan{Batununggal,Kujangsari,Mengger,Wates,Cijaura,Jatisari,Margasari,Sekejati,Kebonwaru,Maleer,Samoja}

    public String getKodePos(Kelurahan kelurahan)
    {
        string kodepos = "";

        switch (kelurahan)
        {
            case Kelurahan.Batununggal:
                kodepos = "40266";
                break;
            case Kelurahan.Kujangsari:
                kodepos = "40287";
                break;
            case Kelurahan.Mengger:
                kodepos = "40267";
                break;
            case Kelurahan.Wates:
                kodepos = "40256";
                break;
            case Kelurahan.Cijaura:
                kodepos = "40287";
                break;
            case Kelurahan.Jatisari:
                kodepos = "40286";
                break;
            case Kelurahan.Margasari:
                kodepos = "40286";
                break;
            case Kelurahan.Sekejati:
                kodepos = "40286";
                break;
            case Kelurahan.Kebonwaru:
                kodepos = "40272";
                break;
            case Kelurahan.Maleer:
                kodepos = "40274";
                break;
            case Kelurahan.Samoja:
                kodepos = "40273";
                break;
            default:
                kodepos = "Kode pos untuk kelurahan tersebut tidak ditemukan.";
                break;
        }

        return kodepos;
    }
}
class MainClass
{
    static void Main()
    {
        KodePos kodePosK = new KodePos();
        KodePos.Kelurahan kelurahan = KodePos.Kelurahan.Kujangsari;
        string kodepos = kodePosK.getKodePos(kelurahan);
        Console.WriteLine("Kode pos untuk kelurahan "+kelurahan+" adalah "+ kodepos);
    }
}
