//
//  LoginDialog.Designer.cs
//  SpeechAnywhereSample
//
//  Copyright 2011-2018 Nuance Communications, Inc. All rights reserved.
//

namespace S_SpeechAnywhere
{
	partial class LoginDialog
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.buttonCustomizeSpeechBar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(26, 51);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(233, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(119, 103);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(67, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&User name:";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCancel.Location = new System.Drawing.Point(192, 103);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(67, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCustomizeSpeechBar
            // 
            this.buttonCustomizeSpeechBar.Location = new System.Drawing.Point(134, 170);
            this.buttonCustomizeSpeechBar.Name = "buttonCustomizeSpeechBar";
            this.buttonCustomizeSpeechBar.Size = new System.Drawing.Size(125, 24);
            this.buttonCustomizeSpeechBar.TabIndex = 4;
            this.buttonCustomizeSpeechBar.Text = "Customize speech bar";
            this.buttonCustomizeSpeechBar.UseVisualStyleBackColor = true;
            this.buttonCustomizeSpeechBar.Click += new System.EventHandler(this.buttonCustomizeSpeechBar_Click);
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.buttonCustomizeSpeechBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button buttonCustomizeSpeechBar;
	}
}