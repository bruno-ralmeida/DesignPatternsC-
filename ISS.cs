namespace boasPraticas
{
  public class ISS : Tax
  {
    public ISS(Tax composeTax) : base(composeTax) { }
    public ISS() : base() { }
    public override double Calculate(Budget budget)
    {
      return budget.Value * 0.06 + base.CalculateCompose(budget);
    }

  }
}