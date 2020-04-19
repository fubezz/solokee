using System;
using System.Diagnostics;


namespace SoloKee
{
    class SoloKeyWrapper
    {
        private string soloCmd;
        

        public SoloKeyWrapper()
        {
            soloCmd = getSoloCMD();
        }

        private string getSoloCMD()
        {
            return "F:/Users/Fubezz/AppData/Local/Programs/Python/Python38-32/Scripts/solo.exe";
        }

        private ProcessStartInfo getProcessInfo()
        {

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = soloCmd;
            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            return processInfo;
        }

        public void wink()
        {
            Process cmd = new Process();

            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = "key wink";
            cmd.Start();

            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private static void HandleMakeCredOutput(object sendingProcess, DataReceivedEventArgs outLine) 
        {
            if (!string.IsNullOrEmpty(outLine.Data))
            {
                Console.WriteLine(outLine.Data);
            }
            Console.WriteLine(outLine.Data);
        }

        public void makeCredWithHMAC()
        {
            Process cmd = new Process();

            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = "key make-credential";
            cmd.OutputDataReceived += new DataReceivedEventHandler(HandleMakeCredOutput);
            cmd.Start();

        
            cmd.WaitForExit();
        }

    }
}
