using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp
{
    internal class Human
    {
        public string Name;
        public string Surname;
        protected byte _age;

        public byte Age
        {
            get => _age;
            set
            {
                _age = value;
            }
        }
    }
}
