using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Domain
{
    public class Projects
    {


        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string Location { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Currency { get; set; }
        public string Consultant { get; set; }
        public string Owner { get; set; }
        public string Category { get; set; }
        public int ProjectTeam { get; set; }
        public List<BOQ> BOQ { get; set; }


    }
}
