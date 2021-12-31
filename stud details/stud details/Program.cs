using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud_details
{
    class Program
    {
        static void Main(string[] args)
        {
            student sobj = new student(2001, "chandana", "c#",1000);
            student pobj = new student(2002, "charitha", "asp.net",500);
            sobj.Payment(50);
            pobj.Payment(200);
            sobj.print();
            Console.WriteLine("\n");
            pobj.print();
            Console.ReadKey();
        }

    }
    class student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int feepaid { get; set; }

        public double Dueamount
        {
            get
            {
                return Totalfee - feepaid;
            }

        }
        public double Totalfee
        {
            get
            {
                if (Course.ToLower() == "c#")
                {
                    double n = 2000 + (2000 * 0.123);
                    return n;
                }
                else if (Course.ToLower() == "asp.net")
                {
                    double n = 3000 + (3000 * 0.123);
                    return n;
                }
                return 0;
            }
        }

        public student(int rollno, string name, string course,int feepaid)
        {
            Rollno = rollno;
            Name = name;
            Course = course;
            this.feepaid = feepaid;
        }
        public void Payment(int amount)
        {
             feepaid+=amount;
        }
        public class Tax
        {
            public double servicetax { get; set; }
            public double Dueamount { get; set; }
            public double Totalfee
            {
                get
                {
                    return Dueamount = Dueamount * servicetax;
                }
            }
            public Tax()
            {
                servicetax = 0.123;
            }
        }
        public void print()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Rollno:{Rollno}");
            Console.WriteLine($"course:{Course}");
            Console.WriteLine($"Totalfee:{Totalfee}");
            Console.WriteLine($"feepaid:{feepaid}");
            Console.WriteLine($"Dueamount:{Dueamount}");


        }
    }
}