using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Job myJob = new Job();
        myJob.displayJobDetails();
        Job myJob2 = new Job();
        myJob2.displayJobDetails();

        Resume myResume = new Resume();
        myResume.jobs.Add(myJob);
        myResume.jobs.Add(myJob2);
        myResume.displayResume();
        

        
        

        
    }

    
}