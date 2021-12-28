using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重载overload
{
    public class People
    {
        ///class的overload
        public People()
        {

        }
        public string Name;
        public int Age;

        public People(string name,int age)
        {
            Console.WriteLine($"my name is {name},and {age} years old.");
        }

        public void XueXi()
        {
            Console.WriteLine("he is studing.");
        }

        public void XueXi(string name)
        {
            Console.WriteLine($"{name} is studing.");
        }

        public void XueXi(string name,int age)
        {
            Console.WriteLine($"{name} is {age} years old this year, and {name} is studing.");
        }
       
    }
}
