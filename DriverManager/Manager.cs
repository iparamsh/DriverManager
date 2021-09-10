using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverManager
{
    public partial class Manager : Form
    {
        CMDManager cmd = new CMDManager();
        string filePath;
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {   
        
        }

        private void LoadDriver_Click(object sender, EventArgs e)
        {
            startFileDialog();
            if (filePath != null)
            {
                cmd.startCMD();
                cmd.writeCMD("sc create krnlManagerDriver type= kernel binpath=\"" + filePath + "\"");
                cmd.writeCMD("sc start krnlManagerDriver");
                cmd.closeCMD();
                MessageBox.Show("Driver loaded!");
            }
        }

        private void UnloadDriver_Click(object sender, EventArgs e)
        {
            cmd.startCMD();
            cmd.writeCMD("sc stop krnlManagerDriver");
            cmd.writeCMD("sc delete krnlManagerDriver");
            MessageBox.Show("Driver unloaded!");
            cmd.closeCMD();
        }

        private void TestSigningOn_Click(object sender, EventArgs e)
        {
            testSignSwitch(true);
        }

        private void TestSigningOff_Click(object sender, EventArgs e)
        {
            testSignSwitch(false);
        }

        private void testSignSwitch(bool isTestSigningOn) 
        {
            cmd.startCMD();
            if (isTestSigningOn)
                cmd.writeCMD("bcdedit /set testsigning on");
            else
                cmd.writeCMD("bcdedit /set testsigning off");

            cmd.closeCMD();
            MessageBox.Show("All good, restart your PC");
        }

        private void startFileDialog() 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "sys files (*.sys)|*.sys|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
        }
    }
}
