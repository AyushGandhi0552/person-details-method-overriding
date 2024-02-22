using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_details_method_overriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.input();
            person.output();
            student student = new student();
            student.input();
            student.output();
            teacher teacher = new teacher();
            teacher.input();
            teacher.output();
            Admin ad=new Admin();
            ad.input();
            ad.output();

            Console.ReadKey();
        }
    }
}
