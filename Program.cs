// See https://aka.ms/new-console-template for more information
using System.Net;

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

class FanLaptop
{
    private enum State { Queit, Balanced, Performance, Turbo };
    private State currentState;
    public enum Trigger { up, down, shortcut };



    public FanLaptop()
    {
        currentState = State.Queit;
    }

    public void Command(Trigger pilihan)
    {
        
        switch (currentState)
        {
            case State.Queit:
                if (pilihan == Trigger.up)
                {
                    currentState = State.Balanced;
                    Console.WriteLine("Fan Queit berubah menjadi Balanced");
                }
                else if (pilihan == Trigger.shortcut)
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan Queit berubah menjadi Turbo");
                }
                break;
            case State.Balanced:
                if (pilihan == Trigger.up)
                {
                    currentState = State.Performance;
                    Console.WriteLine("Fan Balanced berubah menjadi Performance");
                }
                else if (pilihan == Trigger.down)
                {
                    currentState = State.Queit;
                    Console.WriteLine("Fan Balanced berubah menjadi Queit");
                }
                break;
            case State.Performance: 
                if (pilihan == Trigger.up)
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan Performance berubah menjadi Turbo");
                }
                break;
            case State.Turbo:
                if (pilihan == Trigger.shortcut)
                {
                    currentState = State.Queit;
                    Console.WriteLine("Fan Turbo berubah menjadi Queit");

                }
                else if (pilihan == Trigger.down)
                {
                    currentState = State.Performance;
                    Console.WriteLine("Fan Turbo berubah menjadi Performance");
                }
                break;
        }
        Console.WriteLine("EXIT");
    }

    public void Status()
    {
        Console.WriteLine($"Status Fan saat ini: {currentState}");
    }


    class Program
    {
        static void Main()
        {
            KodeProduk kodeProduk = new KodeProduk();
            string[] produkList = { "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera" };

            Console.WriteLine("Daftar Kode Produk:");
            foreach (var produk in produkList)
            {
                Console.WriteLine($"{produk}: {kodeProduk.getKodeProduk(produk)}");
            }

            FanLaptop fanLaptop = new FanLaptop();
            fanLaptop.Status();

            string input = "";
            while (input.ToLower() != "Quit") ;

            Console.WriteLine("Command (Up, Down, Shortcut : ");
            input = Console.ReadLine();

            if (Enum.TryParse(input, out FanLaptop.Trigger trigger));
        }
    }
}