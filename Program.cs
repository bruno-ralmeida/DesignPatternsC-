using System;

namespace boasPraticas
{
  class Program
  {
    static void Main(string[] args)
    {
      var iss = new ISS(new ICMS());
      var budget = new Budget(500);

      var value = iss.Calculate(budget);

      Console.WriteLine(value);
      Console.ReadKey();

    }
  }
}
