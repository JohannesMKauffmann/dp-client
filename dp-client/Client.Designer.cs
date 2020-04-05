namespace dp_client
{
	partial class Client
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.DataviewerTab = new System.Windows.Forms.TabPage();
			this.BrandstofafzetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.SettingsTab = new System.Windows.Forms.TabPage();
			this.JSONButton = new System.Windows.Forms.RadioButton();
			this.XMLButton = new System.Windows.Forms.RadioButton();
			this.RootEndpointLabel = new System.Windows.Forms.Label();
			this.PortNumberTextBox = new System.Windows.Forms.TextBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.PompprijzenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.MainTabControl.SuspendLayout();
			this.DataviewerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BrandstofafzetChart)).BeginInit();
			this.SettingsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PompprijzenChart)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			this.MainTabControl.Controls.Add(this.DataviewerTab);
			this.MainTabControl.Controls.Add(this.SettingsTab);
			this.MainTabControl.Location = new System.Drawing.Point(0, 0);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(1062, 397);
			this.MainTabControl.TabIndex = 0;
			// 
			// DataviewerTab
			// 
			this.DataviewerTab.Controls.Add(this.PompprijzenChart);
			this.DataviewerTab.Controls.Add(this.BrandstofafzetChart);
			this.DataviewerTab.Location = new System.Drawing.Point(4, 22);
			this.DataviewerTab.Name = "DataviewerTab";
			this.DataviewerTab.Padding = new System.Windows.Forms.Padding(3);
			this.DataviewerTab.Size = new System.Drawing.Size(1054, 371);
			this.DataviewerTab.TabIndex = 0;
			this.DataviewerTab.Text = "Dataset";
			this.DataviewerTab.UseVisualStyleBackColor = true;
			// 
			// BrandstofafzetChart
			// 
			chartArea2.Name = "ChartArea1";
			this.BrandstofafzetChart.ChartAreas.Add(chartArea2);
			legend3.Name = "Legend1";
			legend3.Title = "Brandstofafzet";
			legend4.Alignment = System.Drawing.StringAlignment.Center;
			legendCellColumn2.Name = "Column1";
			legend4.CellColumns.Add(legendCellColumn2);
			legendItem2.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
			legend4.CustomItems.Add(legendItem2);
			legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend4.Name = "Legend2";
			legend4.Title = "Afzet in mln kg";
			legend4.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.BrandstofafzetChart.Legends.Add(legend3);
			this.BrandstofafzetChart.Legends.Add(legend4);
			this.BrandstofafzetChart.Location = new System.Drawing.Point(8, 3);
			this.BrandstofafzetChart.Name = "BrandstofafzetChart";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Legend = "Legend1";
			series4.Name = "Euro 95";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series5.Legend = "Legend1";
			series5.Name = "Diesel";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series6.Legend = "Legend1";
			series6.Name = "LPG";
			this.BrandstofafzetChart.Series.Add(series4);
			this.BrandstofafzetChart.Series.Add(series5);
			this.BrandstofafzetChart.Series.Add(series6);
			this.BrandstofafzetChart.Size = new System.Drawing.Size(517, 362);
			this.BrandstofafzetChart.TabIndex = 1;
			this.BrandstofafzetChart.Text = "chart1";
			// 
			// SettingsTab
			// 
			this.SettingsTab.Controls.Add(this.JSONButton);
			this.SettingsTab.Controls.Add(this.XMLButton);
			this.SettingsTab.Controls.Add(this.RootEndpointLabel);
			this.SettingsTab.Controls.Add(this.PortNumberTextBox);
			this.SettingsTab.Controls.Add(this.UpdateButton);
			this.SettingsTab.Location = new System.Drawing.Point(4, 22);
			this.SettingsTab.Name = "SettingsTab";
			this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
			this.SettingsTab.Size = new System.Drawing.Size(793, 336);
			this.SettingsTab.TabIndex = 3;
			this.SettingsTab.Text = "Settings";
			this.SettingsTab.UseVisualStyleBackColor = true;
			// 
			// JSONButton
			// 
			this.JSONButton.AutoSize = true;
			this.JSONButton.Checked = true;
			this.JSONButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.JSONButton.Location = new System.Drawing.Point(47, 236);
			this.JSONButton.Name = "JSONButton";
			this.JSONButton.Size = new System.Drawing.Size(69, 24);
			this.JSONButton.TabIndex = 7;
			this.JSONButton.TabStop = true;
			this.JSONButton.Text = "JSON";
			this.JSONButton.UseVisualStyleBackColor = true;
			// 
			// XMLButton
			// 
			this.XMLButton.AutoSize = true;
			this.XMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XMLButton.Location = new System.Drawing.Point(47, 187);
			this.XMLButton.Name = "XMLButton";
			this.XMLButton.Size = new System.Drawing.Size(60, 24);
			this.XMLButton.TabIndex = 6;
			this.XMLButton.Text = "XML";
			this.XMLButton.UseVisualStyleBackColor = true;
			this.XMLButton.CheckedChanged += new System.EventHandler(this.XMLButton_CheckedChanged);
			// 
			// RootEndpointLabel
			// 
			this.RootEndpointLabel.AutoSize = true;
			this.RootEndpointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RootEndpointLabel.Location = new System.Drawing.Point(25, 46);
			this.RootEndpointLabel.Name = "RootEndpointLabel";
			this.RootEndpointLabel.Size = new System.Drawing.Size(172, 20);
			this.RootEndpointLabel.TabIndex = 5;
			this.RootEndpointLabel.Text = "API server port number";
			// 
			// PortNumberTextBox
			// 
			this.PortNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PortNumberTextBox.Location = new System.Drawing.Point(47, 90);
			this.PortNumberTextBox.Name = "PortNumberTextBox";
			this.PortNumberTextBox.Size = new System.Drawing.Size(118, 26);
			this.PortNumberTextBox.TabIndex = 4;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(219, 90);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(60, 26);
			this.UpdateButton.TabIndex = 3;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateURL_Click);
			// 
			// PompprijzenChart
			// 
			chartArea1.Name = "ChartArea1";
			this.PompprijzenChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			legend1.Title = "Pompprijzen";
			legend2.Alignment = System.Drawing.StringAlignment.Center;
			legendCellColumn1.Name = "Column1";
			legend2.CellColumns.Add(legendCellColumn1);
			legendItem1.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
			legend2.CustomItems.Add(legendItem1);
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend2.Name = "Legend2";
			legend2.Title = "Prijzen in euro/liter";
			legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.PompprijzenChart.Legends.Add(legend1);
			this.PompprijzenChart.Legends.Add(legend2);
			this.PompprijzenChart.Location = new System.Drawing.Point(560, 3);
			this.PompprijzenChart.Name = "PompprijzenChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Euro 95";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "Diesel";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Legend = "Legend1";
			series3.Name = "LPG";
			this.PompprijzenChart.Series.Add(series1);
			this.PompprijzenChart.Series.Add(series2);
			this.PompprijzenChart.Series.Add(series3);
			this.PompprijzenChart.Size = new System.Drawing.Size(433, 362);
			this.PompprijzenChart.TabIndex = 3;
			this.PompprijzenChart.Text = "chart1";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 394);
			this.Controls.Add(this.MainTabControl);
			this.Name = "Client";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Client_Load);
			this.MainTabControl.ResumeLayout(false);
			this.DataviewerTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BrandstofafzetChart)).EndInit();
			this.SettingsTab.ResumeLayout(false);
			this.SettingsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PompprijzenChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage SettingsTab;
		private System.Windows.Forms.Label RootEndpointLabel;
		private System.Windows.Forms.TextBox PortNumberTextBox;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.TabPage DataviewerTab;
		private System.Windows.Forms.RadioButton XMLButton;
		private System.Windows.Forms.RadioButton JSONButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart BrandstofafzetChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart PompprijzenChart;
	}
}

