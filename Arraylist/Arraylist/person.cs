using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Arraylist
{
    class person
    {
       public void data()
        {
            object name1 = "juan";
            object name2 = "sara";
            object name3 = "Carlos";
            ArrayList personlist = new ArrayList();
            personlist.Add(name1);
            personlist.Add(name2);
            personlist.Add(name3);
            for(int i=0;i<personlist.Count;i++)
            {
                Console.WriteLine(personlist[i]);
            }
            object age1 = 26;
            object age2 = 31;
            object age3 = 23;
            ArrayList personage = new ArrayList();
            personage.Add(26);
            personage.Add(31);
            personage.Add(23);
            
            personlist.AddRange(personage);
            Console.WriteLine((string)personlist[0] + - + (int)personage[0]);
            Console.WriteLine((string)personlist[1] + - + (int)personage[1]);
            Console.WriteLine((string)personlist[2] + - + (int)personage[2]);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
