/*
  OtpKeyProv Plugin
  Copyright (C) 2011-2018 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Threading;
using System.Windows.Forms;

using KeePass.UI;
using KeePassLib.Keys;

namespace SoloKee.Forms
{
	public partial class SoloKeeCreationForm : Form
	{
		private KeyProviderQueryContext m_kpContext = null;
		private SoloKeyObject credentialObject = null;
		private string soloPath = null;
		private string generatedCredId;
		private string generatedKey;
		private string challenge;

		public SoloKeeCreationForm()
		{
			InitializeComponent();
		}

		public void InitEx (SoloKeyObject credObj, KeyProviderQueryContext ctx)
		{
			m_kpContext = ctx;
			this.credentialObject = credObj;

		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			GlobalWindowManager.AddWindow(this);


			string strTitle = "Configure SoloKee Keyprovider";
			string strDesc = "Protect the database with your solo key.";
			Console.WriteLine(strTitle);

			BannerFactory.CreateBannerEx(this, m_bannerImage,
				null, strTitle, strDesc);

			tb_log.AppendText("Set solo application path...\r\n");

			UIUtil.SetFocus(txt_soloPath, this);
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			Console.WriteLine("Closing window");
			GlobalWindowManager.RemoveWindow(this);
		}

		
		private void OnBtnOK(object sender, EventArgs e)
		{
			if (generatedCredId != null && generatedKey != null)
			{
				credentialObject.credId = generatedCredId;
				credentialObject.key = generatedKey;
				credentialObject.challenge = challenge;
			}	
		}

		private void OnBtnBrowse(object sender, EventArgs e)
		{
			var FD = new OpenFileDialog();

			if (FD.ShowDialog() == DialogResult.OK)
			{
				string fileToOpen = FD.FileName;
				this.lbl_explPython.Text = fileToOpen;
				Console.WriteLine(fileToOpen);
				if (fileToOpen != null && fileToOpen.Contains("solo.exe")) ;
				{
					this.soloPath = fileToOpen;
					tb_log.AppendText("Found library!\r\n");
					this.txt_soloPath.Text = fileToOpen;
					this.btn_generateKey.Enabled = true;
					this.btn_wink.Enabled = true;
					UIUtil.SetFocus(this.btn_generateKey, this);
				}
			}

		}

		private void onBtnGenerateKey(object sender, EventArgs e)
		{
			SoloKeyWrapper provider = new SoloKeyWrapper(soloPath);
			try
			{
				tb_log.AppendText("Creating credential id...\r\n");
				generatedCredId = provider.createCredIdHMAC();
				tb_log.AppendText(generatedCredId  + "\r\n");
				tb_log.AppendText("Creating key...\r\n");
				generatedKey = provider.getChallengeResponse(generatedCredId);
				if (generatedKey != null)
				{
					challenge = provider.Challenge;
					tb_log.AppendText("Creating key finished!\r\n");
					txt_keyField.Text = generatedKey;
					btn_ok.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				tb_log.Text = ex.Message;

			}
		}

		private void OnBtnWink(object sender, EventArgs e)
		{
			try { 
				tb_log.Text = "Your solo key should blink...\r\n";
				SoloKeyWrapper provider = new SoloKeyWrapper(soloPath);
				provider.wink();
			}
			catch (Exception ex)
			{
				tb_log.Text = ex.Message;
			}

		}
	}
}
