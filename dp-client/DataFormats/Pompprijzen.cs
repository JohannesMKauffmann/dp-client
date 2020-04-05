using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dp_client.DataFormats
{
	[XmlRootAttribute("pompprijzen")]
	public class Pompprijzen
	{
		[XmlElement("pompprijs")]
		public List<Pompprijs> PompprijsList { get; set; }
	}
}
