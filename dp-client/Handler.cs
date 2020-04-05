using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using dp_client.DataFormats;

namespace dp_client
{
	public class Handler
	{

		private static readonly HttpClient client = new HttpClient();

		public string Hostname { get; set; }
		public string PortNumber { get; set; }
		public string Accept { get; set; }
		public string Body { get; set; }
		public string Schema { get; set; }
		public Boolean Validated { get; private set; }

		public Data allData;

		public Handler(Boolean usingJSON)
		{
			SwitchAcceptHeader(usingJSON);
			// Add default Accept header
			client.DefaultRequestHeaders.Add("Accept", Accept);
			Validated = false;
			allData = new Data();
		}

		public void SwitchAcceptHeader(Boolean usingJSON)
		{
			client.DefaultRequestHeaders.Remove("Accept");
			if (usingJSON)
			{
				Accept = "application/json";
			}
			else
			{
				Accept = "application/xml";
			}
			client.DefaultRequestHeaders.Add("Accept", Accept);
		}

		// Get data, validate data using linked schema and deserialize it
		public async Task MakeRequest(string endpoint)
		{
			try
			{
				HttpResponseMessage response = await client.GetAsync(GetURL(endpoint));
				response.EnsureSuccessStatusCode();
				Body = await response.Content.ReadAsStringAsync();
				string linkHeader = response.Headers.GetValues("Link").First();
				string schemaHREF = GetLinkHeaderHREF(linkHeader);
				await GetSchema(schemaHREF);
				// validate then deserialize data
				if (Accept.Contains("json"))
				{
					Validated = ValidateJSON();
					DeserializeJSON(endpoint);
				}
				else
				{
					Validated = ValidateXML();
					DeserializeXML(endpoint);
				}
			}
			catch(HttpRequestException)
			{
				throw new InvalidOperationException();
			}
		}

		public string GetURL(string endpoint)
		{
			return "http://" + Hostname + ":" + PortNumber + "/api/" + endpoint;
		}

		public string GetLinkHeaderHREF(string linkHeader)
		{
			int length;
			if (Accept.Contains("json"))
			{
				length = linkHeader.IndexOf(".schema.json") + 10;
			}
			else
			{
				length = linkHeader.IndexOf(".xsd") + 2;
			}
			return linkHeader.Substring(2, length);
		}

		public async Task GetSchema(string schemaHREF)
		{
			HttpResponseMessage response = await client.GetAsync(GetURL(schemaHREF));
			Schema = await response.Content.ReadAsStringAsync();
		}

		public Boolean ValidateJSON()
		{
			JSchema ValidationSchema = JSchema.Parse(Schema);
			JObject JsonToValidate = JObject.Parse(Body);
			return JsonToValidate.IsValid(ValidationSchema);
		}

		public Boolean ValidateXML()
		{
			// Load schema
			XmlSchemaSet schemas = new XmlSchemaSet();
			schemas.Add("", XmlReader.Create(new StringReader(Schema)));

			// Load XML document
			XDocument DocToValidate = XDocument.Load(new StringReader(Body));
			string msg = "";
			DocToValidate.Validate(schemas, (o, e) => {
				msg += e.Message + Environment.NewLine;
			});
			return msg == "";
		}

		public void DeserializeJSON(string endpoint)
		{
			switch(endpoint)
			{
				case "brandstofafzet":
					allData.Brandstofafzet.AfzetList = JObject.Parse(Body)[endpoint].ToObject<List<Afzet>>();
					break;
				case "emissies":
					allData.Emissies.EmissieList = JObject.Parse(Body)[endpoint].ToObject<List<Emissie>>();
					break;
				case "pompprijzen":
					allData.Pompprijzen.PompprijsList = JObject.Parse(Body)[endpoint].ToObject<List<Pompprijs>>();
					break;
			}
		}

		public void DeserializeXML(string endpoint)
		{
			XmlSerializer serializer;
			using (var reader = new StringReader(Body))
			{
				switch (endpoint)
				{
					case "brandstofafzet":
						serializer = new XmlSerializer(typeof(Brandstofafzet));
						allData.Brandstofafzet = (Brandstofafzet)serializer.Deserialize(reader);
						break;
					case "emissies":
						serializer = new XmlSerializer(typeof(Emissies));
						allData.Emissies = (Emissies)serializer.Deserialize(reader);
						break;
					case "pompprijzen":
						serializer = new XmlSerializer(typeof(Pompprijzen));
						allData.Pompprijzen = (Pompprijzen)serializer.Deserialize(reader);
						break;
				}
			}
		}


	}
}
