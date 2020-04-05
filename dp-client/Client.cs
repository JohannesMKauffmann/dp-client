using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				PortNumber = "4002"
			};
		}

		private async void Client_Load(object sender, EventArgs e)
		{
			// set some defaults, like JSON, brandstofafzet.
			PortNumberTextBox.Text = handler.PortNumber;
			await QueryAPI();
			UpdateCharts();
		}

		public async Task QueryAPI()
		{
			foreach (string Endpoint in Endpoints)
			{
				handler.SwitchAcceptHeader(UsingJSON);
				await Task.Run(() => handler.MakeRequest(Endpoint));
				if (!handler.Validated)
				{
					MessageBox.Show("Data has not been validated.");
				}
			}
		}

		private async void UpdateURL_Click(object sender, EventArgs e)
		{
			handler.PortNumber = PortNumberTextBox.Text;
			await QueryAPI();
		}

		private async void XMLButton_CheckedChanged(object sender, EventArgs e)
		{
			UsingJSON = JSONButton.Checked;
			await QueryAPI();
			UpdateCharts();
		}

		public void UpdateCharts()
		{
			ClearCharts();
			FillBrandstofChart();
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
			foreach (System.Windows.Forms.DataVisualization.Charting.Series series in BrandstofafzetChart.Series)
			{
				series.Points.Clear();
			}
		}

		private void FillBrandstofChart()
		{
			List<Afzet> afzetList = handler.allData.brandstofafzet;
			afzetList.ForEach(afzet => {
				BrandstofafzetChart.Series["Euro 95"].Points.AddXY(afzet.Jaar, afzet.Euro95);
				BrandstofafzetChart.Series["Diesel"].Points.AddXY(afzet.Jaar, afzet.Diesel);
				BrandstofafzetChart.Series["LPG"].Points.AddXY(afzet.Jaar, afzet.Lpg);
			});
		}
	}
}
