﻿using System;
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
using System.Threading;

namespace BackUpBear
{
    public partial class Form1 : Form
    {
        private string DirsToBackup;
        private string BackupToDirs;
        private bool isFinished = false;

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
            }
            list_DirToBackup.Items.Add(DirsToBackup + "\r\n");

            
        }

        private void pb_DirectoryMinus_Click(object sender, EventArgs e)
        {
            list_DirToBackup.Items.Remove(list_DirToBackup.SelectedItem);
        }

        private void pb_MappedPlus_Click(object sender, EventArgs e)
        {
            if (fb_BackupDir.ShowDialog() == DialogResult.OK)
            {
                BackupToDirs = fb_BackupDir.SelectedPath;
                tb_BackupToDir.Text = BackupToDirs;
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
            this.Size = new Size(445, 365);
            pb_Bear.Visible = true;
            lab_Bear.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            
        }
        private void backgroundWorker1_WorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Size = new Size(370, 365);
            pb_Bear.Visible = false;
            lab_Bear.Visible = false;
        }
        private bool CheckThreadComplete(Thread thread)
        {
            if (thread.IsAlive)
                return false;
            Thread.Sleep(500);
            return CheckThreadComplete(thread);
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                int index = 0;
                string NtAccountName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName + @"\Administrator";
                NTAccount nta = new NTAccount(NtAccountName);
                string destPath = tb_BackupToDir.Text.ToString();
                destPath.Replace(@"\r\n", "");

                foreach (string s in list_DirToBackup.Items)
                {
                    string sourceDir = s;

                    s.Replace("\r\n", string.Empty);

                    if (Directory.Exists(tb_BackupToDir.Text.ToString()))
                    {
                        Directory.CreateDirectory(destPath + "\\Backup");
                        File.SetAttributes(destPath + "\\Backup", FileAttributes.Normal);
                        sourceDir = sourceDir.Trim('\r', '\n');
                        if (cb_Compress.Checked)
                        {
                            if (radbut_Zip.Checked)
                            {
                                using (var archive = ZipArchive.Create())
                                {
                                    archive.AddAllFromDirectory(sourceDir);
                                    archive.SaveTo(tb_BackupToDir.Text.ToString() + "\\Backup " + index + ".zip", CompressionType.Deflate);
                                }
                            }
                            if (radbut_Rar.Checked)
                            {
                                using (var archive = ZipArchive.Create())
                                {
                                    archive.AddAllFromDirectory(sourceDir);
                                    archive.SaveTo(destPath + "\\Backup " + index + ".rar", CompressionType.Rar);
                                }
                            }
                            if (radbut_7z.Checked)
                            {
                                using (var archive = ZipArchive.Create())
                                {
                                    archive.AddAllFromDirectory(sourceDir);
                                    archive.SaveTo(destPath + "\\Backup " + index + ".7z", CompressionType.LZMA);
                                }
                            }
                        }
                        else
                        {
                            string[] files = Directory.GetFiles(sourceDir);
                            for (int i = 0; i < files.Length; i++)
                            {
                                Directory.CreateDirectory(destPath + "\\Backup\\Backup " + index.ToString());
                                File.Copy(files[i], destPath + "\\Backup\\Backup " + index.ToString() + "\\" + Path.GetFileName(files[i]), true);
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
                    index++;
                }
                backgroundWorker1.CancelAsync();
            }

        }
    }
}
