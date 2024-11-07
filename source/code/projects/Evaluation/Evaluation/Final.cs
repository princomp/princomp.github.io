using System.IO;
using System;

class Final : Exam
{
    public string Room { get; set; }
    public Final(string courseP, double weightP, bool bonusP, string roomP) : base(courseP, weightP, bonusP)
    {
        Room = roomP;
    }
    public override string GetRoom()
    {
        string returnRoom;
        if (string.IsNullOrEmpty(Room))
        {
            returnRoom = "Check the Registrar's exam schedules for " + Course + ".";
        }
        else
        {
            returnRoom = Room;
        }
        return returnRoom;
    }

    public void ExportToFile(string filePathP)
    {

        if (File.Exists(filePathP))
        {
            Console.WriteLine("File already exists, aborting.");
        }
        else
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePathP);
                sw.WriteLine("Final");
                sw.WriteLine(Course);
                sw.WriteLine(Weight);
                sw.WriteLine(Bonus);
                sw.WriteLine(Room);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }

    public static Final ImportFromFile(string filePathP)
    {
        Final copy = null;
        if (!File.Exists(filePathP))
        {
            throw new ArgumentException("File does not exist, aborting.");
        }

        try
        {
            StreamReader sr = new StreamReader(filePathP);
            if (sr.ReadLine() != "Final")
            {
                throw new ArgumentException("File not correctly formatted.");
            }

            string course = sr.ReadLine();
            double weight = double.Parse(sr.ReadLine());
            bool bonus = bool.Parse(sr.ReadLine());
            string room = sr.ReadLine();
            copy = new Final(course, weight, bonus, room);
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        return copy;


    }

}