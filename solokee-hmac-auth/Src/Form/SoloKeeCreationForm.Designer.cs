using System;

namespace SoloKee.Forms
{
	partial class SoloKeeCreationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoloKeeCreationForm));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();

            this.grp_soloConfig = new System.Windows.Forms.GroupBox();
            this.txt_soloPath = new System.Windows.Forms.TextBox();
            this.lbl_explPython = new System.Windows.Forms.Label();
            this.btn_browseSoloPath = new System.Windows.Forms.Button();
            this.lbl_pythonPath = new System.Windows.Forms.Label();

            this.grp_keygen = new System.Windows.Forms.GroupBox();
            this.txt_keyField = new System.Windows.Forms.TextBox();
            this.btn_generateKey = new System.Windows.Forms.Button();

            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_ctxMenu = new KeePass.UI.CustomContextMenuStripEx(this.components);
            this.lbl_keyWarning = new System.Windows.Forms.Label();

            this.grp_soloConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_ctxMenu.SuspendLayout();
            this.grp_keygen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(208, 341);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "&OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // btn_cancle
            // 
            this.btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancle.Location = new System.Drawing.Point(289, 341);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 1;
            this.btn_cancle.Text = "&Cancel";
            this.btn_cancle.UseVisualStyleBackColor = true;
            // 
            // text_pythonPath
            // 
            this.txt_soloPath.Location = new System.Drawing.Point(9, 72);
            this.txt_soloPath.Name = "text_pythonPath";
            this.txt_soloPath.ReadOnly = true;
            this.txt_soloPath.Size = new System.Drawing.Size(262, 20);
            this.txt_soloPath.TabIndex = 1;
            // 
            // grp_soloConfig
            // 
            this.grp_soloConfig.Controls.Add(this.lbl_explPython);
            this.grp_soloConfig.Controls.Add(this.btn_browseSoloPath);
            this.grp_soloConfig.Controls.Add(this.lbl_pythonPath);
            this.grp_soloConfig.Controls.Add(this.txt_soloPath);
            this.grp_soloConfig.Location = new System.Drawing.Point(12, 109);
            this.grp_soloConfig.Name = "grp_soloConfig";
            this.grp_soloConfig.Size = new System.Drawing.Size(352, 108);
            this.grp_soloConfig.TabIndex = 3;
            this.grp_soloConfig.TabStop = false;
            this.grp_soloConfig.Text = "SoloKee Configuration";
            // 
            // lbl_explPython
            // 
            this.lbl_explPython.AutoSize = true;
            this.lbl_explPython.ForeColor = System.Drawing.Color.Black;
            this.lbl_explPython.Location = new System.Drawing.Point(6, 21);
            this.lbl_explPython.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbl_explPython.Name = "lbl_explPython";
            this.lbl_explPython.Size = new System.Drawing.Size(341, 26);
            this.lbl_explPython.TabIndex = 4;
            this.lbl_explPython.Text = "Note: A solo executable should be contained in your python path\'s site packages!";
            // 
            // btn_browsePythonPath
            // 
            this.btn_browseSoloPath.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_browseSoloPath.Location = new System.Drawing.Point(276, 71);
            this.btn_browseSoloPath.Name = "btn_browsePythonPath";
            this.btn_browseSoloPath.Size = new System.Drawing.Size(64, 23);
            this.btn_browseSoloPath.TabIndex = 6;
            this.btn_browseSoloPath.Text = "Browse";
            this.btn_browseSoloPath.UseVisualStyleBackColor = true;
            this.btn_browseSoloPath.Click += new System.EventHandler(this.OnBtnBrowse);
            // 
            // lbl_pythonPath
            // 
            this.lbl_pythonPath.AutoSize = true;
            this.lbl_pythonPath.Location = new System.Drawing.Point(6, 56);
            this.lbl_pythonPath.Name = "lbl_pythonPath";
            this.lbl_pythonPath.Size = new System.Drawing.Size(83, 13);
            this.lbl_pythonPath.TabIndex = 0;
            this.lbl_pythonPath.Text = "Path to solo.exe";
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Image = ((System.Drawing.Image)(resources.GetObject("m_bannerImage.Image")));
            this.m_bannerImage.ImageLocation = "";
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(376, 94);
            this.m_bannerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_bannerImage.TabIndex = 0;
            this.m_bannerImage.TabStop = false;
            // 
            // grp_keygen
            // 
            this.grp_keygen.Controls.Add(this.txt_keyField);
            this.grp_keygen.Controls.Add(this.btn_generateKey);
            this.grp_keygen.Controls.Add(this.lbl_keyWarning);
            this.grp_keygen.Location = new System.Drawing.Point(12, 223);
            this.grp_keygen.Name = "grp_keygen";
            this.grp_keygen.Size = new System.Drawing.Size(352, 112);
            this.grp_keygen.TabIndex = 6;
            this.grp_keygen.TabStop = false;
            this.grp_keygen.Text = "Genereate Solo Key";
            // 
            // txt_keyField
            // 
            this.txt_keyField.Location = new System.Drawing.Point(9, 86);
            this.txt_keyField.Name = "t_keyField";
            this.txt_keyField.ReadOnly = true;
            this.txt_keyField.Size = new System.Drawing.Size(262, 20);
            this.txt_keyField.TabIndex = 7;
            // 
            // btn_generateKey
            // 
            this.btn_generateKey.Enabled = false;
            this.btn_generateKey.Location = new System.Drawing.Point(8, 24);
            this.btn_generateKey.Name = "btn_generateKey";
            this.btn_generateKey.Size = new System.Drawing.Size(99, 23);
            this.btn_generateKey.TabIndex = 7;
            this.btn_generateKey.Text = "&Generate Key";
            this.btn_generateKey.UseVisualStyleBackColor = true;
            this.btn_generateKey.Click += new System.EventHandler(this.btn_generateKey_Click);
            // 
            // lbl_keyWarning
            // 
            this.lbl_keyWarning.AutoSize = true;
            this.lbl_keyWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_keyWarning.Location = new System.Drawing.Point(6, 53);
            this.lbl_keyWarning.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbl_keyWarning.Name = "l_keyWarning";
            this.lbl_keyWarning.Size = new System.Drawing.Size(341, 26);
            this.lbl_keyWarning.TabIndex = 7;
            this.lbl_keyWarning.Text = "Note: A solo executable should be contained in your python path\'s site packages!";
            // 
            // SoloKeeCreationForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancle;
            this.ClientSize = new System.Drawing.Size(376, 376);
            this.Controls.Add(this.grp_keygen);
            this.Controls.Add(this.grp_soloConfig);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.m_bannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoloKeeCreationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.grp_soloConfig.ResumeLayout(false);
            this.grp_soloConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.m_ctxMenu.ResumeLayout(false);
            this.grp_keygen.ResumeLayout(false);
            this.grp_keygen.PerformLayout();
            this.ResumeLayout(false);

		}


        #endregion

        private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Button btn_cancle;
		private System.Windows.Forms.TextBox txt_soloPath;
		private System.Windows.Forms.GroupBox grp_soloConfig;
		private System.Windows.Forms.Label lbl_pythonPath;
		private KeePass.UI.CustomContextMenuStripEx m_ctxMenu;
		private System.Windows.Forms.ToolStripMenuItem m_ctxHelp;
		private System.Windows.Forms.ToolStripSeparator m_ctxSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen128;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen256;
        private System.Windows.Forms.Button btn_browseSoloPath;
        private System.Windows.Forms.Label lbl_explPython;
        private System.Windows.Forms.GroupBox grp_keygen;
        private System.Windows.Forms.Button btn_generateKey;
        private System.Windows.Forms.Label lbl_keyWarning;
        private System.Windows.Forms.TextBox txt_keyField;

       
    }
}