using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triax_Fejlrapportering
{
    public class xml
    {
        public List<string> names;
        public List<string> faults;
        public List<Products> products;
        public xml()
        {
            names = new List<string>();
            faults = new List<string>();
            products = new List<Products>();
        }
        public string startupfile = @"";

        public string ReadStartXml()
        {
            
            if (File.Exists("Startup.xml"))
            {
                XDocument doc = XDocument.Load("Startup.xml");
                foreach (XElement element in doc.Descendants("STARTUP"))
                {
                    startupfile = element.Element("LOCATION").Attribute("value").Value;
                }
            }
            else
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
                fd.AutoUpgradeEnabled = true;
                fd.AddExtension = true;
                fd.InitialDirectory = @"N:\fabrik\pta-e\TDX Workshop";
                fd.Title = "Vælg XML fil til program";
                fd.ShowDialog();
                startupfile = fd.FileName;
                XDocument doc = new XDocument(
                    new XElement("STARTUP",
                        new XElement("LOCATION",
                            new XAttribute("value", startupfile))));
                doc.Save("Startup.xml");
            }
            return startupfile;
        }
        public string endlocation = @"";
        public void ReadDataXml(string path)
        {
            int refcol=0;
            int refval=0;
            int refcompstocknr=0;
            int refstartrow=0;
            int stocknr=0;
            string modulename="";
            string diafold=@"";
            string dianame="";
            string refname="";
            string compfold=@"";
            string comptop="";
            string compbot="";            
            XDocument doc = XDocument.Load(path);
            foreach (XElement output in doc.Descendants("OUTPUTDIRECTORY"))
            {
                endlocation = output.Attribute("value").Value;
            }
            foreach (XElement element in doc.Descendants("NAMES").Elements("NAME"))
            {
                names.Add(element.Attribute("value").Value);
            }
            foreach (XElement element in doc.Descendants("FAULTS").Elements("FAULT"))
            {
                faults.Add(element.Attribute("value").Value);
            }
            foreach (XElement element in doc.Descendants("MODULES").Elements("MODULE"))
            {
                modulename = element.Attribute("value").Value;
                int.TryParse(element.Element("STOCKNUMBER").Attribute("value").Value, out stocknr);
                foreach (XElement diagram in element.Elements("DIAGRAM"))
                {
                    diafold = diagram.Element("FOLDER").Attribute("value").Value;
                    dianame = diagram.Element("FILENAME").Attribute("value").Value;
                    foreach (XElement reffile in diagram.Elements("REFFILE"))
                    {
                        refname = reffile.Element("FILENAME").Attribute("value").Value;
                        int.TryParse(reffile.Element("PLACEMENTCOLOUMN").Attribute("value").Value, out refcol);
                        int.TryParse(reffile.Element("VALUECOLOUMN").Attribute("value").Value, out refval);
                        int.TryParse(reffile.Element("COMPONENTSTOCKNUMBER").Attribute("value").Value, out refcompstocknr);
                        int.TryParse(reffile.Element("STARTROW").Attribute("value").Value, out refstartrow);
                    }
                }
                foreach (XElement component in element.Elements("COMPONENT"))
                {
                    compfold = component.Element("FOLDER").Attribute("value").Value;
                    comptop = component.Element("TOPPLACEMENT").Attribute("value").Value;
                    compbot = component.Element("BOTTOMPLACEMENT").Attribute("value").Value;
                }
                products.Add(new Products(modulename, refcol, refcompstocknr, refval, diafold, refname, dianame, compfold, comptop, stocknr, compbot, refstartrow));
            }            
        }
    }
}
