using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dp_client.DataFormats;

namespace dp_client
{
	public partial class Client : Form
	{

		private Handler handler;
		Boolean UsingJSON = true;
		public string[] Endpoints = { "brandstofafzet", "emissies", "pompprijzen" };
		public Client()
		{
			InitializeComponent();
			handler = new Handler(UsingJSON)
			{
				Hostname = "127.0.0.1",
				PortNumber = "4002"
			};
		}

		private async void Client_Load(object sender, EventArgs e)
		{
			// set default textbox content
			HostnameTextBox.Text = handler.Hostname;
			PortNumberTextBox.Text = handler.PortNumber;
			await UpdateForm();
		}

		private async void UpdateURL_Click(object sender, EventArgs e)
		{
			handler.Hostname = HostnameTextBox.Text;
			handler.PortNumber = PortNumberTextBox.Text;
			await UpdateForm();
		}

		private void XMLButton_CheckedChanged(object sender, EventArgs e)
		{
			UsingJSON = JSONButton.Checked;
		}

		private async Task UpdateForm()
		{
			try
			{
				await QueryAPI();
				UpdateCharts();
			}
			catch(InvalidOperationException)
			{
				MessageBox.Show("Could not connect to the server. Make sure you are using the correct hostname and port number.");
			}
		}

		public async Task QueryAPI()
		{
			foreach (string Endpoint in Endpoints)
			{
				handler.SwitchAcceptHeader(UsingJSON);
				await handler.MakeRequest(Endpoint);
				if (!handler.Validated)
				{
					MessageBox.Show("Data has not been validated.");
				}
			}
		}

		public void UpdateCharts()
		{
			ClearCharts();
			FillBrandstofChart();
			FillEmissiesChart();
			FillPompprijzenChart();

		}

		private void ClearCharts()
		{
			foreach (System.Windows.Forms.DataVisualization.Charting.Series series in BrandstofafzetChart.Series)
			{
				series.Points.Clear();
			}
			foreach (System.Windows.Forms.DataVisualization.Charting.Series series in PompprijzenChart.Series)
			{
				series.Points.Clear();
			}
			foreach (System.Windows.Forms.DataVisualization.Charting.Series series in NOxChart.Series)
			{
				series.Points.Clear();
			}
			foreach (System.Windows.Forms.DataVisualization.Charting.Series series in CO2Chart.Series)
			{
				series.Points.Clear();
			}
		}

		private void FillBrandstofChart()
		{
			List<Afzet> afzetList = handler.allData.Brandstofafzet.AfzetList;
			afzetList.ForEach(afzet => {
				BrandstofafzetChart.Series["Euro 95"].Points.AddXY(afzet.Jaar, afzet.Euro95);
				BrandstofafzetChart.Series["Diesel"].Points.AddXY(afzet.Jaar, afzet.Diesel);
				BrandstofafzetChart.Series["LPG"].Points.AddXY(afzet.Jaar, afzet.Lpg);
			});
		}

		private void FillEmissiesChart()
		{
			List<Emissie> emissiesList = handler.allData.Emissies.EmissieList;
			emissiesList.ForEach(emissie => {
				switch(emissie.Bron)
				{
					case "wegverkeer":
						NOxChart.Series["Totaal wegverkeer"].Points.AddXY(emissie.Jaar, emissie.Nox);
						CO2Chart.Series["Totaal wegverkeer"].Points.AddXY(emissie.Jaar, emissie.Co2);
						break;
					case "benzine":
						NOxChart.Series["Benzine"].Points.AddXY(emissie.Jaar, emissie.Nox);
						CO2Chart.Series["Benzine"].Points.AddXY(emissie.Jaar, emissie.Co2);
						break;
					case "diesel":
						NOxChart.Series["Diesel"].Points.AddXY(emissie.Jaar, emissie.Nox);
						CO2Chart.Series["Diesel"].Points.AddXY(emissie.Jaar, emissie.Co2);
						break;
					case "lpg":
						NOxChart.Series["LPG"].Points.AddXY(emissie.Jaar, emissie.Nox);
						CO2Chart.Series["LPG"].Points.AddXY(emissie.Jaar, emissie.Co2);
						break;
				}
			});
		}

		private void FillPompprijzenChart()
		{
			List<Pompprijs> pompprijsList = handler.allData.Pompprijzen.PompprijsList;
			pompprijsList.ForEach(pompprijs => {
				PompprijzenChart.Series["Euro 95"].Points.AddXY(pompprijs.Jaar, pompprijs.Euro95);
				PompprijzenChart.Series["Diesel"].Points.AddXY(pompprijs.Jaar, pompprijs.Diesel);
				PompprijzenChart.Series["LPG"].Points.AddXY(pompprijs.Jaar, pompprijs.Lpg);
			});
		}

	}
}
