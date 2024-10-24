namespace RoverControlCenter
{
  class Rover : Probe
  {


    public Rover(string alias, int year) : base(alias, year)
    {
   
    }

    public override string GetInfo()
    {
      return $"Alias: {Alias}, YearLanded: {Year}";
    }

    public override string Explore()
    {
      return "Rover is exploring the surface!";
    }

    public override string Collect()
    {
      return "Rover is collecting rocks!";
    }
  }
}
