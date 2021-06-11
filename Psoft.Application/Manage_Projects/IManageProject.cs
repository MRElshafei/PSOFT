using Psoft.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Ifc;

namespace Psoft.Application.Manage_Projects
{
    public interface IManageProject
    {
        public List<Column> InitializeColumn(IfcStore XmlFile);
        public List<Slab> InitializeSlab(IfcStore XmlFile);
        public List<Beam> InitializeBeam(IfcStore XmlFile);
        public List<Wall> InitializeWall(IfcStore XmlFile);
    }
}
