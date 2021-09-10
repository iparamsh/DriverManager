using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DriverManager
{
    class CMDManager
    {
        private Process process = new Process();
        public void startCMD()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }
        public void writeCMD(string input)
        {
            process.StandardInput.WriteLine(input);
            process.StandardInput.Flush();
        }
        public void closeCMD()
        {
            process.Close();
        }
    }
}
