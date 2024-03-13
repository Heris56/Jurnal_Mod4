// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
KodeBuah buah = new KodeBuah();
buah.getKodeBuah("Anggur");
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

}
