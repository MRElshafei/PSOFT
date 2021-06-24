using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Domain
{
    public class Owner
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }


        public List<Projects> projects { get; set; }
    }
}
