using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp
{
    internal class Student:Human
    {
        public string GroupNo;
        public int Point;

        public byte Age
        {
            get => _age;
            set
            {
                if (value > 14 && value < 66)
                    _age = value;
            }
        }
    }
}
