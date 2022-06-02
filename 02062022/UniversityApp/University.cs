using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp
{
    internal class University
    {

        public University(int stdLimit)
        {
            StudentLimit = stdLimit;
        }
        private Student[] _students = new Student[0];
        public int StudentLimit;

        public Student[] Students
        {
            get => _students;
        }

        public void AddStudent(Student std)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = std;
            }
        }
    }
}
