using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace CultureInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);


            //Console.WriteLine("{0,-53}{1}", "CULTURE", "SPECIFIC CULTURE");

            //// Get each neutral culture in the .NET Framework.
            //CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            //// Sort the returned array by name.
            ////Array.Sort<CultureInfo>(cultures, new NamePropertyComparer<CultureInfo>());

            //// Determine the specific culture associated with each neutral culture. 
            //foreach (var culture in cultures)
            //{
            //    Console.Write("{0,-12} {1,-40}", culture.Name, culture.EnglishName);
            //    try
            //    {
            //        Console.WriteLine("{0}", CultureInfo.CreateSpecificCulture(culture.Name).Name);
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("(no associated specific culture)");
            //    }
            //} 

            Console.ReadKey();
        }
    }
}
