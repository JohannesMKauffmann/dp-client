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

		public string BaseURL { get; set; }
		public string Endpoint { get; set; }
		public string Accept { get; set; }
		public string Body { get; set; }
		public string Schema { get; set; }
		public Boolean validated { get; private set; }

		public Handler(Boolean UsingJSON)
		{
			SwitchAcceptHeader(UsingJSON);
			Endpoint = "brandstofafzet";
			// Add default Accept header
			client.DefaultRequestHeaders.Add("Accept", Accept);
			validated = false;
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

		public async Task MakeRequest(string Endpoint)
		{
			HttpResponseMessage response = await client.GetAsync(BaseURL + "/" + Endpoint);
			Body = await response.Content.ReadAsStringAsync();
			string LinkHeader = response.Headers.GetValues("Link").First();
			string schemaHREF = GetLinkHeaderHREF(LinkHeader);
			await GetSchema(schemaHREF);
			if (Accept.Contains("json"))
			{
				validated = ValidateJSON(Schema);
			}
			else
			{
				validated = ValidateXML(Schema);
			}
		}

		public string GetURL(string Endpoint)
		{
			return BaseURL + "/" + Endpoint;
		}

		public string GetLinkHeaderHREF(string LinkHeader)
		{
			int Length;
			if (Accept.Contains("json"))
			{
				Length = LinkHeader.IndexOf(".schema.json") + 10;
			}
			else
			{
				Length = LinkHeader.IndexOf(".xsd") + 2;
			}
			return LinkHeader.Substring(2, Length);
		}

		public async Task GetSchema(string SchemaHREF)
		{
			HttpResponseMessage response = await client.GetAsync(GetURL(SchemaHREF));
			Schema = await response.Content.ReadAsStringAsync();
		}

		public Boolean ValidateJSON(string Schema)
		{
			JSchema ValidationSchema = JSchema.Parse(Schema);
			JObject JsonToValidate = JObject.Parse(Body);
			return JsonToValidate.IsValid(ValidationSchema);
		}

		public Boolean ValidateXML(string SchemaHREF)
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
	}
}
