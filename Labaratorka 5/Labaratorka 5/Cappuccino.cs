class Cappuccino : Coffee, IHotDrink
{
    public string Colour()
    {
        return "Colour of cappucino: Red-brown";
    }

    public override double Volume { get; set; }
}

