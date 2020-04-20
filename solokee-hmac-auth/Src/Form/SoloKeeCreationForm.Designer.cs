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
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.text_pythonPath = new System.Windows.Forms.TextBox();
            this.grp_soloConfig = new System.Windows.Forms.GroupBox();
            this.lbl_explPython = new System.Windows.Forms.Label();
            this.btn_browsePythonPath = new System.Windows.Forms.Button();
            this.lbl_pythonPath = new System.Windows.Forms.Label();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_ctxMenu = new KeePass.UI.CustomContextMenuStripEx(this.components);
            this.m_ctxHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.m_ctxKeyGen128 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxKeyGen256 = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_keygen = new System.Windows.Forms.GroupBox();
            this.t_keyField = new System.Windows.Forms.TextBox();
            this.btn_generateKey = new System.Windows.Forms.Button();
            this.l_keyWarning = new System.Windows.Forms.Label();
            this.grp_soloConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_ctxMenu.SuspendLayout();
            this.grp_keygen.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(208, 341);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 0;
            this.m_btnOK.Text = "&OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(289, 341);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "&Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // text_pythonPath
            // 
            this.text_pythonPath.Location = new System.Drawing.Point(9, 72);
            this.text_pythonPath.Name = "text_pythonPath";
            this.text_pythonPath.ReadOnly = true;
            this.text_pythonPath.Size = new System.Drawing.Size(262, 20);
            this.text_pythonPath.TabIndex = 1;
            // 
            // grp_soloConfig
            // 
            this.grp_soloConfig.Controls.Add(this.lbl_explPython);
            this.grp_soloConfig.Controls.Add(this.btn_browsePythonPath);
            this.grp_soloConfig.Controls.Add(this.lbl_pythonPath);
            this.grp_soloConfig.Controls.Add(this.text_pythonPath);
            this.grp_soloConfig.Location = new System.Drawing.Point(12, 109);
            this.grp_soloConfig.Name = "grp_soloConfig";
            this.grp_soloConfig.Size = new System.Drawing.Size(352, 108);
            this.grp_soloConfig.TabIndex = 3;
            this.grp_soloConfig.TabStop = false;
            this.grp_soloConfig.Text = "SoloKee Configuration";
            this.grp_soloConfig.Enter += new System.EventHandler(this.m_grpData_Enter);
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
            this.btn_browsePythonPath.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_browsePythonPath.Location = new System.Drawing.Point(276, 71);
            this.btn_browsePythonPath.Name = "btn_browsePythonPath";
            this.btn_browsePythonPath.Size = new System.Drawing.Size(64, 23);
            this.btn_browsePythonPath.TabIndex = 6;
            this.btn_browsePythonPath.Text = "Browse";
            this.btn_browsePythonPath.UseVisualStyleBackColor = true;
            this.btn_browsePythonPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_pythonPath
            // 
            this.lbl_pythonPath.AutoSize = true;
            this.lbl_pythonPath.Location = new System.Drawing.Point(6, 56);
            this.lbl_pythonPath.Name = "lbl_pythonPath";
            this.lbl_pythonPath.Size = new System.Drawing.Size(65, 13);
            this.lbl_pythonPath.TabIndex = 0;
            this.lbl_pythonPath.Text = "Python Path";
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
            // m_ctxMenu
            // 
            this.m_ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxHelp,
            this.m_ctxSep0,
            this.m_ctxKeyGen128,
            this.m_ctxKeyGen256});
            this.m_ctxMenu.Name = "m_ctxMenu";
            this.m_ctxMenu.Size = new System.Drawing.Size(100, 76);
            // 
            // m_ctxHelp
            // 
            this.m_ctxHelp.Name = "m_ctxHelp";
            this.m_ctxHelp.Size = new System.Drawing.Size(99, 22);
            this.m_ctxHelp.Text = "&Help";
            // 
            // m_ctxSep0
            // 
            this.m_ctxSep0.Name = "m_ctxSep0";
            this.m_ctxSep0.Size = new System.Drawing.Size(96, 6);
            // 
            // m_ctxKeyGen128
            // 
            this.m_ctxKeyGen128.Name = "m_ctxKeyGen128";
            this.m_ctxKeyGen128.Size = new System.Drawing.Size(99, 22);
            // 
            // m_ctxKeyGen256
            // 
            this.m_ctxKeyGen256.Name = "m_ctxKeyGen256";
            this.m_ctxKeyGen256.Size = new System.Drawing.Size(99, 22);
            // 
            // grp_keygen
            // 
            this.grp_keygen.Controls.Add(this.t_keyField);
            this.grp_keygen.Controls.Add(this.btn_generateKey);
            this.grp_keygen.Controls.Add(this.l_keyWarning);
            this.grp_keygen.Location = new System.Drawing.Point(12, 223);
            this.grp_keygen.Name = "grp_keygen";
            this.grp_keygen.Size = new System.Drawing.Size(352, 112);
            this.grp_keygen.TabIndex = 6;
            this.grp_keygen.TabStop = false;
            this.grp_keygen.Text = "Genereate Solo Key";
            // 
            // t_keyField
            // 
            this.t_keyField.Location = new System.Drawing.Point(9, 86);
            this.t_keyField.Name = "t_keyField";
            this.t_keyField.ReadOnly = true;
            this.t_keyField.Size = new System.Drawing.Size(262, 20);
            this.t_keyField.TabIndex = 7;
            // 
            // btn_generateKey
            // 
            this.btn_generateKey.Location = new System.Drawing.Point(8, 24);
            this.btn_generateKey.Name = "btn_generateKey";
            this.btn_generateKey.Size = new System.Drawing.Size(99, 23);
            this.btn_generateKey.TabIndex = 7;
            this.btn_generateKey.Text = "&Generate Key";
            this.btn_generateKey.UseVisualStyleBackColor = true;
            // 
            // l_keyWarning
            // 
            this.l_keyWarning.AutoSize = true;
            this.l_keyWarning.ForeColor = System.Drawing.Color.Red;
            this.l_keyWarning.Location = new System.Drawing.Point(6, 53);
            this.l_keyWarning.MaximumSize = new System.Drawing.Size(350, 0);
            this.l_keyWarning.Name = "l_keyWarning";
            this.l_keyWarning.Size = new System.Drawing.Size(341, 26);
            this.l_keyWarning.TabIndex = 7;
            this.l_keyWarning.Text = "Note: A solo executable should be contained in your python path\'s site packages!";
            // 
            // SoloKeeCreationForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(376, 376);
            this.Controls.Add(this.grp_keygen);
            this.Controls.Add(this.grp_soloConfig);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
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
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TextBox text_pythonPath;
		private System.Windows.Forms.GroupBox grp_soloConfig;
		private System.Windows.Forms.Label lbl_pythonPath;
		private KeePass.UI.CustomContextMenuStripEx m_ctxMenu;
		private System.Windows.Forms.ToolStripMenuItem m_ctxHelp;
		private System.Windows.Forms.ToolStripSeparator m_ctxSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen128;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen256;
        private System.Windows.Forms.Button btn_browsePythonPath;
        private System.Windows.Forms.Label lbl_explPython;
        private System.Windows.Forms.GroupBox grp_keygen;
        private System.Windows.Forms.Button btn_generateKey;
        private System.Windows.Forms.Label l_keyWarning;
        private System.Windows.Forms.TextBox t_keyField;
    }
}