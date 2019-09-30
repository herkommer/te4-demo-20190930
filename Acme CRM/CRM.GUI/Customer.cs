using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.GUI
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool VIP { get; set; }

        public override string ToString()
        {
            //Vi skriver egen kod för vad som ska svaras på anropet ToString
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
