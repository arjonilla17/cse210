using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
      job1._company = "Jani-King";
      job1._jobTitle = "Janitor";
      job1._startYear = 2006;
      job1._endYear = 2020;

      Job job2 = new Job();
      job2._company = "USL";
      job2._jobTitle = "Data Analyst";
      job2._startYear = 2020;
      job2._endYear = 2022;

      Resume ResumeList = new Resume();
      ResumeList._name = "Carlos Arjonilla";

      ResumeList._jobs.Add(job1);
      ResumeList._jobs.Add(job2);

      ResumeList.DisplayResume();

    }
}