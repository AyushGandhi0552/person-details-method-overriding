using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_details_method_overriding
{
    public class teacher:person
    {
        public int EmployeeId;
        public override void input()
        {
            base.input();
            Console.WriteLine("Please Enter Your Employeeid:");
            EmployeeId= Convert.ToInt32(Console.ReadLine());
        }
        public override void output()
        { 
            base.output();
            Console.WriteLine("Your EmloyeeId Is:" + EmployeeId);
        }
    }
}
