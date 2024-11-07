using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {
        // Helper string, to display more nicely
        string sep = "\n\n" + new String('*', 20) + "\n\n";

        // Evaluation test = new Evaluation(); // Should return an error if uncommented.

        Project project1 = new Project(
          "CSCI 1302",
          .05,
          false,
          "https://lms.augusta.edu/d2l/lms/dropbox/user/folder_submit_files.d2l?db=230223&grpid=0&isprv=0&bp=0&ou=474653"
        );
        Project bonusproject1 = new Project(
          "CSCI 1302",
          .05,
          true,
          "https://lms.augusta.edu/d2l/lms/dropbox/user/folder_submit_files.d2l?db=233726&grpid=0&isprv=0&bp=0&ou=474653"
        );
        Project project2 = new Project(
          "CSCI 1302",
          .05,
          false,
          "https://lms.augusta.edu/d2l/lms/dropbox/user/folder_submit_files.d2l?db=232525&grpid=0&isprv=0&bp=0&ou=474653"
        );

        Console.Write(sep);
        try
        {
            Project badUrl = new Project(
              "CSCI 1302",
              .1,
              false,
              "https://sketchy-url.com/totallyLegitProject"
            );
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
        Console.Write(sep);

        // Exam test = new Exam(); // Should return an error if uncommented.
        InClass inclassexam1 = new InClass(
          "CSCI 1302",
          .25,
          false,
          "University Hall 243"
        );
        InClass inclassexam2 = new InClass(
          "CSCI 1302",
          .25,
          false,
          null
        );
        Final finaleexam = new Final(
          "CSCI 1302",
          .4,
          false,
          ""
        );

        Console.Write(
          project1
            + sep
            + project2
            + sep
            + inclassexam1
            + sep
            + inclassexam2
            + sep
            + finaleexam
        );

        List<Evaluation> listEval1 = new List<Evaluation>()
    {
      project1,
      project2,
      inclassexam1,
      inclassexam2,
      finaleexam,
      bonusproject1,
    };

        Console.Write(sep);

        Console.Write(
          "Your list of non-bonus evaluations sums up to 100%: "
            + Evaluation.IntegrityTest(listEval1)
        );

        List<Evaluation> listEval2 = new List<Evaluation>()
    {
      project1,
      inclassexam2,
      finaleexam,
      bonusproject1,
    };

        Console.Write(sep);

        Console.Write(
          "Your list of non-bonus evaluations sums up to 100%: "
            + Evaluation.IntegrityTest(listEval2)
        );

        Console.Write(sep);

        InClass inclassexam3 = new InClass(
      "CSCI 1301",
      .50,
      false,
      null
    );
        InClass inclassexam4 = new InClass(
          "CSCI 1302",
          .50,
          false,
          null
        );
        List<Evaluation> listEval3 = new List<Evaluation>()
    {
      inclassexam3,
      inclassexam4,
    };
        try
        {
            Evaluation.IntegrityTest(listEval3);
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
        Console.Write(sep);

        /* (Bonus) 
         * Testing the export into file / 
         * import from file methods.
         */
        string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        string filePath = Path.Combine(directoryPath,
              "finaleexam.txt");
        finaleexam.ExportToFile(filePath);
        // Make sure that the file was created at
        // bin/Debug/finaleexam.txt
        Final copy = Final.ImportFromFile(filePath);
        Console.WriteLine(copy);
    }
}
