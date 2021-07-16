namespace boasPraticas
{
  public class ICMS : ITax
  {
    public double Calculate(Budget budget)
    {
      return budget.Value * 0.1;
    }
  }
}