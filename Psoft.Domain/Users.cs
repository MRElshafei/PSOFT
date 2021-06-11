using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Domain
{
    public class Users
    {

        public int ID { get; set; }

        public string Name { get; set; }


        public List<Projects> projects { get; set; }

    }
}
