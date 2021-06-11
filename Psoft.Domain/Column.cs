using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xbim.Ifc;
using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.MaterialResource;
using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.SharedBldgElements;

namespace Psoft.Domain
{
    public class Column
    {
        public string ColumName { set; get; }
        public static int columId { set; get; }
        public int MyColumId { set; get; }
        public float ColumWidth { set; get; }
        public float ColumLength { set; get; }
        public float ColumHeight { set; get; }
        //public string ColumFloorName { set; get; }
        //public float ColumXCoordinates { set; get; }
        //public float ColumYCoordinates { set; get; }
        //public float ColumZCoordinates { set; get; }
        public string ColumMaterials { set; get; }
        public float ColumVolum { set; get; }

        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }


        public Column(IfcStore XmlFile, int index)
        {
            columId++;
            MyColumId = columId;
            var instaces = XmlFile.Instances;

            var elements = instaces.OfType<IfcColumn>();
            var Mat = instaces.OfType<IfcMaterial>();
            var Len = instaces.OfType<IfcRectangleProfileDef>();
            var Hig = instaces.OfType<IfcExtrudedAreaSolid>();


            ColumName = elements.ToList<IfcColumn>()[index].PredefinedType.ToString() + " " + elements.ToList<IfcColumn>()[index].ObjectType.ToString() + "Concrete Cast In Place";

            foreach (var Material in Mat)
            {
                if (Material.Name.ToString().ToUpper().Contains("CONCRETE"))
                {
                    ColumMaterials = Material.Name;
                }
            }
            foreach (var Length in Len)
            {
                if (ColumName.Contains(Length.XDim.ToString()) && ColumName.Contains(Length.YDim.ToString()) && Length.XDim != Length.YDim)
                {
                    ColumLength = (float)Length.XDim;
                    ColumWidth = (float)Length.YDim;
                    break;
                }
                else if (ColumName.Contains(Length.XDim.ToString()) && ColumName.Contains(Length.YDim.ToString()))
                {
                    ColumLength = (float)Length.XDim;
                    ColumWidth = (float)Length.YDim;
                }
            }
            foreach (var Hight in Hig)
            {
                if (Hight.SweptArea.ProfileName != null)
                {
                    if (ColumName.Contains(Hight.SweptArea.ProfileName))
                    {
                        ColumHeight = (float)Hight.Depth;
                    }
                }

            }

            this.ColumVolum = ColumLength * ColumWidth * ColumHeight;
            this.StartDate = new DateTime(2021, 1, 1);
            this.EndDate = new DateTime(2021, 1, 7);

        }
    }
}
