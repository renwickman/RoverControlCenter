namespace RoverControlCenter
{
  class Probe
  {

    public string Alias
    { get; protected set; }

    public int Year
    { get; protected set; }


    public Probe(string alias, int year){
      Alias = alias;
      Year = year;
    }

    public virtual string GetInfo(){
      return $"Alias: {Alias}, YearLanded: {Year}";
    }

    public virtual string Explore()
    {
      return "Rover is exploring the surface!";
    }

    public virtual string Collect()
    {
      return "Rover is collecting rocks!";
    }
  }
}