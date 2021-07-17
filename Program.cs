using System;

namespace boasPraticas
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculator = new DiscountCalculator();

      Budget budget = new Budget(1250);

      budget.AddItem(new Item("Caneta", 250));
      budget.AddItem(new Item("Lapís", 250));
      budget.AddItem(new Item("Borracha", 250));
      budget.AddItem(new Item("Grafite", 250));
      budget.AddItem(new Item("Pincel", 250));


      var discount = calculator.Calculate(budget);

      Console.WriteLine("Desconto: {0}", discount);
      Console.ReadKey();

    }
  }
}
