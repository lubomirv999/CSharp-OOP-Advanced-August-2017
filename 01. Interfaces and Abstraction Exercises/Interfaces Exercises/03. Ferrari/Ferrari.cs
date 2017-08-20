public class Ferrari : ICar
{
    public string Model { get; } 

    public string Driver { get; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }

    public string PushTheGasPedal()
    {
        return $"Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{UseBrakes()}/{PushTheGasPedal()}/{this.Driver}";
    }
}