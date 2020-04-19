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
using System.Diagnostics;
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

			string strTitle = "Configure OTP Lock";
			string strDesc = "Protect the database using an OTP token.";

			this.Text = strTitle;
			BannerFactory.CreateBannerEx(this, m_bannerImage,
				OkpRes.B48x48_CryptoChip, strTitle, strDesc);

			//OtpKeyProvExt.ConfigureHelpMenuItem(m_ctxHelp);

			if((m_otpInfo.OtpLength >= m_numOtpLen.Minimum) &&
				(m_otpInfo.OtpLength <= m_numOtpLen.Maximum))
				m_numOtpLen.Value = m_otpInfo.OtpLength;
			else { Debug.Assert(false); }

			if((m_otpInfo.OtpsRequired >= m_numOtpsReq.Minimum) &&
				(m_otpInfo.OtpsRequired <= m_numOtpsReq.Maximum))
				m_numOtpsReq.Value = m_otpInfo.OtpsRequired;
			else { Debug.Assert(false); }

			if((m_otpInfo.LookAheadCount >= m_numLookAhead.Minimum) &&
				(m_otpInfo.LookAheadCount <= m_numLookAhead.Maximum))
				m_numLookAhead.Value = m_otpInfo.LookAheadCount;
			else { Debug.Assert(false); }

			foreach(string strFmt in EncodingUtil.Formats)
				m_cmbSecretFmt.Items.Add(strFmt);
			m_cmbSecretFmt.SelectedIndex = 0;

			if(m_otpInfo.Secret != null)
				m_pythonPath.Text = MemUtil.ByteArrayToHexString(m_otpInfo.Secret);

			foreach(string strCtrFmt in EncodingUtil.Formats)
				m_cmbCtrFmt.Items.Add(strCtrFmt);
			m_cmbCtrFmt.SelectedIndex = 4;

			m_tbCounter.Text = m_otpInfo.Counter.ToString();

			EnableControlsEx();
			UIUtil.SetFocus(m_pythonPath, this);
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			GlobalWindowManager.RemoveWindow(this);
		}

		private byte[] ParseSecret()
		{
			OtpDataFmt? fmt = EncodingUtil.GetOtpDataFormat(m_cmbSecretFmt);
			if(!fmt.HasValue) return null;

			return EncodingUtil.ParseKey(m_pythonPath.Text, fmt.Value);
		}

		private ulong? ParseCounter()
		{
			OtpDataFmt? fmt = EncodingUtil.GetOtpDataFormat(m_cmbCtrFmt);
			if(!fmt.HasValue) return null;

			return EncodingUtil.ParseCounter(m_tbCounter.Text, fmt.Value);
		}

		private void OnBtnOK(object sender, EventArgs e)
		{
			byte[] pbSecret = ParseSecret();
			ulong? uCounter = ParseCounter();
			if((pbSecret == null) || !uCounter.HasValue)
			{
				MessageService.ShowWarning("Please enter valid values for the OTP secret and the counter!");

				this.DialogResult = DialogResult.None;
				return;
			}

			m_otpInfo.OtpLength = (uint)m_numOtpLen.Value;
			m_otpInfo.OtpsRequired = (uint)m_numOtpsReq.Value;
			m_otpInfo.LookAheadCount = (uint)m_numLookAhead.Value;

			m_otpInfo.Secret = pbSecret;
			m_otpInfo.Counter = uCounter.Value;
		}

		private void EnableControlsEx()
		{
			bool bOK = (ParseSecret() != null);
			bOK &= ParseCounter().HasValue;
			m_btnOK.Enabled = bOK;
		}

		private void OnSecretTextChanged(object sender, EventArgs e)
		{
			EnableControlsEx();
		}

		private void OnCounterTextChanged(object sender, EventArgs e)
		{
			EnableControlsEx();
		}

		private void OnSecretFmtSelectedIndexChanged(object sender, EventArgs e)
		{
			EnableControlsEx();
		}

		private void OnCtrSelectedIndexChanged(object sender, EventArgs e)
		{
			EnableControlsEx();
		}

		private void OnCtxHelp(object sender, EventArgs e)
		{
			
		}

		private void OnCtxKeyGen128(object sender, EventArgs e)
		{
			GenerateKey();
		}


		private void GenerateKey()
		{
			
		}

		private void OnBtnTools(object sender, EventArgs e)
		{
			m_ctxMenu.ShowEx(m_btnTools);
		}

		private void m_grpData_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
