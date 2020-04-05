using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	public class Pompprijs
	{
		[XmlElement("jaar")]
		public int Jaar { get; set; }
		[XmlElement("euro95")]
		public float Euro95 { get; set; }
		[XmlElement("diesel")]
		public float Diesel { get; set; }
		[XmlElement("lpg")]
		public float Lpg { get; set; }
	}
}
