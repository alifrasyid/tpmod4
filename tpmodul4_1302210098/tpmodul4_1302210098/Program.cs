using System;

public class KodePos
{
    public enum Kelurahan{Batununggal,Kujangsari,Mengger,Wates,Cijaura,Jatisari,Margasari,Sekejati,Kebonwaru,Maleer,Samoja}

    public static int getKodePos(Kelurahan KELURAHAN)
    {
        int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodepos[(int)KELURAHAN];
    }
}

public class DoorMachine
{
    enum DoorState {Terkunci,Terbuka}
    DoorState Pintu = DoorState.Terkunci;
    string kondisi = "KunciPintu";

    public void ChangeState()
    {
        Console.WriteLine("Pintu Terkunci");
        while (kondisi == "KunciPintu" || kondisi == "BukaPintu")
        {
            Console.Write("Masukkan Perintah : ");
            kondisi = Console.ReadLine();
            if (kondisi == "BukaPintu")
            {
                Pintu = DoorState.Terbuka;
                Console.WriteLine("Pintu Tidak Terkunci");
            }
            else if (kondisi == "KunciPintu")
            {
                Pintu = DoorState.Terkunci;
                Console.WriteLine("Pintu Terkunci");
            }

        }
    }
}
class MainClass
{
    static void Main()
    {
        KodePos kodePosK = new KodePos();
        KodePos.Kelurahan kelurahan = KodePos.Kelurahan.Kujangsari;
        int kodepos = KodePos.getKodePos(KodePos.Kelurahan.Kujangsari);
        Console.WriteLine("Kode pos untuk kelurahan "+kelurahan+" adalah "+ kodepos);

        DoorMachine dm = new DoorMachine();
        Console.WriteLine("Perintah : KunciPintu, BukaPintu");
        dm.ChangeState();
    }
}
