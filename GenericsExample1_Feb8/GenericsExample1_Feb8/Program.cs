using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample1_Feb8
{
    class Program
    {
        public class Student
        { 
            public void print<Integer,String>(Integer param1, String param2)
            {
                Console.WriteLine($"Parameter1:{param1}, Parameter2:{param2}");
            }

            public void printOne<T>(T num1,T num2) 
            {
                int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2); 
                Console.WriteLine($"Num1:{num1}, Num2:{num2}, Sum:{sum}"); 
                Console.WriteLine(sum);

            }
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.print(1, "sunil"); 
            student.printOne(7, 4); 
            

        }
    }
}
