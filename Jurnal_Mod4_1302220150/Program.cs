// See https://aka.ms/new-console-template for more information
//Command Kode Buah
KodeBuah buah = new KodeBuah();
buah.getKodeBuah("Anggur");
buah.getKodeBuah("abc");

//Command Posisi Karakter
PosisiKarakter kar = new PosisiKarakter();
Console.WriteLine("Posisi StandBy");
Console.WriteLine("Masukan Command: ");
String Command = Console.ReadLine();
while (Command != "0")
{
    kar.bergerak(Command);
    
    Console.WriteLine("Masukan Command: ");
    Command = Console.ReadLine();
}

public class KodeBuah
{
    String[] NamaBuah = {"Apel", "Aprikot", "Alpukat","Pisang", "Paprika", "Blackberry", "ceri", "Kelapa"
        ,"Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka"};
    String[] Kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

    public void getKodeBuah(String nama)
    {
        String kdbh ="";
        for(int i = 0; i < NamaBuah.Length; i++)
        {
            if (nama == NamaBuah[i])
            {
                kdbh = Kode[i];
            }
            
        }
        if (kdbh != "")
        {
            Console.WriteLine(kdbh);
        }
        else
        {
            Console.WriteLine("Buah Tidak Ditemukan");
        }
    }
}

public class PosisiKarakter
{
    enum Karakter { Jongkok, Berdiri, Tengkurap, Terbang };
    Karakter karakter = Karakter.Berdiri;

    //String[] moveset = { "Jongkok", "Berdiri", "Tengkurap", "Terbang" };

    public void bergerak(String gerakan)
    {
        //Console.WriteLine("Karakter " + moveset[(int)karakter]);
        switch (karakter)
        {
            case Karakter.Jongkok:
                if (gerakan == "TombolS")
                {
                    karakter = Karakter.Tengkurap;
                    Console.WriteLine("Posisi Istirahat");
                } else if (gerakan == "TombolW")
                {
                    karakter = Karakter.Berdiri;
                    Console.WriteLine("Posisi StandBy");
                }
                else
                {
                    karakter = Karakter.Jongkok;
                }
                break;
            case Karakter.Berdiri:
                if (gerakan == "TombolS")
                {
                    karakter = Karakter.Jongkok;
                }
                else if (gerakan == "TombolW")
                {
                    karakter = Karakter.Terbang;
                }
                else
                {
                    karakter = Karakter.Berdiri;
                    Console.WriteLine("Posisi StandBy");
                }
                break;
            case Karakter.Terbang:
                if (gerakan == "TombolS")
                {
                    karakter = Karakter.Berdiri;
                    Console.WriteLine("Posisi StandBy");
                }
                else if (gerakan == "TombolX")
                {
                    karakter = Karakter.Jongkok;
                }
                else
                {
                    karakter = Karakter.Terbang;
                }
                break;
            case Karakter.Tengkurap:
                if (gerakan == "TombolW")
                {
                    karakter = Karakter.Jongkok;
                }
                else
                {
                    karakter = Karakter.Tengkurap;
                    Console.WriteLine("Posisi Istirahat");
                }
                break;
        }
        
    }
}
