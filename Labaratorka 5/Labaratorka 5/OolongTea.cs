class OolongTea : Tea, IHotDrink 
{
    public string Colour()
    {
        return "Colour of oolong tea: Turquoise";
    }

    public override int Volume { get; set; }
}

