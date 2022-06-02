using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp
{
    internal class Phonebook
    {
        public Phonebook()
        {
            Phones = new string[0];
        }
        public string[] Phones;

        public void AddPhone(string phone)
        {
            Array.Resize(ref Phones, Phones.Length + 1);

            Phones[Phones.Length - 1] = phone;
        }
    }
}
