using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMenegementSystem
{
    public class Student
    {
        private static int StudentId = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Group Group { get; set; }
        public List<Exam> Exams { get; set; }

        public Student(string fullName, string phone, string email)
        {
            StudentId++;
            Id = StudentId;
            FullName = fullName;
            Phone = phone;
            Email = email;
            Exams = new List<Exam>();
        }
        public static Student AddStudent()
        {
            if (AllList.Groups.Count > 0)
            {
                foreach (var item in AllList.Groups)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Group Name: " + item.Name + "Group Id: " + item.Id);
                }
            Start:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Ged qrup Id sinin  sec!!");
                string groupId = Console.ReadLine();

                if (Utilities.Check(groupId))
                {
                    Group selectedGroup = null;
                    bool corredId = false;

                    foreach (var item in AllList.Groups)
                    {
                        if (item.Id == Convert.ToInt32(groupId))
                        {
                            selectedGroup = item;
                            corredId = true;
                            break; // bitsin deye   
                        }
                    }
                    if (corredId)
                    {
                        Console.Write("Please,  enter fullname: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Please enter Phone: ");
                        string studentPhone = Console.ReadLine();
                        Console.Write("Please enter Email: ");
                        string studentEmail = Console.ReadLine();
  
  
                        Student newStudent = new(studentName, studentPhone, studentEmail);
                        AllList.Students.Add(newStudent);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Student creaated sucsessfully!");
                        return newStudent;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Qaqa duz yaz qrup idsini ");
                        goto Start;
                    }


                }
                else
                {
                    goto Start;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Ged birinci grup yarad qardas!!!");
                Group.AddGroup();
                return null;
            }
        }
    }
}
