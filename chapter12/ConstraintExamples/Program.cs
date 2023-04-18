using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstraintExamples
{
    class MathUtil<T> where T: struct
    {
    }
    class ObjectUtil<T> where T: IComparable
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathUtil<int> x = new MathUtil<int>();

            ObjectUtil<int> s = new ObjectUtil<int>();




        }
    }
}
