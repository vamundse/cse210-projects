using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Designer";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Marketing";
        job2._startYear = 2021;
        job2._endYear = 2025;

        Resume johnResume = new Resume();
        johnResume._name = "John Legend";
        johnResume._jobs.Add(job1);
        johnResume._jobs.Add(job2);

        johnResume.DisplayResume();
    }
}