using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_string
{
    class StringReverse
    {
        public string Reverse(string str)
        {
            string reverseString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }
            return reverseString;
        }
    }
    class Countoccurence
    {
        public string occurance(string str)
        {
            while (str.Length>0)
            {
                Console.Write(str[0] + "-");
                int count = 0;
                for (int i=0;i<str.Length;i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            return "";
        }
    }
    class Reversewords
    {
        public string word(string str)
        {
            int first;
            int last;
            string reversestring = string.Empty;
            last = str.Length - 1;
            for (int i=str.Length-1;i>=0;i--)
            {
                if (str[i]==' ' || i==0)
                {
                    if(i==0)
                    {
                        first = 0;
                    }
                    else
                    {
                        first = i + 1;
                    }
                    for (int j=first;j<=last;j++)
                    {
                        Console.Write(str[j]);
                    }
                    last = i - 1;
                    Console.Write('\t');
                }
            }
            return "";
        }
        

    }
    class reverseeachword
    {
        public string eachword(string str)
        {
            int start;
            int end;
            string rev = "";
            end = str.Length - 1;
            for (int i=end;i>=0;i--)
            {
                if(str[i]==' ' || i==0)
                {
                    if(i==0)
                    {
                        start = 0;
                    }
                    else
                    {
                        start = i + 1;
                    }
                    for(int j = start;j<=end;j++)
                    {
                        while(end>0)
                        {
                            rev = rev + str[end];
                            end--;
                        }
                    }
                    end = i - 1;
                }
            }
            Console.WriteLine("\n" + rev);
            return "";
        }
    }
    class substring
    {
        public string possible(string str)
        {
            for (int i=1;i<str.Length;i++)
            {
                for (int start =0;start<=str.Length-i;start++)
                {
                    string substr = str.Substring(start, i);
                    Console.WriteLine(substr);
                }
            }
            return "";
        }
    }
    class largest
    {
        public int secondlargest(int[]arr)
        {
            int first = int.MinValue, second = int.MinValue;
            foreach(int i in arr)
            {
                if(i>first)
                {
                    second = first;
                    first = i;
                }
                else if(i>second)
                {
                    second = i;
                }
            }
            Console.WriteLine("second largest" + second);
            return second;
        }
    }
    
}
