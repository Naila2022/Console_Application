using System;
using System.Collections.Generic;
using Console_Application.Enum;

namespace Console_Application
{
     class Group
    {
        public string No;
        Categories Category;
        public byte Limit;
        public bool IsOnline;
        List<Group> GroupList = new List<Group>();
        public static int count = 100;

        public Group(string no, Categories catagory)
        {
            No = no;
            Category = catagory;
            IsOnline = false;
            
        }

        public List<Group> Checklist
        { get=>GroupList;
            set
            {
                if (!IsOnline)
                {
                    Limit = 15;
                    GroupList = new List<Group>(Limit);


                }
                else if (IsOnline)
                {
                    Limit = 10;
                    GroupList = new List<Group>(Limit);
                }
            }
        }

    }
}
