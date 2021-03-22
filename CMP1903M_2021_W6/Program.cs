using System;

namespace CMP1903M_2021_W6
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of creating a page with a title and URL
            //Test... remove this when you have seen it working
            Page p = new Page("Test Page", "http://www.lincoln.ac.uk");
            Console.WriteLine(p.Address);
            //.......

            //creating a new, empty history
            History h1 = new History();

            
        }
       
    }
}