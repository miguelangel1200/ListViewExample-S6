using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Contact: List<Employee>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        public Contact(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
        public static IList<Contact> All { get; set; }
    }
}
