namespace boasPraticas
{
  public interface IDiscount
  {
    public double Discount(Budget budget);
    IDiscount nextDiscount { get; set; }
  }
}