// See https://aka.ms/new-console-template for more information

//Tabel KodePos
//3.A
public class KodePos
{
    private Dictionary <string, string> kodePos;
    public KodePos()
    {
        kodePos = new Dictionary <string, string>
        {
            //Data yang disediakan
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    //Method getKodePos, mengambil kode pos dari tabel
    //3.B
    public string GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            //Mengembalikan kode pos dari data yang ada
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}

// Representasikan state pintu
public enum DoorState
{
    Terbuka,
    Terkunci
}

//Menambahkan kode dengan state-based construction
//5.A
public class DoorMachine
{
    private DoorState currentState;
    public DoorMachine()
    {
        //Pada soal diminta untuk state awal = terkunci
        //5.B
        currentState = DoorState.Terkunci;
    }

    //Saat kondisi pintu terkunci
    public void KunciPintu()
    {
        //5.C
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    //Mengubah state pintu menjadi terbuka
    public void BukaPintu()
    {
        //5.D
        currentState = DoorState.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Menggunakan teknik table-driven
        KodePos KodPost = new KodePos();
        string kelurahan;
        //Console.WriteLine(GetKodePos(kelurahan));

        kelurahan = "Wates";
        string kodePos = KodPost.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos dari Kelurahan {kelurahan} adalah {kodePos}");

        kelurahan = "Jatisari";
        kodePos = KodPost.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos dari Kelurahan {kelurahan} adalah {kodePos}");

        kelurahan = "Samoja";
        kodePos = KodPost.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos dari Kelurahan {kelurahan} adalah {kodePos}");

        // Menggunakan teknik state-based construction untuk pintu
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.KunciPintu();
        doorMachine.BukaPintu();
    }
}

