using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No6
{
    public class Student
    {
        private int rollno;
        private string name;
        private int sub1, sub2, sub3, total;
        private double percentage;

        public Student()
        {
            rollno = 13;
            name = "kajal";
            sub1 = 75;
            sub2 = 80;
            sub3 = 85;
        }
        public Student(int a, string b, int c, int d, int e)
        {
            this.rollno = a;
            this.name = b;
            this.sub1 = c;
            this.sub2 = d;
            this.sub3 = e;
        }

        public void Calculate()
        {
            total = sub1 + sub2 + sub3;
            percentage = (double)total / 3;
        }
        public string GetValues()
        {
            return $"Student:rollno={rollno}, name={name}, total is:{total},percentage is:{percentage} ";
        }

    }
}

