using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重载overload
{
    class Program
    {
        /// <summary>
        /// overload方法的重载
        /// 定义：在同一个类中，方法的名称相同，参数个数或者类型不同（返回值不参与定义讨论）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine(123);
            //Console.WriteLine("string");
            //Console.WriteLine('c');
            //Console.WriteLine(123.456);

            People p1 = new People();
            p1.Name = "Tom";
            p1.Age = 30;
            p1.XueXi();
            p1.XueXi("Tom1");
            p1.XueXi("Tom1", 18);
            Console.WriteLine($"{p1.Name} was {p1.Age} years old.");
            Console.WriteLine("---------------");

            People p2 = new People("Jake", 20);
            Console.WriteLine("---------------");
            p2.XueXi();
            p2.XueXi("Tom1");
            p2.XueXi("Tom1", 18);



        }
    }
}
