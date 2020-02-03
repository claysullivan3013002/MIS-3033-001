using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public string name { get; set; }
        public string address { get; set; }
        public int zip { get; set; }

        public EntryForm()
        {
            name = string.Empty;
            address = string.Empty;
            zip = 0;
        }

       

        public EntryForm(string Name, string Address, int zipcode )
        {
            Name = name;
            Address = address;
            zipcode = zip;
        }
       
        public override string ToString()
        {
            return base.ToString();
            return $"Name; {name} Address: {address} Zip: {zip}";
        }
        
    }
}
