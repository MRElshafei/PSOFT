using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Application.Manage_BOQ
{
    public class BOQDTO
    {

        public int ID { get; set; }
        public string Item_Description { get; set; }
        public string Unit { get; set; }
        public string Unit_Price { get; set; }
        public double Quantity { get; set; }

    }

    public class BOQDTOList
    {
        public List<BOQDTO> BOQs { get; set; }
        public int ItemsCount { get; set; }

    }


}
