using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_string
{ 
    class Program
    { 
   
        static void Main(string[] args)
        {
            StringReverse obj = new StringReverse();
            Console.WriteLine(obj.Reverse( "hello world"));
            Countoccurence c = new Countoccurence();
            Console.WriteLine(c.occurance("hello world"));
            Reversewords s = new Reversewords();
            Console.WriteLine(s.word("welcome to puttur"));
            reverseeachword each = new reverseeachword();
            Console.WriteLine(each.eachword("welcome to puttur"));
            substring sub = new substring();
            Console.WriteLine(sub.possible("efgh"));
            largest e = new largest();
            Console.WriteLine(e.secondlargest( new int[]{ 1, 4, 3, 5, 6 }));
            
            Console.ReadLine();
        }
    }
}


        





