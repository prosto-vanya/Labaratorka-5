class Puer : Tea, IHotDrink
{
    public string Colour()
    {
        return "Colour of puer tea: Dark red";
    }

    public override int Volume { get; set; }
}

