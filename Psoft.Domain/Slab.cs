using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Ifc;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;


namespace Psoft.Domain
{
    public class Slab
    {

        public string SlabName { set; get; }
        public int SlabId { set; get; }
        public float SlabWidth { set; get; }
        public float SlabLength { set; get; }
        public float SlabHeight { set; get; }

        public string SlabMaterial { set; get; }
        public float Slabvolume
        {
            set; get;

        }

        public Slab(IfcStore XmlFile, int index)


        {

               
      
            var slab = XmlFile.Instances.OfType<IIfcSlab>().ToList();
            var Mat = XmlFile.Instances.OfType<IIfcMaterial>().ToList();
            //this.SlabName = (slab.ElementAt(index).IsDefinedBy.First().RelatingPropertyDefinition.PropertySetDefinitions.First() as IIfcPropertySingleValue).NominalValue.UnderlyingSystemType.Name;


            this.SlabMaterial = (Mat.ElementAt(index).Name);

            this.SlabId = index;
          
           this.SlabHeight= (float)(slab.ElementAt(index).Representation.Representations.First().Items.First() as IIfcExtrudedAreaSolid).Depth;
            
           var Section = (slab.ElementAt(index).Representation.Representations.First().Items.First() as IIfcExtrudedAreaSolid).SweptArea as IIfcRectangleProfileDef;

            this.SlabLength = (float)Section.XDim;
            this.SlabWidth = (float)Section.YDim;

            this.SlabName = Section.ProfileName;
            this.Slabvolume = (float) (SlabHeight * SlabWidth * SlabLength) / 1000000000;




            //foreach (var Slab in slab)
            //{
            //    var Thickness = (Slab.Representation.Representations.First().Items.First() as IIfcExtrudedAreaSolid).Depth;


            //   var Section = (Slab.Representation.Representations.First().Items.First() as IIfcExtrudedAreaSolid).SweptArea as IIfcRectangleProfileDef;
            //    this. Slabvolume = (Thickness * Section.XDim * Section.YDim) / 1000000000;

            //    ///Console.WriteLine("volume = " + Volume + " m3");
            //}




        }
    }
}
