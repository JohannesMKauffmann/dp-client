using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	[XmlRootAttribute("brandstofafzet")]
	public class Brandstofafzet
	{
		[XmlElement("afzet")]
		public List<Afzet> AfzetList { get; set; }
	}
}
