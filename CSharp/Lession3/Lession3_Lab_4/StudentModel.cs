using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3_Lab_4
{
    internal class StudentModel
    {
        List<Student> students;

        public StudentModel()
        {
            this.students = new List<Student>
            {
                new Student() {Id=1,Name="Dung",Age=20},
                new Student() {Id=2,Name="Nam",Age=22},
                new Student() {Id=3,Name="Ga",Age=10},
                new Student() {Id=4,Name="Lon",Age=18},
                new Student() {Id=5,Name="Cho",Age=11},
            };
        }

        #region

        public List<Student> GetStudents()
        {
            return this.students;
        }

        public Student GetStudents(int id)
        {
            Student st = null;
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    st = student;
                }
            }
            return st;
        }

        public List<Student> GetStudents(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Age >= x && student.Age <= y)
                {
                    result.Add(student);
                }
            }

            return result;
        }

        #endregion
    }
}

