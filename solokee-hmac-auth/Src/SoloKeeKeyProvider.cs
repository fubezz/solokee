﻿using System;
using System.Windows.Forms;
using KeePass.UI;
using KeePassLib.Keys;
using KeePassLib.Utility;
using SoloKee.Forms;

namespace SoloKee
{
	public class SoloKeyObject
	{
		public string credId;
		public string key;
		internal object challenge;
	}

	public sealed class SoloKeyProvider : KeyProvider
	{
		public override string Name
		{
			get { return "FIDO2 - HMAC Secret Provider"; }
		}

		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{
			// Return a sample key. In a real key provider plugin, the key
			// would be retrieved from smart card, USB device, ...

			try
			{
				byte[] pb = (ctx.CreatingNewKey ? Create(ctx) : Open(ctx));
				if (pb == null) return null;

				// KeePass clears the returned byte array, thus make a copy
				byte[] pbRet = new byte[pb.Length];
				Array.Copy(pb, pbRet, pb.Length);
				return pbRet;
			}
			catch (Exception ex) { MessageService.ShowWarning(ex.Message); }
			return null;
			
		}

		private byte[] Open(KeyProviderQueryContext ctx)
		{
			throw new NotImplementedException();
		}

		private static byte[] Create(KeyProviderQueryContext ctx)
		{

			//IOConnectionInfo iocPrev = GetAuxFileIoc(ctx);
			//OtpInfo otpInfo = OtpInfo.Load(iocPrev);
			//if (otpInfo == null) otpInfo = new OtpInfo();

			SoloKeeCreationForm dlg = new SoloKeeCreationForm();
			SoloKeyObject creadentialObject = new SoloKeyObject();
			dlg.InitEx(creadentialObject,ctx);
			//dlg.InitEx(otpInfo, ctx);

			if (UIUtil.ShowDialogAndDestroy(dlg) != DialogResult.OK)
				return null;
			else
				return new System.Text.UTF8Encoding().GetBytes(creadentialObject.key);
		}

	}
}


