namespace boasPraticas
{
  public class NoDiscount : IDiscount
  {
    public IDiscount nextDiscount { get; set; }

    public double Discount(Budget budget)
    {
      return 0;
    }
  }
}