using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives.SevenZip;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using System.Threading;

namespace BackUpBear
{
    public partial class Form1 : Form
    {
        private string DirsToBackup;
        private string BackupToDirs;
        private RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\JPetko\BackUpBear");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i > 1000; i++)
            {
                if (key.GetValue("BackupSource"+ i, null) != null)
                {
                    list_DirToBackup.Items.Add(key.GetValue("BackupSource" + i).ToString());
                }
            }
            if (key.GetValue("BackupDest", null) != null)
                tb_BackupToDir.Text = key.GetValue("BackupDest", null).ToString();
        }


        private void pb_DirectoryAdd_Click(object sender, EventArgs e)
        {                            
            if (fb_DirToBackup.ShowDialog() == DialogResult.OK)
            {
                DirsToBackup = fb_DirToBackup.SelectedPath;
                int i = 0;
                foreach(string s in list_DirToBackup.Items)
                {                    
                    key.SetValue("BackupSource" + i, fb_DirToBackup.SelectedPath, RegistryValueKind.String);
                    i++;
                }
            }
            list_DirToBackup.Items.Add(DirsToBackup + "\r\n");

            
        }

        private void pb_DirectoryMinus_Click(object sender, EventArgs e)
        {
            list_DirToBackup.Items.Remove(list_DirToBackup.SelectedItem);
            for (int i = 0; i > 1000; i++)
            {
                if (key.GetValue("BackupSource" + i, null) == list_DirToBackup.SelectedItem)
                {
                    key.SetValue("BackupSource" + i, string.Empty,RegistryValueKind.String);
                }
            }
        }

        private void pb_MappedPlus_Click(object sender, EventArgs e)
        {
            if (fb_BackupDir.ShowDialog() == DialogResult.OK)
            {
                BackupToDirs = fb_BackupDir.SelectedPath;
                tb_BackupToDir.Text = BackupToDirs;
                key.SetValue("BackupDest",fb_BackupDir.SelectedPath,RegistryValueKind.String);
            }            
        }

        private void pb_MappedMinus_Click(object sender, EventArgs e)
        {
            tb_BackupToDir.Text = "";
            key.SetValue("BackupDest", string.Empty, RegistryValueKind.String);
        }

        private void cb_Compress_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Compress.Checked)
            {
                radbut_Zip.Visible = true;
                radbut_Rar.Visible = true;
                radbut_7z.Visible = true;
            }
            else
            {
                radbut_Zip.Visible = false;
                radbut_Rar.Visible = false;
                radbut_7z.Visible = false;
            }
        }

        private void radbut_Zip_CheckedChanged(object sender, EventArgs e)
        {
            //compress output in zip format
        }

        private void radbut_Rar_CheckedChanged(object sender, EventArgs e)
        {
            //compress output in rar format
        }

        private void radbut_7z_CheckedChanged(object sender, EventArgs e)
        {
            //compress output in 7z format
        }

        private void But_StartBackup_Click(object sender, EventArgs e)
        {
            
            //check folder access for source dir

            string NtAccountName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName + @"\Administrator";
            NTAccount nta = new NTAccount(NtAccountName);
            string destPath = tb_BackupToDir.Text.ToString();
            destPath.Replace(@"\r\n", "");

            foreach (string s in list_DirToBackup.Items)
            {
                string sourceDir = s;

                s.Replace("\r\n", string.Empty);

                Directory.CreateDirectory(tb_BackupToDir.Text.ToString() + "\\Backup");
                File.SetAttributes(destPath + "\\Backup", FileAttributes.Normal);
                sourceDir = sourceDir.Trim('\r', '\n');

                Thread thread = new Thread(new ThreadStart(Compress));
                thread.Start();

            }
        }

        private void Compress()
        {
            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.ForeColor = System.Drawing.Color.Firebrick;
            progressBar1.Location = new System.Drawing.Point(14, 222);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(295, 10);
            progressBar1.TabIndex = 18;            
            progressBar1.Visible = true;

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\JPetko\BackUpBear");
            string destPath2 = key.GetValue("BackupDest","").ToString();
            int index = 0;
            
            
            if (cb_Compress.Checked)
            {
                foreach (string s in list_DirToBackup.Items)
                {
                    string sourceDir = s;

                    s.Replace("\r\n", string.Empty);

                    Directory.CreateDirectory(tb_BackupToDir.Text.ToString() + "\\Backup");
                    File.SetAttributes(destPath2 + "\\Backup", FileAttributes.Normal);
                    sourceDir = sourceDir.Trim('\r', '\n');
                    progressBar1.Step = Directory.GetFiles(sourceDir).Length;
                        
                    if (cb_Compress.Checked)
                    {                        
                        if (radbut_Zip.Checked)
                        {
                            using (var archive = ZipArchive.Create())
                            {
                                progressBar1.PerformStep();
                                progressBar1.Update();                                
                                archive.AddAllFromDirectory(sourceDir);
                                archive.SaveTo(tb_BackupToDir.Text.ToString() + "\\Backup " + index + ".zip", CompressionType.Deflate);
                            }
                        }
                        if (radbut_Rar.Checked)
                        {
                            using (var archive = ZipArchive.Create())
                            {
                                progressBar1.PerformStep();
                                progressBar1.Update();
                                archive.AddAllFromDirectory(sourceDir);
                                archive.SaveTo(destPath2 + "\\Backup " + index + ".rar", CompressionType.Rar);
                            }
                        }
                        if (radbut_7z.Checked)
                        {
                            using (var archive = ZipArchive.Create())
                            {
                                progressBar1.PerformStep();
                                progressBar1.Update();
                                archive.AddAllFromDirectory(sourceDir);
                                archive.SaveTo(destPath2 + "\\Backup " + index + ".7z", CompressionType.LZMA);
                            }
                        }
                    }
                    else
                    {

                        string[] files = Directory.GetFiles(sourceDir);

                        for (int i = 0; i < files.Length; i++)
                        {
                            progressBar1.Update();
                            Directory.CreateDirectory(destPath2 + "\\Backup\\Backup " + index.ToString());
                            File.Copy(files[i], destPath2 + "\\Backup\\Backup " + index.ToString() + "\\" + Path.GetFileName(files[i]), true);
                        }
                    }
                    index++;
                }
            }
            progressBar1.Visible = false;
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
