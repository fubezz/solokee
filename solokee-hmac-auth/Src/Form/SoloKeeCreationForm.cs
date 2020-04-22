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
using System.Windows.Forms;

using KeePass.UI;
using KeePassLib.Keys;

namespace SoloKee.Forms
{
	public partial class SoloKeeCreationForm : Form
	{
		private KeyProviderQueryContext m_kpContext = null;
		private string soloPath = null;
		private string Text = null;
		private string key = null;

		public SoloKeeCreationForm()
		{
			InitializeComponent();
		}

		public void InitEx (string key, KeyProviderQueryContext ctx)
		{
			m_kpContext = ctx;
			this.key = key;

		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			GlobalWindowManager.AddWindow(this);


			string strTitle = "Configure SoloKee Keyprovider";
			string strDesc = "Protect the database with your solo key.";
			Console.WriteLine(strTitle);

			this.Text = strTitle;
			BannerFactory.CreateBannerEx(this, m_bannerImage,
				null, strTitle, strDesc);

			UIUtil.SetFocus(txt_soloPath, this);
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			Console.WriteLine("Closing window");
			GlobalWindowManager.RemoveWindow(this);
		}

		
		private void OnBtnOK(object sender, EventArgs e)
		{
			
			
		}

		private void OnBtnBrowse(object sender, EventArgs e)
		{
			var FD = new OpenFileDialog();
		
			if (FD.ShowDialog() == DialogResult.OK)
			{
				string fileToOpen = FD.FileName;
				Console.WriteLine(fileToOpen);
				if (fileToOpen != null)
				{
					this.soloPath = fileToOpen;
					this.txt_soloPath.Text = fileToOpen;
					this.btn_generateKey.Enabled = true;
					UIUtil.SetFocus(this.btn_generateKey, this);
				}
			}
		}

		private void btn_generateKey_Click(object sender, EventArgs e)
		{
			SoloKeyWrapper wrapper = new SoloKeyWrapper(this.soloPath);

			wrapper.createCredWithHMACExt();
		}

		private void GenerateKey()
		{

		}
	}
}
