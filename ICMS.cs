namespace boasPraticas
{
  public class ICMS : Tax
  {
    public ICMS(Tax composeTax) : base(composeTax) { }
    public ICMS() : base() { }
    public override double Calculate(Budget budget)
    {
      return budget.Value * 0.1 + base.CalculateCompose(budget);
    }
  }
}