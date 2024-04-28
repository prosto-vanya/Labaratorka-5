class Americano : Coffee, IHotDrink
{
    public string Colour()
    {
        return "Colour of americano: Dark";
    }

    public override double Volume { get; set; }
}

