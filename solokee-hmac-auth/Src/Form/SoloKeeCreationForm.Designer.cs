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
            this.m_pythonPath = new System.Windows.Forms.TextBox();
            this.g_soloConfig = new System.Windows.Forms.GroupBox();
            this.m_lblSecret = new System.Windows.Forms.Label();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_btnTools = new System.Windows.Forms.Button();
            this.m_ctxMenu = new KeePass.UI.CustomContextMenuStripEx(this.components);
            this.m_ctxHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.m_ctxKeyGen128 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxKeyGen256 = new System.Windows.Forms.ToolStripMenuItem();
            this.b_browsePythonPath = new System.Windows.Forms.Button();
            this.l_explPython = new System.Windows.Forms.Label();
            this.g_keygen = new System.Windows.Forms.GroupBox();
            this.l_keyWarning = new System.Windows.Forms.Label();
            this.b_generateKey = new System.Windows.Forms.Button();
            this.g_soloConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_ctxMenu.SuspendLayout();
            this.g_keygen.SuspendLayout();
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
            // m_pythonPath
            // 
            this.m_pythonPath.Location = new System.Drawing.Point(9, 72);
            this.m_pythonPath.Name = "m_pythonPath";
            this.m_pythonPath.Size = new System.Drawing.Size(262, 20);
            this.m_pythonPath.TabIndex = 1;
            this.m_pythonPath.TextChanged += new System.EventHandler(this.OnSecretTextChanged);
            // 
            // g_soloConfig
            // 
            this.g_soloConfig.Controls.Add(this.l_explPython);
            this.g_soloConfig.Controls.Add(this.b_browsePythonPath);
            this.g_soloConfig.Controls.Add(this.m_lblSecret);
            this.g_soloConfig.Controls.Add(this.m_pythonPath);
            this.g_soloConfig.Location = new System.Drawing.Point(12, 109);
            this.g_soloConfig.Name = "g_soloConfig";
            this.g_soloConfig.Size = new System.Drawing.Size(352, 108);
            this.g_soloConfig.TabIndex = 3;
            this.g_soloConfig.TabStop = false;
            this.g_soloConfig.Text = "SoloKee Configuration";
            this.g_soloConfig.Enter += new System.EventHandler(this.m_grpData_Enter);
            // 
            // m_lblSecret
            // 
            this.m_lblSecret.AutoSize = true;
            this.m_lblSecret.Location = new System.Drawing.Point(6, 56);
            this.m_lblSecret.Name = "m_lblSecret";
            this.m_lblSecret.Size = new System.Drawing.Size(65, 13);
            this.m_lblSecret.TabIndex = 0;
            this.m_lblSecret.Text = "Python Path";
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
            // m_btnTools
            // 
            this.m_btnTools.Location = new System.Drawing.Point(12, 341);
            this.m_btnTools.Name = "m_btnTools";
            this.m_btnTools.Size = new System.Drawing.Size(74, 23);
            this.m_btnTools.TabIndex = 5;
            this.m_btnTools.Text = "&Tools";
            this.m_btnTools.UseVisualStyleBackColor = true;
            this.m_btnTools.Click += new System.EventHandler(this.OnBtnTools);
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
            this.m_ctxHelp.Click += new System.EventHandler(this.OnCtxHelp);
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
            // b_browsePythonPath
            // 
            this.b_browsePythonPath.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_browsePythonPath.Location = new System.Drawing.Point(276, 71);
            this.b_browsePythonPath.Name = "b_browsePythonPath";
            this.b_browsePythonPath.Size = new System.Drawing.Size(64, 23);
            this.b_browsePythonPath.TabIndex = 6;
            this.b_browsePythonPath.Text = "Browse";
            this.b_browsePythonPath.UseVisualStyleBackColor = true;
            this.b_browsePythonPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_explPython
            // 
            this.l_explPython.AutoSize = true;
            this.l_explPython.ForeColor = System.Drawing.Color.Black;
            this.l_explPython.Location = new System.Drawing.Point(6, 21);
            this.l_explPython.MaximumSize = new System.Drawing.Size(350, 0);
            this.l_explPython.Name = "l_explPython";
            this.l_explPython.Size = new System.Drawing.Size(341, 26);
            this.l_explPython.TabIndex = 4;
            this.l_explPython.Text = "Note: A solo executable should be contained in your python path\'s site packages!";
            // 
            // g_keygen
            // 
            this.g_keygen.Controls.Add(this.b_generateKey);
            this.g_keygen.Controls.Add(this.l_keyWarning);
            this.g_keygen.Location = new System.Drawing.Point(12, 223);
            this.g_keygen.Name = "g_keygen";
            this.g_keygen.Size = new System.Drawing.Size(352, 112);
            this.g_keygen.TabIndex = 6;
            this.g_keygen.TabStop = false;
            this.g_keygen.Text = "Genereate Solo Key";
            // 
            // l_keyWarning
            // 
            this.l_keyWarning.AutoSize = true;
            this.l_keyWarning.ForeColor = System.Drawing.Color.Red;
            this.l_keyWarning.Location = new System.Drawing.Point(0, 51);
            this.l_keyWarning.MaximumSize = new System.Drawing.Size(350, 0);
            this.l_keyWarning.Name = "l_keyWarning";
            this.l_keyWarning.Size = new System.Drawing.Size(341, 26);
            this.l_keyWarning.TabIndex = 7;
            this.l_keyWarning.Text = "Note: A solo executable should be contained in your python path\'s site packages!";
            // 
            // b_generateKey
            // 
            this.b_generateKey.Location = new System.Drawing.Point(9, 25);
            this.b_generateKey.Name = "b_generateKey";
            this.b_generateKey.Size = new System.Drawing.Size(99, 23);
            this.b_generateKey.TabIndex = 7;
            this.b_generateKey.Text = "&Generate Key";
            this.b_generateKey.UseVisualStyleBackColor = true;
            // 
            // SoloKeeCreationForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(376, 376);
            this.Controls.Add(this.g_keygen);
            this.Controls.Add(this.g_soloConfig);
            this.Controls.Add(this.m_btnTools);
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
            this.g_soloConfig.ResumeLayout(false);
            this.g_soloConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.m_ctxMenu.ResumeLayout(false);
            this.g_keygen.ResumeLayout(false);
            this.g_keygen.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TextBox m_pythonPath;
		private System.Windows.Forms.GroupBox g_soloConfig;
		private System.Windows.Forms.Label m_lblSecret;
		private System.Windows.Forms.Button m_btnTools;
		private KeePass.UI.CustomContextMenuStripEx m_ctxMenu;
		private System.Windows.Forms.ToolStripMenuItem m_ctxHelp;
		private System.Windows.Forms.ToolStripSeparator m_ctxSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen128;
		private System.Windows.Forms.ToolStripMenuItem m_ctxKeyGen256;
        private System.Windows.Forms.Button b_browsePythonPath;
        private System.Windows.Forms.Label l_explPython;
        private System.Windows.Forms.GroupBox g_keygen;
        private System.Windows.Forms.Button b_generateKey;
        private System.Windows.Forms.Label l_keyWarning;
    }
}