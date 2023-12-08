using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Serialization;

namespace Tuan1314.Models
{
    public class ExrateList
    {
        [XmlElement(ElementName = "DateTime")]
        public string DateTime { get; set; }

        [XmlElement(ElementName = "Exrate")]
        public List<Exrate> Exrate { get; set; }

        [XmlElement(ElementName = "Source")]
        public string Source { get; set; }
    }
}