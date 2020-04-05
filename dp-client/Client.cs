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

		Handler handler;
		Boolean UsingJSON = true;
		public Client()
		{
			InitializeComponent();
			handler = new Handler(UsingJSON);
			handler.BaseURL = "http://localhost:4002/api";
		}

		private async void Client_Load(object sender, EventArgs e)
		{
			// set some defaults, like JSON, brandstofafzet.
			URLTextBox.Text = handler.BaseURL;
			await QueryAPI();
		}

		public async Task QueryAPI()
		{
			handler.SwitchAcceptHeader(UsingJSON);
			await Task.Run(() => handler.MakeRequest(handler.Endpoint));
			if (handler.validated)
			{
				DataValidatedLabel.Text = "Data has been validated.";
			}
		}

		private void UpdateURL_Click(object sender, EventArgs e)
		{
			handler.BaseURL = URLTextBox.Text;
		}

		private async void XMLButton_CheckedChanged(object sender, EventArgs e)
		{
			UsingJSON = JSONButton.Checked;
			await QueryAPI();
		}
	}
}
