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
    public class Beam
    {
        public string BeamName { set; get; }
        public static int BeamId { set; get; }
        public int MyBeamId { set; get; }
        public float BeamWidth { set; get; }
        public float BeamLength { set; get; }
        public float BeamHeight { set; get; }
        //public string BeamFloorName { set; get; }
        //public float BeamXCoordinates { set; get; }
        //public float BeamYCoordinates { set; get; }
        //public float BeamZCoordinates { set; get; }
        public string BeamMaterials { set; get; }
        public float BeamVolum { set; get; }

        public Beam(IfcStore XmlFile, int index, List<IfcRectangleProfileDef> LengthIndex , List<IfcExtrudedAreaSolid> HightIndex)
        {
            BeamId++;
            MyBeamId = BeamId;
            var instaces = XmlFile.Instances;

            var elements = instaces.OfType<IfcBeam>().ToList();
            var Mat = instaces.OfType<IfcMaterial>().ToList();

            var Len = instaces.OfType<IfcRectangleProfileDef>().ToList();
            //List<int> LengthIndex = new List<int>();
            var Hig = instaces.OfType<IfcExtrudedAreaSolid>().ToList();
            //List<int> HightIndex = new List<int>();


            BeamName = elements.ToList()[index].PredefinedType.ToString() + " " + elements.ToList()[index].Name.ToString() + "Concrete Cast In Place";

            foreach (var Material in Mat)
            {
                if (Material.Name.ToString().ToUpper().Contains("CONCRETE"))
                {
                    BeamMaterials = Material.Name;
                    //materialIndex.Add(Mat.IndexOf(Material));
                }

            }
            foreach (var Length in Len)
            {
                if (BeamName.Contains(Length.ProfileName.ToString()) && !LengthIndex.Contains(Length) && Length.ProfileName!=null)
                {
                    if (BeamName.Contains(Math.Round(Length.XDim).ToString()) && BeamName.Contains(Math.Round(Length.YDim).ToString()) && Math.Round(Length.XDim) != Math.Round(Length.YDim))
                    {
                        BeamLength = (float)Length.XDim;
                        BeamWidth = (float)Length.YDim;
                        break;
                    }
                    else if (BeamName.Contains(Math.Round(Length.XDim).ToString()) && BeamName.Contains(Math.Round(Length.YDim).ToString()))
                    {
                        BeamLength = (float)Length.XDim;
                        BeamWidth = (float)Length.YDim;
                        LengthIndex.Add(Length);
                        break;

                    }
                    else
                    {
                        BeamLength = (float)Length.XDim;
                        BeamWidth = (float)Length.YDim;
                        LengthIndex.Add(Length);
                        break;

                    }
                }
                //LengthIndex.Add(Len.IndexOf(Length));

            }
            foreach (var Hight in Hig)
            {
                if (BeamName.Contains(Hight.SweptArea.ProfileName.ToString()) && !HightIndex.Contains(Hight))
                {
                    if (Hight.SweptArea.ProfileName != null)
                    {
                        if (BeamName.Contains(Hight.SweptArea.ProfileName))
                        {
                            BeamHeight = (float)Hight.Depth;
                            HightIndex.Add(Hight);
                            break;
                        }
                    }
                }
                //HightIndex.Add(Hig.IndexOf(Hight));

            }

            this.BeamVolum = BeamLength * BeamWidth * BeamHeight;

        }
    }
}
