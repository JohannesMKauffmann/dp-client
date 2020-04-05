using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace dp_client
{
	class Handler
	{

		private static readonly HttpClient client = new HttpClient();

		private const string BaseURL = "http://localhost:";
		public string PortNumber { get; set; }
		public string Accept { get; set; }
		public string Body { get; set; }
		public string Schema { get; set; }
		public Boolean Validated { get; private set; }

		public Data allData;

		public Handler(Boolean UsingJSON)
		{
			SwitchAcceptHeader(UsingJSON);
			// Add default Accept header
			client.DefaultRequestHeaders.Add("Accept", Accept);
			Validated = false;
			allData = new Data();
		}

		public void SwitchAcceptHeader(Boolean UsingJSON)
		{
			client.DefaultRequestHeaders.Remove("Accept");
			if (UsingJSON)
			{
				Accept = "application/json";
			}
			else
			{
				Accept = "application/xml";
			}
			client.DefaultRequestHeaders.Add("Accept", Accept);
		}

		public async Task MakeRequest(string endpoint)
		{
			HttpResponseMessage response = await client.GetAsync(GetURL(endpoint));
			Body = await response.Content.ReadAsStringAsync();
			string LinkHeader = response.Headers.GetValues("Link").First();
			string schemaHREF = GetLinkHeaderHREF(LinkHeader);
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
			}
		}

		public string GetURL(string endpoint)
		{
			return BaseURL + PortNumber + "/api/" + endpoint;
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
					allData.brandstofafzet = JObject.Parse(Body)[endpoint].ToObject<List<Afzet>>();
					break;
				case "emissies":
					break;
				case "pompprijzen":
					break;
			}
		}

		public void DeserializeXML(string endpoint)
		{

		}
	}
}
