using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;

namespace Psoft.Domain
{
    public class Building
    {
        public IfcStore Xml;
        public IfcStore XmlFile
        {
            set { this.XmlFile = Xml; }
            get { return this.Xml; }
        }
        public Building(string Path)
        {
            //open STEP21 file
            var stepModel = IfcStore.Open(Path);

            var newPath = Path.Remove(Path.Length - 3);
            //save as XML
            stepModel.SaveAs(newPath + "ifcxml");

            //open XML file
            IfcStore xmlModel = IfcStore.Open(newPath + "ifcxml");
            Xml = xmlModel;
        }

        public Building()
        {
        }

        public void getWEXBIM(string filePath)
        {
          string fileName = filePath;
            using (var model = IfcStore.Open(fileName))
            {
                var context = new Xbim3DModelContext(model);
                context.CreateContext();

                var wexBimFilename = Path.ChangeExtension(fileName, "wexBIM");
                using (var wexBiMfile = File.Create(wexBimFilename))
                {
                    using (var wexBimBinaryWriter = new BinaryWriter(wexBiMfile))
                    {
                        model.SaveAsWexBim(wexBimBinaryWriter);
                        
                        wexBimBinaryWriter.Close();
                    }
                    wexBiMfile.Close();

                }
            }

        }
        public string getWEXBIMPath(string filePath)
        {
            string fileName = filePath;
            var model = IfcStore.Open(fileName);
            var context = new Xbim3DModelContext(model);
            context.CreateContext();
            var wexBimFilename = Path.ChangeExtension(fileName, "wexBIM");
            return wexBimFilename;
        }
    }
}
