using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshworKhadka.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class Attributes: Attribute
    {

        private string name;
        private string address;

        public Attributes(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName { get { return name; } set { name = value; } }

        public string getAddress { get { return address; } set { address = value; } }

    }
}
