using System;
using ExamMenegementSystem;

AllList.Exams.Add(new Exam("HTML", new DateTime(2022, 10, 05)));
AllList.Exams.Add(new Exam("C#", new DateTime(2023, 05, 07)));
AllList.Exams.Add(new Exam("Js", new DateTime(2023, 05, 17)));
AllList.Exams.Add(new Exam("Java", new DateTime(2023, 05, 27)));


string UserInput = null;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Select one of the below!");
    Console.WriteLine("1. Create Group and Group List");
    Console.WriteLine("2. Select Group Id and Add Student");
    Console.WriteLine("3. Select Student Id and Add Exam");
    Console.WriteLine("4. Exit");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(">>>>");
    Console.ForegroundColor = ConsoleColor.White;
    UserInput = Console.ReadLine();
    if (Utilities.Check(UserInput))
    {
        switch (UserInput)
        {
            case "1":
                Group.AddGroup();
                break;
            case "2":
                Student.AddStudent();
                break;
            case "3":
                Group.SelectedStudentAddExam();
                break;
            case "4":
                break;
            default:
                break;
        }
    }


} while (UserInput != "4");

