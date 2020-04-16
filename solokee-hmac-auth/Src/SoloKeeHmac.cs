using System;

using KeePass.Plugins;


namespace SoloKeeHmac
{
    public class SoloKeeHmacExt : Plugin
    {
		private IPluginHost m_host = null;
		private HMACKeyProvider hmacProv = new HMACKeyProvider();

		public override bool Initialize(IPluginHost host)
		{
			if (host == null) return false;
			m_host = host;
			m_host.KeyProviderPool.Add(hmacProv);
			return true;
		}

		public override void Terminate()
		{
			m_host.KeyProviderPool.Remove(hmacProv);
		}
	}
}
