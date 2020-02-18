using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAllocation
{
    class Program
    {
        struct Student
        {
            public int rownumber;
            public string Name;
        }
        static void Main(string[] args)
        {
            Myclass.Mymethod();
             Myclass myclass = new Myclass();
             myclass.Name = "Mercedes Benz";
             Myclass myclass1;
             myclass1 = myclass;
             myclass1.Name = myclass.Name;
            myclass1.Model = 45;
            myclass.Model = 56;
            Console.WriteLine(myclass.Model);
             ////////////////////////////////////////////
            Student s = new Student();
            s.rownumber = 4;
            s.Name = "Oliver KipKemei";
            Console.WriteLine(" Student is {0} Row Number {1} ",s.Name,s.rownumber);
            

            Console.Read();
        }
    }
    class Myclass
    {
        public int Model { get; set; }
        public string Name { get; set; }
        public static void Mymethod()
        {
            Console.WriteLine("Skinny jeans");
        }
    }
}
