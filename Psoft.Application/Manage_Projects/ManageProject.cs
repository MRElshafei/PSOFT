using Psoft.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xbim.Ifc;
using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.SharedBldgElements;

namespace Psoft.Application.Manage_Projects
{
    public class ManageProject : IManageProject
    {
        public List<Column> InitializeColumn(IfcStore XmlFile)
        {
            List<Column> ColumnList = new List<Column>();
            var colCount = XmlFile.Instances.CountOf<IfcColumn>();
            //var elements = XmlFile.Instances.OfType<IfcColumn>();
            for (int i = 0; i < colCount; i++)
            {
                Column Newcolumn = new Column(XmlFile, i);
                //Newcolumn.ColumName = elements.ToList<IfcColumn>()[i].Name;
                ColumnList.Add(Newcolumn);

            }

            return ColumnList;
        }
        public List<Beam> InitializeBeam(IfcStore XmlFile)
        {
            List<IfcRectangleProfileDef> LengthIndex = new List<IfcRectangleProfileDef>();
            List<IfcExtrudedAreaSolid> HightIndex = new List<IfcExtrudedAreaSolid>();

            List<Beam> BeamList = new List<Beam>();
            var BeamCount = XmlFile.Instances.CountOf<IfcBeam>();
            //var elements = XmlFile.Instances.OfType<IfcColumn>();
            for (int i = 0; i < BeamCount; i++)
            {
                Beam NewBeam = new Beam(XmlFile, i , LengthIndex , HightIndex);
                //Newcolumn.ColumName = elements.ToList<IfcColumn>()[i].Name;
                BeamList.Add(NewBeam);
            }

            return BeamList; 
        }

        public List<Slab> InitializeSlab(IfcStore XmlFile)
        {
            List<Slab> SlabList = new List<Slab>();
            var SlabsCount = XmlFile.Instances.CountOf<IfcSlab>();
            //var elements = XmlFile.Instances.OfType<IfcColumn>();
            for (int i = 0; i < SlabsCount; i++)
            {

                Slab NewSlab = new Slab (XmlFile, i);
                
                SlabList.Add(NewSlab);

            }
            return SlabList;
        }


        public List<Wall> InitializeWall(IfcStore XmlFile)
        {
            List<Wall> Walls = new List<Wall>();

            var products = XmlFile.Instances.OfType<IIfcWallStandardCase>();
            var matirial = XmlFile.Instances.OfType<IIfcMaterial>().ToList();
            foreach (var product in products)
            {
                var wall = product.Representation.Representations;
                var act_wall = (IIfcShapeRepresentation)wall[1];
                var depth = (IIfcExtrudedAreaSolid)act_wall.Items.FirstOrDefault();
                var width_thicknes = (IIfcRectangleProfileDef)(((IIfcExtrudedAreaSolid)act_wall.Items.FirstOrDefault()).SweptArea);
                Wall wal = new Wall();
                
                    wal.WallName = product.IsTypedBy.FirstOrDefault().RelatingType.Name; 
                    wal.WallHeight = depth.Depth;
                    wal.WallLength = width_thicknes.YDim;
                    wal.WallWidth = width_thicknes.XDim;
                   
                    wal.WallVolum = wal.WallHeight * wal.WallLength * wal.WallWidth;
                    Walls.Add(wal);
              

            }
            return Walls;
        }
    }
}
