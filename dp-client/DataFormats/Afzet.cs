using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	public class Afzet
	{
		[XmlElement("jaar")]
		public int Jaar { get; set; }
		[XmlElement("lpg")]
		public int Lpg { get; set; }
		[XmlElement("euro95")]
		public int Euro95 { get; set; }
		[XmlElement("diesel")]
		public int Diesel { get; set; }
	}
}
