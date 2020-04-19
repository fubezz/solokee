using System;
using System.Windows.Forms;
using KeePass.Plugins;


namespace SoloKee
{
    public class SoloKeeExt : Plugin
    {
		private IPluginHost m_host = null;
		private SoloKeyProvider hmacProv = new SoloKeyProvider();

		public override bool Initialize(IPluginHost host)
		{
			if (host == null) return false;
			m_host = host;
			m_host.KeyProviderPool.Add(hmacProv);
			return true;
		}

		public override ToolStripMenuItem GetMenuItem(PluginMenuType t)
		{
			// Provide a menu item for the main location(s)
			if (t == PluginMenuType.Main)
			{
				ToolStripMenuItem tsmi = new ToolStripMenuItem();
				tsmi.Text = "Abcd Options";
				tsmi.Click += this.OnOptionsClicked;
				return tsmi;
			}

			return null; // No menu items in other locations
		}

		private void OnOptionsClicked(object sender, EventArgs e)
		{
			// Called when the menu item is clicked
		}

		public override void Terminate()
		{
			m_host.KeyProviderPool.Remove(hmacProv);
		}
	}
}
