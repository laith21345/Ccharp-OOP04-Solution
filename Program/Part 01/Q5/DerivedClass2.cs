using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_01.Q5
{
    internal class DerivedClass2 : BaseClass
    {
        public new string DisplayMessage()
        {
            return "Message from DerivedClass2";
        }
    }
}
