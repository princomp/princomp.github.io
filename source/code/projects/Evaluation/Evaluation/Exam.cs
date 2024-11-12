abstract class Exam : Evaluation
{
  public Exam(string courseP, double weightP, bool bonusP)
    : base(courseP, weightP, bonusP) { }

  public abstract string GetRoom();

  public sealed override string GetContact()
  {
    return "Contact the " + Course + " instructor.";
  }

  public override string ToString()
  {
    return base.ToString() + "\nRoom:\t\t" + GetRoom();
  }
}
