using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	[XmlRootAttribute("emissies")]
	public class Emissies
	{
		[XmlElement("emissie")]
		public List<Emissie> EmissieList { get; set; }
	}
}
