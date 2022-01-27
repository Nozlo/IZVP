using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_4
{
    public class Cars_Class
    {
        string OwnersFirstName;
        string OwnersLastName;

        public string Number;
        string Model;
        string Color;
        
        public Cars_Class(string OFName, string OLName, string numb, string mod, string col)
        {
            this.OwnersFirstName = OFName;
            this.OwnersLastName = OLName;
            this.Number = numb;
            this.Model = mod;
            this.Color = col;
        }
    }
}
