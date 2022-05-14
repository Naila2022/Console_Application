using System;
using System.Collections.Generic;

namespace Console_Application
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string GroupNo;
        public bool Guaranty;

        List<Student> StudentList = new List<Student>();

        public Student(int id, string name, string surname, string groupNo, bool guaranty)
        {
            Id = id;
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Guaranty = guaranty;

        }

        public void StudentInfo()
        {
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Name: {student.Name} \n  Surname: {student.Surname} \n Id: {student.GroupNo} \n Guaranty: {student.Guaranty}");
            }
                
            
        }









    }
}
