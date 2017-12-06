using System;
using System.Collections.Generic;


namespace StudentsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Varriables declaring

            long temp;
            int optionNumber = 0;
            int numberOfStudents;
            string name;
            long facultyNumber;
            double score;
            string wantedStudentName;
            long[] facultyNumbersArray;
            int arrayPosition;
            long min;
            double additionScore;
            double middleScore;

            // Starting sentance and number of students taker

            do
            {
                Console.WriteLine("Enter how much students you want to assign between 1 and 100: ");
                numberOfStudents = int.Parse(Console.ReadLine());
            } while (numberOfStudents > 100 || numberOfStudents < 1);

            facultyNumbersArray = new long[numberOfStudents];

            // List for students

            List<Student> Students = new List<Student>();

            // Enetering the students logic

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter student name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter faculty number: ");
                facultyNumber = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter student score: ");
                score = double.Parse(Console.ReadLine());

                Student student = new Student(name, facultyNumber, score);
                Students.Add(student);
            }

            Console.WriteLine("Choose option to continue: ");
            Console.WriteLine("1 ---> Exellent students in course." +
                "\n2 ---> Score for student by entering the name." +
                "\n3 ---> The name of student with lowest faculty number." +
                "\n4 ---> The middle score of the course." +
                "\n5 ---> Ascending faculty number.");

            optionNumber = int.Parse(Console.ReadLine());

            switch (optionNumber)
            {
                // Logic for printing exellent students

                case 1:
                    foreach (var student in Students)
                    {
                        student.ExellentCatcher(student.Score);
                    }
                    break;

                    // Logic for printing score for students by name

                case 2:
                    Console.WriteLine("Enter the student name: ");
                    wantedStudentName = Console.ReadLine();
                    foreach (var student in Students)
                    {
                        if (student.Name == wantedStudentName)
                        {
                            Console.WriteLine($"{student.Name} have score = {student.Score}.");
                            break;
                        }
                    }                    
                    break;

                    // Logic for printing the lowest faculty number

                case 3:

                    arrayPosition = 0;

                    foreach (var student in Students)
                    {
                        facultyNumbersArray[arrayPosition] = student.FacultyNumber;
                        arrayPosition++;
                    }
                    min = 0;

                    for (int i = 1; i < facultyNumbersArray.Length; i++)
                    {
                        if (facultyNumbersArray[i] < facultyNumbersArray[min])
                        {
                            min = i;
                        }
                    }
                    foreach (var student in Students)
                    {
                        if (facultyNumbersArray[min] == student.FacultyNumber)
                        {
                            Console.WriteLine($"{student.Name} has the lowest faculty number {student.FacultyNumber}.");
                        }
                    }          
                    break;

                    // Logic for printing the middle score

                case 4:


                    additionScore = 0d;

                    foreach (var student in Students)
                    {
                        additionScore += student.Score;
                    }
                    middleScore = additionScore / numberOfStudents;
                    Console.WriteLine($"The middle score of the course is {middleScore:F2}.");
                    break;

                    // Exception handler

                default:
                    Console.WriteLine("Enter number between 1 and 4 !!!");
                    break;

            }



            


        }
    }
}
