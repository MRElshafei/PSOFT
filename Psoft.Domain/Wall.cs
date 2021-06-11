using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Domain
{
    public class Wall
    {
        public static int WallId { set; get; }
        public string WallName { set; get; }
        public double WallWidth { set; get; }
        public double WallLength { set; get; }
        public double WallHeight { set; get; }
        public string WallMaterials { set; get; }
        public double WallVolum { set; get; }

    }
}
