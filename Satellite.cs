namespace RoverControlCenter
{
  class Satellite : Probe
  {


    public Satellite(string alias, int year) : base(alias, year)
    {
      
    }

    public override string GetInfo()
    {
      return $"Alias: {Alias}, YearLaunched: {Year}";
    }

    public override string Explore()
    {
      return "Satellite is exploring the far reaches of space!";
    }

    public override string Collect()
    {
      return "Satellite is collecting photographic evidence!";
    }
  }
}
