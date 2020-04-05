using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	public class Emissie
	{
		[XmlElement("bron")]
		public string Bron { get; set; }
		[XmlElement("jaar")]
		public int Jaar { get; set; }
		[XmlElement("nox")]
		public float Nox { get; set; }
		[XmlElement("co2")]
		public int Co2 { get; set; }
	}
}
