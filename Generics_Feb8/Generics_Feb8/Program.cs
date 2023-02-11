using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Feb8
{
    class Program
    {
       //class which hold the generic value
       public class GenericExample
        {
            public void add<T>(T param1, T param2)
            {
                
                Console.WriteLine($"Parameter1:{param1}, Parameter2:{param2}"); 
            }
        }

            
        static void Main(string[] args)
        {
            GenericExample genericExample= new GenericExample();
            genericExample.add<int>(1, 2); 
            genericExample.add("hello", "world");
        }
    }
}
