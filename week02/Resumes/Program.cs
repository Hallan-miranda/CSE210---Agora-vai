using System;

class Program
{
    static void Main(string[] args)
    {
        
        Resume resume = new Resume();

        resume._name = "Hallan Miranda";

        Job job1 = new Job();
        job1._company = "ABIJSUD";
        job1._jobTitle = "Admsintrative Assistent";
        job1._startYear = 2025;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._company = "Metanoe";
        job2._jobTitle = "CTO";
        job2._startYear = 2022;
        job2._endYear = 2025;


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}