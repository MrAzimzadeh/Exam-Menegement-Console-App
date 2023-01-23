using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMenegementSystem
{
    public class Group
    {
        private static int GroupId = 0;
        public int Id { get; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name)
        {
            GroupId++;
            Id = GroupId;
            Name = name;
            Students = new List<Student>();
        }

        public static void AddGroup()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Please enter group Name ");
            string groupName = Console.ReadLine();
            Group group = new(groupName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Group creaated sucsessfully!");
            Console.ForegroundColor = ConsoleColor.White;
            AllList.Groups.Add(group);
            foreach (var item in AllList.Groups)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Group Name: " + item.Name);
            }

        }

        private static void ShowExam(Student student)
        {
            Exam selectedExam = null; //imtahanlara baxacaq
            bool correctName = false; // 

        Exam:
            System.Console.WriteLine("Please enter exam name ");
            string examName = Console.ReadLine();
            foreach (var item in AllList.Exams) // imtahan adlari allistin icerisinde varsa  dayancaq 
            {
                if (item.ExamName == examName)
                {
                    selectedExam = item;
                    correctName = true;
                    break;
                }
            }
            if (correctName)
            {
                selectedExam.Students.Add(student);
                student.Exams.Add(selectedExam);

                foreach (var item in selectedExam.Students)
                {
                    System.Console.WriteLine($"Exam {selectedExam.ExamName} added {item.FullName}");
                }

            }
            else // getsin yeni bir imtahan yaratsin 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Dogru imtahani yaz!!!");
                Console.ForegroundColor = ConsoleColor.White;
                goto Exam;

            }
        }

        public static void SelectedStudentAddExam()
        {
            if (AllList.Students.Count() > 0)
            {


                foreach (var item in AllList.Students)
                {
                    System.Console.WriteLine($"Student id : {item.Id} Student Name: {item.FullName}");
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.Write("Please enter Student Id : ");
                Console.ForegroundColor = ConsoleColor.White;

            StartExam:
                string selectedId = Console.ReadLine();
                bool corredId = false;
                Student selectedStuddent = null;

                if (Utilities.Check(selectedId))
                {
                    int studentIdInt = Convert.ToInt32(selectedId);

                    foreach (var item in AllList.Students)
                    {
                        if (item.Id == studentIdInt)
                        {
                            selectedStuddent = item;
                            corredId = true;
                            break;
                        }
                    }
                    if (corredId)
                    {
                        foreach (var item in AllList.Exams)
                        {
                            System.Console.WriteLine($"Exam Name : {item.ExamName}; Exam Date: {item.ExamDate}");
                        }
                        ShowExam(selectedStuddent);
                    }
                    else
                    {
                        System.Console.WriteLine("Warning, Student id does not exit!");
                        goto StartExam;
                    }

                }

            }
            else
            {
                System.Console.WriteLine("Please,  Enter student!");
                Student.AddStudent();
            }
        }

    }

}