class Latte : Coffee, IHotDrink
{
    public string Colour()
    {
        return "Colour of latte: Red-brown";
    }

    public override double Volume { get; set; }
}

