using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListVsList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Life without generics");
            // cast to String
            String s1 = (String) arrayList[0];
            Console.WriteLine(s1.ToUpper());
    
            List<string> list = new List<string>();
            list.Add("Life with generics");
            // no type casting necessary
            String s2 = list[0];
            Console.WriteLine(s2.ToUpper());
            Console.ReadKey();
       }
    }
}
