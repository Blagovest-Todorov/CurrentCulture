using System;

namespace _05.FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);
            //Showing the current culture
            Console.WriteLine(DateTime.Now);

            //
            //now changing the current culture//setting a new culture settings
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("bg-BG"); //as we create new object of a class
            Console.WriteLine(DateTime.Now);


            
        }
    }
}
