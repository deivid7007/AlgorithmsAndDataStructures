using System;


namespace StudentsSystem
{
    class Student
    {
        // Constructor

        public Student(string Name, long FacultyNumber, double Score)
        {
            this.Name = Name;
            this.FacultyNumber = FacultyNumber;
            this.Score = Score;
        }

        // Properties

        public string Name { get; set; }
        public long FacultyNumber { get; set; }
        public double Score { get; set; }



        

        // Method for finding exellent score 

        public void ExellentCatcher(double Score)
        {
            if (Score >= 5.50 && Score <= 6.00)
            {
                Console.WriteLine($"{Name} with faculty number {FacultyNumber} have score = {Score:F2}.");
            }
        }

        // Method for finding score by name

        public void ScoreFinderByName(string Name)
        {
            Console.WriteLine($"{Name} have score: {Score:F2}");
        }

       
      



    }
}
