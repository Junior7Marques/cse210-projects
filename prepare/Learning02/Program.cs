using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Administrative Assistant";
        job1._company = "Eldorado Mall";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Administrative Assistant";
        job2._company = "Oáz.co";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Edilson Júnior";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}