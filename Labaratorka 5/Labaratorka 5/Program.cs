class Program
{
    static void Main(string[] args)
    {
        Puer puer = new Puer() { Volume = 250};
        OolongTea oolongTea = new OolongTea() { Volume = 250 };
        BlackTea blackTea = new BlackTea() { Volume = 300 };
        Cappuccino cappuccino = new Cappuccino() { Volume = 200 };
        Latte latte = new Latte() { Volume = 350 };
        Americano americano = new Americano() { Volume = 250 };
        Console.WriteLine(puer.Colour());
        Console.WriteLine(oolongTea.Colour());
        Console.WriteLine(blackTea.Colour());
        Console.WriteLine(cappuccino.Colour());
        Console.WriteLine(latte.Colour());
        Console.WriteLine(americano.Colour());
    }
}