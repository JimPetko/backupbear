namespace BackUpBear
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.list_DirToBackup = new System.Windows.Forms.ListBox();
            this.pb_DirectoryMinus = new System.Windows.Forms.PictureBox();
            this.pb_MappedPlus = new System.Windows.Forms.PictureBox();
            this.pb_DirectoryAdd = new System.Windows.Forms.PictureBox();
            this.pb_MappedMinus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Compress = new System.Windows.Forms.CheckBox();
            this.radbut_Zip = new System.Windows.Forms.RadioButton();
            this.radbut_Rar = new System.Windows.Forms.RadioButton();
            this.radbut_7z = new System.Windows.Forms.RadioButton();
            this.But_StartBackup = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.fb_DirToBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.fb_BackupDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_BackupToDir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DirectoryMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MappedPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DirectoryAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MappedMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Directories to Backup:";
            // 
            // list_DirToBackup
            // 
            this.list_DirToBackup.FormattingEnabled = true;
            this.list_DirToBackup.Location = new System.Drawing.Point(16, 80);
            this.list_DirToBackup.Name = "list_DirToBackup";
            this.list_DirToBackup.Size = new System.Drawing.Size(295, 82);
            this.list_DirToBackup.TabIndex = 2;
            // 
            // pb_DirectoryMinus
            // 
            this.pb_DirectoryMinus.Image = global::BackUpBear.Properties.Resources.if_onebit_32_12606;
            this.pb_DirectoryMinus.Location = new System.Drawing.Point(53, 52);
            this.pb_DirectoryMinus.Name = "pb_DirectoryMinus";
            this.pb_DirectoryMinus.Size = new System.Drawing.Size(20, 20);
            this.pb_DirectoryMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DirectoryMinus.TabIndex = 6;
            this.pb_DirectoryMinus.TabStop = false;
            this.pb_DirectoryMinus.Click += new System.EventHandler(this.pb_DirectoryMinus_Click);
            // 
            // pb_MappedPlus
            // 
            this.pb_MappedPlus.Image = global::BackUpBear.Properties.Resources.if_Add_32431;
            this.pb_MappedPlus.Location = new System.Drawing.Point(16, 192);
            this.pb_MappedPlus.Name = "pb_MappedPlus";
            this.pb_MappedPlus.Size = new System.Drawing.Size(20, 20);
            this.pb_MappedPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MappedPlus.TabIndex = 5;
            this.pb_MappedPlus.TabStop = false;
            this.pb_MappedPlus.Click += new System.EventHandler(this.pb_MappedPlus_Click);
            // 
            // pb_DirectoryAdd
            // 
            this.pb_DirectoryAdd.Image = global::BackUpBear.Properties.Resources.if_Add_32431;
            this.pb_DirectoryAdd.Location = new System.Drawing.Point(16, 52);
            this.pb_DirectoryAdd.Name = "pb_DirectoryAdd";
            this.pb_DirectoryAdd.Size = new System.Drawing.Size(20, 20);
            this.pb_DirectoryAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DirectoryAdd.TabIndex = 4;
            this.pb_DirectoryAdd.TabStop = false;
            this.pb_DirectoryAdd.Click += new System.EventHandler(this.pb_DirectoryAdd_Click);
            // 
            // pb_MappedMinus
            // 
            this.pb_MappedMinus.Image = global::BackUpBear.Properties.Resources.if_onebit_32_12606;
            this.pb_MappedMinus.Location = new System.Drawing.Point(53, 192);
            this.pb_MappedMinus.Name = "pb_MappedMinus";
            this.pb_MappedMinus.Size = new System.Drawing.Size(20, 20);
            this.pb_MappedMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MappedMinus.TabIndex = 7;
            this.pb_MappedMinus.TabStop = false;
            this.pb_MappedMinus.Click += new System.EventHandler(this.pb_MappedMinus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backup To:";
            // 
            // cb_Compress
            // 
            this.cb_Compress.AutoSize = true;
            this.cb_Compress.Location = new System.Drawing.Point(202, 293);
            this.cb_Compress.Name = "cb_Compress";
            this.cb_Compress.Size = new System.Drawing.Size(107, 17);
            this.cb_Compress.TabIndex = 9;
            this.cb_Compress.Text = "Compress Output";
            this.cb_Compress.UseVisualStyleBackColor = true;
            this.cb_Compress.CheckedChanged += new System.EventHandler(this.cb_Compress_CheckedChanged);
            // 
            // radbut_Zip
            // 
            this.radbut_Zip.AutoSize = true;
            this.radbut_Zip.Location = new System.Drawing.Point(16, 270);
            this.radbut_Zip.Name = "radbut_Zip";
            this.radbut_Zip.Size = new System.Drawing.Size(45, 17);
            this.radbut_Zip.TabIndex = 10;
            this.radbut_Zip.TabStop = true;
            this.radbut_Zip.Text = ".ZIP";
            this.radbut_Zip.UseVisualStyleBackColor = true;
            this.radbut_Zip.Visible = false;
            this.radbut_Zip.CheckedChanged += new System.EventHandler(this.radbut_Zip_CheckedChanged);
            // 
            // radbut_Rar
            // 
            this.radbut_Rar.AutoSize = true;
            this.radbut_Rar.Location = new System.Drawing.Point(67, 270);
            this.radbut_Rar.Name = "radbut_Rar";
            this.radbut_Rar.Size = new System.Drawing.Size(51, 17);
            this.radbut_Rar.TabIndex = 11;
            this.radbut_Rar.TabStop = true;
            this.radbut_Rar.Text = ".RAR";
            this.radbut_Rar.UseVisualStyleBackColor = true;
            this.radbut_Rar.Visible = false;
            this.radbut_Rar.CheckedChanged += new System.EventHandler(this.radbut_Rar_CheckedChanged);
            // 
            // radbut_7z
            // 
            this.radbut_7z.AutoSize = true;
            this.radbut_7z.Location = new System.Drawing.Point(124, 270);
            this.radbut_7z.Name = "radbut_7z";
            this.radbut_7z.Size = new System.Drawing.Size(41, 17);
            this.radbut_7z.TabIndex = 12;
            this.radbut_7z.TabStop = true;
            this.radbut_7z.Text = ".7Z";
            this.radbut_7z.UseVisualStyleBackColor = true;
            this.radbut_7z.Visible = false;
            this.radbut_7z.CheckedChanged += new System.EventHandler(this.radbut_7z_CheckedChanged);
            // 
            // But_StartBackup
            // 
            this.But_StartBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.But_StartBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_StartBackup.ForeColor = System.Drawing.Color.White;
            this.But_StartBackup.Location = new System.Drawing.Point(202, 264);
            this.But_StartBackup.Name = "But_StartBackup";
            this.But_StartBackup.Size = new System.Drawing.Size(107, 23);
            this.But_StartBackup.TabIndex = 13;
            this.But_StartBackup.Text = "Start Backup";
            this.But_StartBackup.UseVisualStyleBackColor = false;
            this.But_StartBackup.Click += new System.EventHandler(this.But_StartBackup_Click);
            // 
            // but_Close
            // 
            this.but_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Close.ForeColor = System.Drawing.Color.White;
            this.but_Close.Location = new System.Drawing.Point(229, 12);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(107, 23);
            this.but_Close.TabIndex = 16;
            this.but_Close.Text = "Close";
            this.but_Close.UseVisualStyleBackColor = false;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // fb_DirToBackup
            // 
            this.fb_DirToBackup.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fb_BackupDir
            // 
            this.fb_BackupDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tb_BackupToDir
            // 
            this.tb_BackupToDir.Location = new System.Drawing.Point(14, 238);
            this.tb_BackupToDir.Name = "tb_BackupToDir";
            this.tb_BackupToDir.Size = new System.Drawing.Size(295, 20);
            this.tb_BackupToDir.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(335, 323);
            this.Controls.Add(this.tb_BackupToDir);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.But_StartBackup);
            this.Controls.Add(this.radbut_7z);
            this.Controls.Add(this.radbut_Rar);
            this.Controls.Add(this.radbut_Zip);
            this.Controls.Add(this.cb_Compress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_MappedMinus);
            this.Controls.Add(this.pb_DirectoryMinus);
            this.Controls.Add(this.pb_MappedPlus);
            this.Controls.Add(this.pb_DirectoryAdd);
            this.Controls.Add(this.list_DirToBackup);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Backup Bear";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_DirectoryMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MappedPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DirectoryAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MappedMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_DirToBackup;
        private System.Windows.Forms.PictureBox pb_DirectoryAdd;
        private System.Windows.Forms.PictureBox pb_MappedPlus;
        private System.Windows.Forms.PictureBox pb_DirectoryMinus;
        private System.Windows.Forms.PictureBox pb_MappedMinus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_Compress;
        private System.Windows.Forms.RadioButton radbut_Zip;
        private System.Windows.Forms.RadioButton radbut_Rar;
        private System.Windows.Forms.RadioButton radbut_7z;
        private System.Windows.Forms.Button But_StartBackup;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.FolderBrowserDialog fb_DirToBackup;
        private System.Windows.Forms.FolderBrowserDialog fb_BackupDir;
        private System.Windows.Forms.TextBox tb_BackupToDir;
    }
}

