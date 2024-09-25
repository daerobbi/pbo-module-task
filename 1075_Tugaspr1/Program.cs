using System.Security.Cryptography.X509Certificates;
class coba
{
    static void Main(string[] args)
    {
        singa singa1= new singa(4, "Singa malaka", 2);
        gajah gajah1=new gajah(4,"Gajah Jawa",10);
        buaya buaya1 = new buaya(3, "Buaya Darat", 2);
        ular ular1 = new ular(5, "Ular Kobra", 2);
        KebunBinatang kebunBinatang1 = new KebunBinatang();

        kebunBinatang1.TambahHewan(buaya1);
        kebunBinatang1.TambahHewan(singa1);
        kebunBinatang1.TambahHewan(ular1);
        kebunBinatang1.TambahHewan(gajah1);

        kebunBinatang1.DaftarHewan();

        Console.WriteLine( gajah1.Suara());
        Console.WriteLine( buaya1.Suara());

        Console.WriteLine(gajah1.Suara());
        Console.WriteLine(ular1.Suara()); 

        singa1.mengaum();

        Console.WriteLine(singa1.InfoHewan()); ;

        ular1.merayap();
        
        Reptil reptil = new buaya(4,"aliem", 8);
        Console.WriteLine(reptil.Suara()); ;
    }
    
}
public class Hewan 
{
   public string nama;
   public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }
    public virtual string Suara()
    {
        return $"Hewan ini bersuara ";
    }

    public virtual string InfoHewan()
    {
        return $"\nNama Hewan: {nama} \nUmur Hewan: {umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int jumlahkaki;
    public Mamalia(int jumlahkaki,string nama, int umur) : base (nama, umur)
    {
        this.jumlahkaki = jumlahkaki;
    }
}
public class Reptil : Hewan
{
    public int panjangtubuh; 
    public Reptil(int panjangtubuh, string nama, int umur) : base(nama, umur)
    {
        this.panjangtubuh = panjangtubuh;
    }
}
public class singa : Mamalia
{
    public singa(int jumlahkaki, string nama, int umur) : base(jumlahkaki, nama, umur)
    {}
    public override string Suara()
    {
        return "\nSinga mengaum";
    }
    public void mengaum()
    {
        Console.WriteLine("\nhhhrraaahhhh");
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $"\nJumlah kaki : {jumlahkaki}";
    }
}
public class gajah : Mamalia
{
    public gajah(int jumlahkaki, string nama, int umur) : base (jumlahkaki,nama, umur){ }
    public override string Suara()
    {
        return "\nSuara gajah : trotttttt";
    }
}

public class ular : Reptil
{
    public ular(int panjangtubuh, string nama, int umur) : base(panjangtubuh,nama, umur){ }
    public override string Suara()
    {
        return "\nSuara ular : ssstttts";
    }
    public void merayap()
    {
        Console.WriteLine("\nUlar bergerak dengan merayap");
    }
}
public class buaya : Reptil
{
    public buaya(int panjangtubuh, string nama, int umur) : base(panjangtubuh, nama, umur){ }
    public override string Suara()
    {
        return "\nBuaya bersuara : hai cantik";
    }
}
public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}