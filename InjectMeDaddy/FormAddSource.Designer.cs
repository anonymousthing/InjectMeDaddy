﻿namespace InjectMeDaddy
{
	partial class FormAddSource
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
			this.btnOk = new System.Windows.Forms.Button();
			this.txtUrl = new InjectMeDaddy.GhostTextbox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new InjectMeDaddy.GhostTextbox();
			this.txtDescription = new InjectMeDaddy.GhostTextbox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.radioButtonJs = new System.Windows.Forms.RadioButton();
			this.radioBtnCss = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(117, 219);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.GhostText = "Source URL";
			this.txtUrl.Location = new System.Drawing.Point(11, 69);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(262, 20);
			this.txtUrl.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(198, 219);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.GhostText = "Name";
			this.txtName.Location = new System.Drawing.Point(12, 43);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(261, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtDescription
			// 
			this.txtDescription.GhostText = "Description";
			this.txtDescription.Location = new System.Drawing.Point(11, 112);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(262, 94);
			this.txtDescription.TabIndex = 2;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(13, 96);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 5;
			this.lblDescription.Text = "Description:";
			// 
			// radioButtonJs
			// 
			this.radioButtonJs.AutoSize = true;
			this.radioButtonJs.Checked = true;
			this.radioButtonJs.Location = new System.Drawing.Point(13, 13);
			this.radioButtonJs.Name = "radioButtonJs";
			this.radioButtonJs.Size = new System.Drawing.Size(73, 17);
			this.radioButtonJs.TabIndex = 6;
			this.radioButtonJs.TabStop = true;
			this.radioButtonJs.Text = "Javascript";
			this.radioButtonJs.UseVisualStyleBackColor = true;
			// 
			// radioBtnCss
			// 
			this.radioBtnCss.AutoSize = true;
			this.radioBtnCss.Location = new System.Drawing.Point(146, 13);
			this.radioBtnCss.Name = "radioBtnCss";
			this.radioBtnCss.Size = new System.Drawing.Size(46, 17);
			this.radioBtnCss.TabIndex = 7;
			this.radioBtnCss.TabStop = true;
			this.radioBtnCss.Text = "CSS";
			this.radioBtnCss.UseVisualStyleBackColor = true;
			// 
			// FormAddSource
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 249);
			this.Controls.Add(this.radioBtnCss);
			this.Controls.Add(this.radioButtonJs);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddSource";
			this.Text = "Add source...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private GhostTextbox txtUrl;
		private System.Windows.Forms.Button btnCancel;
		private GhostTextbox txtName;
		private GhostTextbox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.RadioButton radioButtonJs;
		private System.Windows.Forms.RadioButton radioBtnCss;
	}
}