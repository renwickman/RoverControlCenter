using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      Probe lunokhod = new MoonRover("Lunokhod 1", 1970);
      Probe apollo = new MoonRover("Apollo 15", 1971);
      Probe sojourner = new MarsRover("Sojourner", 1997);
      Probe sputnik = new Satellite("Sputnik", 1957); 

      Probe[] i_probes = { lunokhod, apollo, sojourner, sputnik };
      DirectAll(i_probes);

      Object[] probes = { lunokhod, apollo, sojourner, sputnik };

      foreach (Object p in probes){
        Console.WriteLine($"Tracking a {p.GetType()}");
      }

    }

      public static void DirectAll(Probe[] iprobes)
      {
        foreach (Probe i in iprobes)
        {
          Console.WriteLine(i.GetInfo());
          Console.WriteLine(i.Explore());
          Console.WriteLine(i.Collect());
          Console.WriteLine("");
        }
      }
      
  }
}
