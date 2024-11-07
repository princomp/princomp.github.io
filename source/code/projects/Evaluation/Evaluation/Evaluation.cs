using System.Collections.Generic;
using System;

abstract class Evaluation
{
    public string Course;
    public double Weight { get; set; }
    public bool Bonus { get; set; }
    public Evaluation(string courseP, double weightP, bool bonusP)
    {
        Course = courseP;
        Weight = weightP;
        Bonus = bonusP;
    }
    public abstract string GetContact();

    public override string ToString()
    {
        return "Course:\t\t" + Course + $"\nWeight:\t\t{Weight:P}" + "\nContact:\t" + GetContact();
    }
    /// smallest double such that 1.0+EpsilonD != 1.0
    /// Courtesy of https://stackoverflow.com/a/46682754
    private const double EpsilonD = 2.2204460492503131e-016;

    public static bool IntegrityTest(List<Evaluation> evallistP)
    {
        string course = evallistP[0].Course;
        double tot = 0;
        foreach (Evaluation eval in evallistP)
        {
            if (eval.Course != course)
            {
                throw new ArgumentException("Evaluations are for different classes.");
            }
            if (!eval.Bonus) { tot += eval.Weight; }
        }
        return Math.Abs(tot - 1.0) < EpsilonD;
        // Would also be acceptable:
        // return tot == 1.0;
        // but some IDE complains that
        // there may be rounding mistake.
    }
}