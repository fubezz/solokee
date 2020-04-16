using System;

using KeePassLib.Keys;
using CTAP;
using SoloKeeHmac.Src;

namespace SoloKeeHmac
{
	public sealed class HMACKeyProvider : KeyProvider
	{
		public override string Name
		{
			get { return "FIDO2 - HMAC Secret Provider"; }
		}

		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{
			// Return a sample key. In a real key provider plugin, the key
			// would be retrieved from smart card, USB device, ...

			SoloKeyWrapper wrapperClient = new SoloKeyWrapper();

			wrapperClient.init();
			wrapperClient.wink();


			return new byte[] { 0x6b, 0x65, 0x65, 0x70, 0x61, 0x73, 0x73 };
			
		}

	}
}


