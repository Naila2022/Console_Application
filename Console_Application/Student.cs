using System;
namespace Console_Application
{
    public class Student
    {
        string _id;
        public string Name;
        public string Surname;
        public byte GroupNo;
        public bool Type;
        public object ID {
            get { return _id; }
            set {; } }

        public Student(string id, string name, string surname, byte groupNo, bool type)
        {
            ID = id;
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Type = type;

        }









    }
}
