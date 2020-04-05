using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_client.DataFormats
{
	public class Data
	{
		public Brandstofafzet Brandstofafzet { get; set; }
		public Emissies Emissies { get; set; }
		public Pompprijzen Pompprijzen { get; set; }

		public Data()
		{
			Brandstofafzet = new Brandstofafzet();
			Emissies = new Emissies();
			Pompprijzen = new Pompprijzen();
		}
	}
}
