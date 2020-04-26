using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoloKee
{
    public class SoloKeyWrapper
    {
        private string soloCmd;
        private static Random random = new Random();

        private string challenge;

        public string Challenge
        {
            get { return challenge; }
        }

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
            cmd.WaitForExit(10000);
           
        }


        public string createCredIdHMAC()
        {

            string credId = null;
            Process cmd = new Process();
            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = "key make-credential";
            cmd.EnableRaisingEvents = true;
            cmd.OutputDataReceived += new DataReceivedEventHandler((sender, output) =>
            {
                if (!string.IsNullOrEmpty(output.Data))
                {
                    if (output.Data.Length == 140 && Regex.IsMatch(output.Data, @"\A\b[0-9a-fA-F]+\b\Z"))
                    {
                        Console.WriteLine(output.Data);
                        credId = output.Data;
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
            cmd.WaitForExit(10000);
            cmd.CancelOutputRead();

            if (cmd.HasExited)
            {
                return credId;
            }
            else
            {
                return null;
            }
            
            

        }


        public string getChallengeResponse(string credId)
        {

            string key = null;

            Process cmd = new Process();
            cmd.StartInfo = getProcessInfo();
            cmd.StartInfo.Arguments = string.Format("key challenge-response {0} {1}", credId, challenge);
            cmd.EnableRaisingEvents = true;
            cmd.OutputDataReceived += new DataReceivedEventHandler((sender, output) =>
            {
                if (!string.IsNullOrEmpty(output.Data))
                {
                    if (!string.IsNullOrEmpty(output.Data))
                    {
                        
                        if (output.Data.Length == 64 && Regex.IsMatch(output.Data, @"\A\b[0-9a-fA-F]+\b\Z"))
                        {
                            Console.WriteLine("Got Key: " + output.Data);
                            key = output.Data;
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

            cmd.WaitForExit(10000);
            cmd.CancelOutputRead();

            if (cmd.HasExited)
            {
                return key;
            }
            else
            {
                return null;
            }

        }
    }
}
