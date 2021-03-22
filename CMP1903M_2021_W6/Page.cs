using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_2021_W6
{
    class Page
    {
        //auto-implemented properties
        public string Title { get; set; }
        public Uri Address { get; set; }

        //constructor
        public Page(string t, string a)
        {
            Title = t;
            Address = new Uri(a);
        }

        
    }
}
