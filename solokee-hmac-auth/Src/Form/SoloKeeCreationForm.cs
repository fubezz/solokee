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
using KeePassLib.Utility;

namespace SoloKee.Forms
{
	public partial class SoloKeeCreationForm : Form
	{
		//private OtpInfo m_otpInfo = null;
		private KeyProviderQueryContext m_kpContext = null;

		//public void InitEx(OtpInfo otpInfo, KeyProviderQueryContext ctx)
		//{
		//	m_otpInfo = otpInfo;
		//	m_kpContext = ctx;
		//}

		public SoloKeeCreationForm()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			//if(m_otpInfo == null) throw new InvalidOperationException();

			GlobalWindowManager.AddWindow(this);
			//OtpKeyProvExt.ConfigureHelpMenuItem(m_ctxHelp);
			UIUtil.SetFocus(text_pythonPath, this);
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			GlobalWindowManager.RemoveWindow(this);
		}

		
		private void OnBtnOK(object sender, EventArgs e)
		{
			//byte[] pbSecret = ParseSecret();
			//ulong? uCounter = ParseCounter();
			if((null == null) )
			{
				MessageService.ShowWarning("Please enter valid values for the OTP secret and the counter!");

				this.DialogResult = DialogResult.None;
				return;
			}

			//m_otpInfo.OtpLength = (uint)m_numOtpLen.Value;
			//m_otpInfo.OtpsRequired = (uint)m_numOtpsReq.Value;
			//m_otpInfo.LookAheadCount = (uint)m_numLookAhead.Value;

			//m_otpInfo.Secret = pbSecret;
			//m_otpInfo.Counter = uCounter.Value;
		}


		private void GenerateKey()
		{
			
		}

		private void m_grpData_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
