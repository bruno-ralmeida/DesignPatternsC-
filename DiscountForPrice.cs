using System;

namespace boasPraticas
{
  public class DiscountForPrice : IDiscount
  {
    public IDiscount nextDiscount { get; set; }
    public double Discount(Budget budget)
    {
      if (budget.Value > 500)
      {
        Console.WriteLine("Calculando desconto por preço...");
        return budget.Value * 0.7;
      }
      return nextDiscount.Discount(budget);
    }
  }
}