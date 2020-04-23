using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoloKee
{
    public class SoloKeyWrapper
    {
        private string soloCmd;
        private string challenge;
        private string credentialId;
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public SoloKeyWrapper(string soloPath)
        {
            soloCmd = soloPath;
            random = new Random();
            challenge = SoloKeyWrapper.RandomString(15);
        }

        private ProcessStartInfo getProcessInfo()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = soloCmd;
            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
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


        public string createCredWithHMACExt()
        {

            Process cmd = new Process();
            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = "key make-credential";
            cmd.EnableRaisingEvents = true;
            cmd.OutputDataReceived += new DataReceivedEventHandler((sender, output) =>
            {
                if (!string.IsNullOrEmpty(output.Data))
                {
                    Console.WriteLine(output.Data);
                    if (output.Data.Length == 140 && Regex.IsMatch(output.Data, @"\A\b[0-9a-fA-F]+\b\Z"))
                    {
                        credentialId = output.Data;
                    }
                }
                
            });
            cmd.ErrorDataReceived += new DataReceivedEventHandler((sender, error) =>
            {
                if (!string.IsNullOrEmpty(error.Data))
                {
                    Console.WriteLine("Error: " + error.Data);
                }
            });
            cmd.Start();

            cmd.BeginOutputReadLine();
            cmd.BeginErrorReadLine();

            cmd.WaitForExit();
            cmd.CancelOutputRead();
            return credentialId;
            

        }


        public void getChallengeResponse(string credId)
        {
           
            Process cmd = new Process();
            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = string.Format("key challenge-response {0} {1}", credentialId, challenge);
            cmd.EnableRaisingEvents = true;
            cmd.OutputDataReceived += new DataReceivedEventHandler((sender, output) =>
            {
                if (!string.IsNullOrEmpty(output.Data))
                {
                    if (!string.IsNullOrEmpty(output.Data))
                    {
                        Console.WriteLine(output.Data);
                        if (output.Data.Length == 64 && Regex.IsMatch(output.Data, @"\A\b[0-9a-fA-F]+\b\Z"))
                        {
                            credentialId = output.Data;
                        }
                    }
                }

            });
            cmd.ErrorDataReceived += new DataReceivedEventHandler((sender, error) =>
            {
                if (!string.IsNullOrEmpty(error.Data))
                {
                    Console.WriteLine("Error: " + error.Data);
                }
            });
            cmd.Start();

            cmd.BeginOutputReadLine();
            cmd.BeginErrorReadLine();

            cmd.WaitForExit();
            cmd.CancelOutputRead();


        }
    }
}
