// See https://aka.ms/new-console-template for more information
class KodeProduk
{
    private Dictionary<string, string> tabelKodeProduk = new Dictionary<string, string>() {
        { "Laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" },
        { "Mouse", "E105" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "Smartwatch", "E108" },
        { "Kamera", "E109" }
    };

    public string getKodeProduk(string namaProduk)
    {
        return tabelKodeProduk[namaProduk];
    }
}

class Program
{
    static void Main()
    {
        KodeProduk kodeProduk = new KodeProduk();
        string[] produkList = {"Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"};

        Console.WriteLine("Daftar Kode Produk:");
        foreach (var produk in produkList)
        {
            Console.WriteLine($"{produk}: {kodeProduk.getKodeProduk(produk)}");
        }
    }
}