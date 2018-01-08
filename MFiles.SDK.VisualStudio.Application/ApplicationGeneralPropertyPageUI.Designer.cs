namespace MFiles.SDK.VisualStudio.Application
{
	partial class ApplicationGeneralPropertyPageUI
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label13;
			this.environmentVaultCoreInput = new System.Windows.Forms.CheckBox();
			this.environmentVaultUiInput = new System.Windows.Forms.CheckBox();
			this.environmentShellUiInput = new System.Windows.Forms.CheckBox();
			this.applicationNameInput = new System.Windows.Forms.TextBox();
			this.eventLog1 = new System.Diagnostics.EventLog();
			this.descriptionInput = new System.Windows.Forms.TextBox();
			this.applicationVersionMajor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.applicationVersionMinor = new System.Windows.Forms.TextBox();
			this.applicationVersionRevision = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.applicationVersionBuild = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.packageNameInput = new System.Windows.Forms.TextBox();
			this.defaultNamespaceInput = new System.Windows.Forms.TextBox();
			this.mfilesVersionBuild = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.mfilesVersionRevision = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.mfilesVersionMinor = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.mfilesVersionMajor = new System.Windows.Forms.TextBox();
			this.publisherInput = new System.Windows.Forms.TextBox();
			this.enabledDefaultInput = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.optionalInput = new System.Windows.Forms.CheckBox();
			this.copyrightInput = new System.Windows.Forms.TextBox();
			this.masterApplicationGuidInput = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.platformDesktopInput = new System.Windows.Forms.CheckBox();
			this.platformWebInput = new System.Windows.Forms.CheckBox();
			nameLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(-8, 0);
			nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(243, 32);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Application name:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(8, 706);
			label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(337, 32);
			label1.TabIndex = 2;
			label1.Text = "Minimum M-Files version:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(-8, 105);
			label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(212, 32);
			label2.TabIndex = 4;
			label2.Text = "Package name:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(this.environmentVaultCoreInput);
			groupBox1.Controls.Add(this.environmentVaultUiInput);
			groupBox1.Controls.Add(this.environmentShellUiInput);
			groupBox1.Location = new System.Drawing.Point(803, 7);
			groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
			groupBox1.Size = new System.Drawing.Size(749, 293);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Environments";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(24, 52);
			label3.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(693, 160);
			label3.TabIndex = 3;
			label3.Text = "Specify the environments in which the scripts defined\r\nin this project are loaded" +
    " by default.\r\n\r\nYou can change these settings for individual scripts or\r\nresourc" +
    "es in their properties.";
			// 
			// environmentVaultCoreInput
			// 
			this.environmentVaultCoreInput.AutoSize = true;
			this.environmentVaultCoreInput.Location = new System.Drawing.Point(419, 229);
			this.environmentVaultCoreInput.Margin = new System.Windows.Forms.Padding(16, 7, 8, 7);
			this.environmentVaultCoreInput.Name = "environmentVaultCoreInput";
			this.environmentVaultCoreInput.Size = new System.Drawing.Size(180, 36);
			this.environmentVaultCoreInput.TabIndex = 6;
			this.environmentVaultCoreInput.Text = "VaultCore";
			this.environmentVaultCoreInput.UseVisualStyleBackColor = true;
			// 
			// environmentVaultUiInput
			// 
			this.environmentVaultUiInput.AutoSize = true;
			this.environmentVaultUiInput.Location = new System.Drawing.Point(232, 229);
			this.environmentVaultUiInput.Margin = new System.Windows.Forms.Padding(16, 7, 8, 7);
			this.environmentVaultUiInput.Name = "environmentVaultUiInput";
			this.environmentVaultUiInput.Size = new System.Drawing.Size(146, 36);
			this.environmentVaultUiInput.TabIndex = 5;
			this.environmentVaultUiInput.Text = "VaultUI";
			this.environmentVaultUiInput.UseVisualStyleBackColor = true;
			// 
			// environmentShellUiInput
			// 
			this.environmentShellUiInput.AutoSize = true;
			this.environmentShellUiInput.Location = new System.Drawing.Point(24, 229);
			this.environmentShellUiInput.Margin = new System.Windows.Forms.Padding(16, 7, 8, 7);
			this.environmentShellUiInput.Name = "environmentShellUiInput";
			this.environmentShellUiInput.Size = new System.Drawing.Size(145, 36);
			this.environmentShellUiInput.TabIndex = 4;
			this.environmentShellUiInput.Text = "ShellUI";
			this.environmentShellUiInput.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(795, 348);
			label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(166, 32);
			label4.TabIndex = 7;
			label4.Text = "Description:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(-8, 210);
			label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(268, 32);
			label5.TabIndex = 9;
			label5.Text = "Default namespace:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(8, 601);
			label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(264, 32);
			label6.TabIndex = 26;
			label6.Text = "Application version:";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(0, 305);
			label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(143, 32);
			label13.TabIndex = 36;
			label13.Text = "Publisher:";
			// 
			// applicationNameInput
			// 
			this.applicationNameInput.Location = new System.Drawing.Point(0, 38);
			this.applicationNameInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 19);
			this.applicationNameInput.Name = "applicationNameInput";
			this.applicationNameInput.Size = new System.Drawing.Size(751, 38);
			this.applicationNameInput.TabIndex = 1;
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// descriptionInput
			// 
			this.descriptionInput.Location = new System.Drawing.Point(803, 386);
			this.descriptionInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.descriptionInput.Multiline = true;
			this.descriptionInput.Name = "descriptionInput";
			this.descriptionInput.Size = new System.Drawing.Size(751, 195);
			this.descriptionInput.TabIndex = 16;
			// 
			// applicationVersionMajor
			// 
			this.applicationVersionMajor.Location = new System.Drawing.Point(16, 639);
			this.applicationVersionMajor.Margin = new System.Windows.Forms.Padding(8, 7, 0, 19);
			this.applicationVersionMajor.Name = "applicationVersionMajor";
			this.applicationVersionMajor.Size = new System.Drawing.Size(127, 38);
			this.applicationVersionMajor.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(149, 646);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 32);
			this.label7.TabIndex = 13;
			this.label7.Text = ".";
			// 
			// applicationVersionMinor
			// 
			this.applicationVersionMinor.Location = new System.Drawing.Point(176, 639);
			this.applicationVersionMinor.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.applicationVersionMinor.Name = "applicationVersionMinor";
			this.applicationVersionMinor.Size = new System.Drawing.Size(127, 38);
			this.applicationVersionMinor.TabIndex = 9;
			// 
			// applicationVersionRevision
			// 
			this.applicationVersionRevision.Location = new System.Drawing.Point(336, 639);
			this.applicationVersionRevision.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.applicationVersionRevision.Name = "applicationVersionRevision";
			this.applicationVersionRevision.Size = new System.Drawing.Size(127, 38);
			this.applicationVersionRevision.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(309, 646);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 32);
			this.label8.TabIndex = 15;
			this.label8.Text = ".";
			// 
			// applicationVersionBuild
			// 
			this.applicationVersionBuild.Location = new System.Drawing.Point(496, 639);
			this.applicationVersionBuild.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.applicationVersionBuild.Name = "applicationVersionBuild";
			this.applicationVersionBuild.Size = new System.Drawing.Size(127, 38);
			this.applicationVersionBuild.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(469, 646);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 32);
			this.label9.TabIndex = 17;
			this.label9.Text = ".";
			// 
			// packageNameInput
			// 
			this.packageNameInput.Location = new System.Drawing.Point(0, 143);
			this.packageNameInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 19);
			this.packageNameInput.Name = "packageNameInput";
			this.packageNameInput.Size = new System.Drawing.Size(751, 38);
			this.packageNameInput.TabIndex = 2;
			// 
			// defaultNamespaceInput
			// 
			this.defaultNamespaceInput.Location = new System.Drawing.Point(0, 248);
			this.defaultNamespaceInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 19);
			this.defaultNamespaceInput.Name = "defaultNamespaceInput";
			this.defaultNamespaceInput.Size = new System.Drawing.Size(751, 38);
			this.defaultNamespaceInput.TabIndex = 3;
			// 
			// mfilesVersionBuild
			// 
			this.mfilesVersionBuild.Location = new System.Drawing.Point(496, 744);
			this.mfilesVersionBuild.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.mfilesVersionBuild.Name = "mfilesVersionBuild";
			this.mfilesVersionBuild.Size = new System.Drawing.Size(127, 38);
			this.mfilesVersionBuild.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(469, 751);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 32);
			this.label10.TabIndex = 34;
			this.label10.Text = ".";
			// 
			// mfilesVersionRevision
			// 
			this.mfilesVersionRevision.Location = new System.Drawing.Point(336, 744);
			this.mfilesVersionRevision.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.mfilesVersionRevision.Name = "mfilesVersionRevision";
			this.mfilesVersionRevision.Size = new System.Drawing.Size(127, 38);
			this.mfilesVersionRevision.TabIndex = 14;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(309, 751);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 32);
			this.label11.TabIndex = 32;
			this.label11.Text = ".";
			// 
			// mfilesVersionMinor
			// 
			this.mfilesVersionMinor.Location = new System.Drawing.Point(176, 744);
			this.mfilesVersionMinor.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
			this.mfilesVersionMinor.Name = "mfilesVersionMinor";
			this.mfilesVersionMinor.Size = new System.Drawing.Size(127, 38);
			this.mfilesVersionMinor.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(149, 751);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(23, 32);
			this.label12.TabIndex = 30;
			this.label12.Text = ".";
			// 
			// mfilesVersionMajor
			// 
			this.mfilesVersionMajor.Location = new System.Drawing.Point(16, 744);
			this.mfilesVersionMajor.Margin = new System.Windows.Forms.Padding(8, 7, 0, 19);
			this.mfilesVersionMajor.Name = "mfilesVersionMajor";
			this.mfilesVersionMajor.Size = new System.Drawing.Size(127, 38);
			this.mfilesVersionMajor.TabIndex = 12;
			// 
			// publisherInput
			// 
			this.publisherInput.Location = new System.Drawing.Point(8, 343);
			this.publisherInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 19);
			this.publisherInput.Name = "publisherInput";
			this.publisherInput.Size = new System.Drawing.Size(751, 38);
			this.publisherInput.TabIndex = 7;
			// 
			// enabledDefaultInput
			// 
			this.enabledDefaultInput.AutoSize = true;
			this.enabledDefaultInput.Location = new System.Drawing.Point(803, 601);
			this.enabledDefaultInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.enabledDefaultInput.Name = "enabledDefaultInput";
			this.enabledDefaultInput.Size = new System.Drawing.Size(290, 36);
			this.enabledDefaultInput.TabIndex = 17;
			this.enabledDefaultInput.Text = "Enabled by default";
			this.enabledDefaultInput.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(-2, 400);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(137, 32);
			this.label14.TabIndex = 37;
			this.label14.Text = "Copyright";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 492);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(318, 32);
			this.label15.TabIndex = 38;
			this.label15.Text = "Master Application Guid";
			// 
			// optionalInput
			// 
			this.optionalInput.AutoSize = true;
			this.optionalInput.Location = new System.Drawing.Point(801, 661);
			this.optionalInput.Name = "optionalInput";
			this.optionalInput.Size = new System.Drawing.Size(161, 36);
			this.optionalInput.TabIndex = 39;
			this.optionalInput.Text = "Optional";
			this.optionalInput.UseVisualStyleBackColor = true;
			// 
			// copyrightInput
			// 
			this.copyrightInput.Location = new System.Drawing.Point(8, 436);
			this.copyrightInput.Name = "copyrightInput";
			this.copyrightInput.Size = new System.Drawing.Size(743, 38);
			this.copyrightInput.TabIndex = 40;
			// 
			// masterApplicationGuidInput
			// 
			this.masterApplicationGuidInput.Location = new System.Drawing.Point(8, 528);
			this.masterApplicationGuidInput.Name = "masterApplicationGuidInput";
			this.masterApplicationGuidInput.Size = new System.Drawing.Size(743, 38);
			this.masterApplicationGuidInput.TabIndex = 41;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.platformWebInput);
			this.groupBox2.Controls.Add(this.platformDesktopInput);
			this.groupBox2.Location = new System.Drawing.Point(803, 761);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(749, 220);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Platforms";
			// 
			// platformDesktopInput
			// 
			this.platformDesktopInput.AutoSize = true;
			this.platformDesktopInput.Location = new System.Drawing.Point(30, 105);
			this.platformDesktopInput.Name = "platformDesktopInput";
			this.platformDesktopInput.Size = new System.Drawing.Size(157, 36);
			this.platformDesktopInput.TabIndex = 0;
			this.platformDesktopInput.Text = "Desktop";
			this.platformDesktopInput.UseVisualStyleBackColor = true;
			// 
			// platformWebInput
			// 
			this.platformWebInput.AutoSize = true;
			this.platformWebInput.Location = new System.Drawing.Point(232, 105);
			this.platformWebInput.Name = "platformWebInput";
			this.platformWebInput.Size = new System.Drawing.Size(111, 36);
			this.platformWebInput.TabIndex = 1;
			this.platformWebInput.Text = "Web";
			this.platformWebInput.UseVisualStyleBackColor = true;
			// 
			// ApplicationGeneralPropertyPageUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.masterApplicationGuidInput);
			this.Controls.Add(this.copyrightInput);
			this.Controls.Add(this.optionalInput);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.enabledDefaultInput);
			this.Controls.Add(this.publisherInput);
			this.Controls.Add(label13);
			this.Controls.Add(this.mfilesVersionBuild);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.mfilesVersionRevision);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.mfilesVersionMinor);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.mfilesVersionMajor);
			this.Controls.Add(this.defaultNamespaceInput);
			this.Controls.Add(this.packageNameInput);
			this.Controls.Add(label6);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.applicationNameInput);
			this.Controls.Add(this.applicationVersionBuild);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.applicationVersionRevision);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.applicationVersionMinor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.applicationVersionMajor);
			this.Controls.Add(label5);
			this.Controls.Add(this.descriptionInput);
			this.Controls.Add(label4);
			this.Controls.Add(groupBox1);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "ApplicationGeneralPropertyPageUI";
			this.Size = new System.Drawing.Size(1571, 1099);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox applicationNameInput;
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.CheckBox environmentVaultCoreInput;
		private System.Windows.Forms.CheckBox environmentVaultUiInput;
		private System.Windows.Forms.CheckBox environmentShellUiInput;
		private System.Windows.Forms.TextBox descriptionInput;
		private System.Windows.Forms.TextBox applicationVersionBuild;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox applicationVersionRevision;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox applicationVersionMinor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox applicationVersionMajor;
		private System.Windows.Forms.CheckBox enabledDefaultInput;
		private System.Windows.Forms.TextBox publisherInput;
		private System.Windows.Forms.TextBox mfilesVersionBuild;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox mfilesVersionRevision;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox mfilesVersionMinor;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox mfilesVersionMajor;
		private System.Windows.Forms.TextBox defaultNamespaceInput;
		private System.Windows.Forms.TextBox packageNameInput;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox platformWebInput;
		private System.Windows.Forms.CheckBox platformDesktopInput;
		private System.Windows.Forms.TextBox masterApplicationGuidInput;
		private System.Windows.Forms.TextBox copyrightInput;
		private System.Windows.Forms.CheckBox optionalInput;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
	}
}
