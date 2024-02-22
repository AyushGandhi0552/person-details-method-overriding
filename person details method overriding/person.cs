using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace person_details_method_overriding
{
    public class person
    {
        public string name;
        public string address;
        public string city;
        public string state;
        public int postalCode;
        public virtual void input()
        {
            Console.WriteLine("Please Enter Your Name:");
            name=Console.ReadLine();
            Console.WriteLine("Please Enter Your Address:");
            address=Console.ReadLine();
            Console.WriteLine("Please Enter Your City:");
            city=Console.ReadLine();
            Console.WriteLine("Please Enter Your State Name:");
            state=Console.ReadLine();
            Console.WriteLine("Please Enter Your PostalCode:");
            postalCode=Convert.ToInt32(Console.ReadLine());
        }
        public virtual void output() 
        {
            Console.WriteLine("Your Name is:"+name);
            Console.WriteLine("Your address is:"+address);
            Console.WriteLine("Your City is:"+city);
            Console.WriteLine("Your State is:"+state);
            Console.WriteLine("Your PostalCode is:" + postalCode);
        }
    }
}
