using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_5
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public string course;
        public string department;
        public string group;
        public string city;
        public string age;

        public Student()
        {

        }
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course.ToString();
            this.age = age.ToString() ;
            this.group = group.ToString();
            this.city = city;
        }
    }
}
