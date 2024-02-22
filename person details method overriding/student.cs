using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_details_method_overriding
{
    public  class student:person
    {
        public int studentid;
        public override void input()
        {
            base.input();
            Console.WriteLine("Please Enter Student Id:");
            studentid =Convert.ToInt32(Console.ReadLine());
            
        }
        public override void output() 
        {
            base.output();
            Console.WriteLine("Your Student Id Is:"+studentid);

        }
    }
}
