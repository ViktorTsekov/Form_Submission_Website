using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Former.Models
{
    public class HomeModelView
    {
        public HomeModelView()
        {
                
        }
        public HomeModelView(List<int> numberArray, string myString)
        {
            NumberArray = numberArray;
            MyString = myString;
        }

        public List<int> NumberArray { get; set; } = new List<int>();
        public string MyString { get; set; }
    }
}
