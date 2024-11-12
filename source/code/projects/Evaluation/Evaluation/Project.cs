using System;

class Project : Evaluation
{
  private string submissionLink;
  public string SubmissionLink
  {
    get { return submissionLink; }
    set
    {
      if (
        value.StartsWith("https://lms.augusta.edu/d2l/lms/")
      )
      {
        submissionLink = value;
      }
      else
      {
        throw new ArgumentOutOfRangeException(
          value,
          "Submission link ("
            + value
            + ") does not start with \"https://lms.augusta.edu/d2l/lms/\"."
        );
      }
    }
  }

  public Project(
    string courseP,
    double weightP,
    bool bonusP,
    string submissionLinkP
  )
    : base(courseP, weightP, bonusP)
  {
    SubmissionLink = submissionLinkP;
  }

  public override string GetContact()
  {
    return "Check the LMS submission folder.";
  }

  public override string ToString()
  {
    return base.ToString() + "\nLink:\t\t" + SubmissionLink;
  }
}
