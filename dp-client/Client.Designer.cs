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
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.DataviewerTab = new System.Windows.Forms.TabPage();
			this.SettingsTab = new System.Windows.Forms.TabPage();
			this.JSONButton = new System.Windows.Forms.RadioButton();
			this.XMLButton = new System.Windows.Forms.RadioButton();
			this.RootEndpointLabel = new System.Windows.Forms.Label();
			this.URLTextBox = new System.Windows.Forms.TextBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.DataValidatedLabel = new System.Windows.Forms.Label();
			this.MainTabControl.SuspendLayout();
			this.DataviewerTab.SuspendLayout();
			this.SettingsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			this.MainTabControl.Controls.Add(this.DataviewerTab);
			this.MainTabControl.Controls.Add(this.SettingsTab);
			this.MainTabControl.Location = new System.Drawing.Point(0, 0);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(801, 452);
			this.MainTabControl.TabIndex = 0;
			// 
			// DataviewerTab
			// 
			this.DataviewerTab.Controls.Add(this.DataValidatedLabel);
			this.DataviewerTab.Location = new System.Drawing.Point(4, 22);
			this.DataviewerTab.Name = "DataviewerTab";
			this.DataviewerTab.Padding = new System.Windows.Forms.Padding(3);
			this.DataviewerTab.Size = new System.Drawing.Size(793, 426);
			this.DataviewerTab.TabIndex = 0;
			this.DataviewerTab.Text = "Dataset";
			this.DataviewerTab.UseVisualStyleBackColor = true;
			// 
			// SettingsTab
			// 
			this.SettingsTab.Controls.Add(this.JSONButton);
			this.SettingsTab.Controls.Add(this.XMLButton);
			this.SettingsTab.Controls.Add(this.RootEndpointLabel);
			this.SettingsTab.Controls.Add(this.URLTextBox);
			this.SettingsTab.Controls.Add(this.UpdateButton);
			this.SettingsTab.Location = new System.Drawing.Point(4, 22);
			this.SettingsTab.Name = "SettingsTab";
			this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
			this.SettingsTab.Size = new System.Drawing.Size(793, 426);
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
			this.RootEndpointLabel.Location = new System.Drawing.Point(50, 46);
			this.RootEndpointLabel.Name = "RootEndpointLabel";
			this.RootEndpointLabel.Size = new System.Drawing.Size(133, 20);
			this.RootEndpointLabel.TabIndex = 5;
			this.RootEndpointLabel.Text = "API root endpoint";
			// 
			// URLTextBox
			// 
			this.URLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.URLTextBox.Location = new System.Drawing.Point(47, 90);
			this.URLTextBox.Name = "URLTextBox";
			this.URLTextBox.Size = new System.Drawing.Size(203, 26);
			this.URLTextBox.TabIndex = 4;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(298, 90);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(60, 26);
			this.UpdateButton.TabIndex = 3;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateURL_Click);
			// 
			// DataValidatedLabel
			// 
			this.DataValidatedLabel.AutoSize = true;
			this.DataValidatedLabel.Location = new System.Drawing.Point(31, 396);
			this.DataValidatedLabel.Name = "DataValidatedLabel";
			this.DataValidatedLabel.Size = new System.Drawing.Size(141, 13);
			this.DataValidatedLabel.TabIndex = 0;
			this.DataValidatedLabel.Text = "Data has not been validated";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainTabControl);
			this.Name = "Client";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Client_Load);
			this.MainTabControl.ResumeLayout(false);
			this.DataviewerTab.ResumeLayout(false);
			this.DataviewerTab.PerformLayout();
			this.SettingsTab.ResumeLayout(false);
			this.SettingsTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage SettingsTab;
		private System.Windows.Forms.Label RootEndpointLabel;
		private System.Windows.Forms.TextBox URLTextBox;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.TabPage DataviewerTab;
		private System.Windows.Forms.RadioButton XMLButton;
		private System.Windows.Forms.RadioButton JSONButton;
		private System.Windows.Forms.Label DataValidatedLabel;
	}
}

