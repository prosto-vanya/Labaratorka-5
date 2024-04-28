class BlackTea : Tea, IHotDrink
{
    public string Colour()
    {
        return "Colour of black tea: Black =)";
    }

    public override int Volume { get; set; }
}

