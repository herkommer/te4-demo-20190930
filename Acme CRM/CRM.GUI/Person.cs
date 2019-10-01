using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.GUI
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            //Vi skriver egen kod för vad som ska svaras på anropet ToString
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}