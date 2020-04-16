using System;
using System.Diagnostics;


namespace SoloKeeHmac.Src
{
    class SoloKeyWrapper
    {
        private string soloCmd;

        public void init()
        {
            soloCmd = "F:/Users/Fubezz/AppData/Local/Programs/Python/Python38-32/Scripts/solo.exe";
        }


        public void wink()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = soloCmd;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Arguments = "key wink";
            cmd.Start();

            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        public void makeCredWithHMAC()
        {

        }

    }
}
