namespace backupHelper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.pBackupButtons = new System.Windows.Forms.Panel();
            this.btSaveOneDrive = new System.Windows.Forms.Button();
            this.btSaveSelect = new System.Windows.Forms.Button();
            this.btSaveUSB = new System.Windows.Forms.Button();
            this.lbOneDrive = new System.Windows.Forms.Label();
            this.lbUSB = new System.Windows.Forms.Label();
            this.lbThisPC = new System.Windows.Forms.Label();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.btSettings = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.pHelp = new System.Windows.Forms.Panel();
            this.tbHelp = new System.Windows.Forms.RichTextBox();
            this.pBackupButtons.SuspendLayout();
            this.pHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(8, 35);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(307, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilePath.Location = new System.Drawing.Point(10, 16);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(251, 16);
            this.lbFilePath.TabIndex = 0;
            this.lbFilePath.Text = "Sti til filer der skal tages backup af:";
            // 
            // pBackupButtons
            // 
            this.pBackupButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBackupButtons.Controls.Add(this.btSaveOneDrive);
            this.pBackupButtons.Controls.Add(this.btSaveSelect);
            this.pBackupButtons.Controls.Add(this.btSaveUSB);
            this.pBackupButtons.Controls.Add(this.lbOneDrive);
            this.pBackupButtons.Controls.Add(this.lbUSB);
            this.pBackupButtons.Controls.Add(this.lbThisPC);
            this.pBackupButtons.Location = new System.Drawing.Point(7, 351);
            this.pBackupButtons.Name = "pBackupButtons";
            this.pBackupButtons.Size = new System.Drawing.Size(501, 93);
            this.pBackupButtons.TabIndex = 3;
            // 
            // btSaveOneDrive
            // 
            this.btSaveOneDrive.BackColor = System.Drawing.Color.LightGray;
            this.btSaveOneDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSaveOneDrive.Image = global::BackupHelper.Properties.Resources.odSmallLogo;
            this.btSaveOneDrive.Location = new System.Drawing.Point(5, 3);
            this.btSaveOneDrive.Name = "btSaveOneDrive";
            this.btSaveOneDrive.Size = new System.Drawing.Size(160, 70);
            this.btSaveOneDrive.TabIndex = 0;
            this.btSaveOneDrive.UseVisualStyleBackColor = false;
            this.btSaveOneDrive.Click += new System.EventHandler(this.btSaveOneDrive_Click);
            this.btSaveOneDrive.MouseEnter += new System.EventHandler(this.btSaveOneDrive_MouseEnter);
            // 
            // btSaveSelect
            // 
            this.btSaveSelect.BackColor = System.Drawing.Color.LightGray;
            this.btSaveSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSaveSelect.Image = global::BackupHelper.Properties.Resources.pcLogoSmall;
            this.btSaveSelect.Location = new System.Drawing.Point(336, 3);
            this.btSaveSelect.Name = "btSaveSelect";
            this.btSaveSelect.Size = new System.Drawing.Size(160, 70);
            this.btSaveSelect.TabIndex = 0;
            this.btSaveSelect.UseVisualStyleBackColor = false;
            this.btSaveSelect.Click += new System.EventHandler(this.btSaveSelect_Click);
            this.btSaveSelect.MouseEnter += new System.EventHandler(this.btSaveSelect_MouseEnter);
            // 
            // btSaveUSB
            // 
            this.btSaveUSB.BackColor = System.Drawing.Color.LightGray;
            this.btSaveUSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSaveUSB.Image = global::BackupHelper.Properties.Resources.usbSmallIcon;
            this.btSaveUSB.Location = new System.Drawing.Point(170, 3);
            this.btSaveUSB.Name = "btSaveUSB";
            this.btSaveUSB.Size = new System.Drawing.Size(160, 70);
            this.btSaveUSB.TabIndex = 0;
            this.btSaveUSB.UseVisualStyleBackColor = false;
            this.btSaveUSB.Click += new System.EventHandler(this.btSaveUSB_Click);
            this.btSaveUSB.MouseEnter += new System.EventHandler(this.btSaveUSB_MouseEnter);
            // 
            // lbOneDrive
            // 
            this.lbOneDrive.AutoSize = true;
            this.lbOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOneDrive.Location = new System.Drawing.Point(46, 70);
            this.lbOneDrive.Name = "lbOneDrive";
            this.lbOneDrive.Size = new System.Drawing.Size(78, 18);
            this.lbOneDrive.TabIndex = 0;
            this.lbOneDrive.Text = "OneDrive";
            // 
            // lbUSB
            // 
            this.lbUSB.AutoSize = true;
            this.lbUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUSB.Location = new System.Drawing.Point(229, 70);
            this.lbUSB.Name = "lbUSB";
            this.lbUSB.Size = new System.Drawing.Size(42, 18);
            this.lbUSB.TabIndex = 0;
            this.lbUSB.Text = "USB";
            // 
            // lbThisPC
            // 
            this.lbThisPC.AutoSize = true;
            this.lbThisPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisPC.Location = new System.Drawing.Point(349, 70);
            this.lbThisPC.Name = "lbThisPC";
            this.lbThisPC.Size = new System.Drawing.Size(135, 18);
            this.lbThisPC.TabIndex = 0;
            this.lbThisPC.Text = "Denne Computer";
            // 
            // tvFiles
            // 
            this.tvFiles.Location = new System.Drawing.Point(7, 84);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(501, 259);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFiles_AfterSelect);
            // 
            // btSettings
            // 
            this.btSettings.BackColor = System.Drawing.Color.LightGray;
            this.btSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettings.Image = global::BackupHelper.Properties.Resources.settingsBT40;
            this.btSettings.Location = new System.Drawing.Point(402, 11);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(50, 50);
            this.btSettings.TabIndex = 0;
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            this.btSettings.MouseEnter += new System.EventHandler(this.btSettings_MouseEnter);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.LightGray;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.Image = global::BackupHelper.Properties.Resources.ExitBT40;
            this.btClose.Location = new System.Drawing.Point(458, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(50, 50);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.LightGray;
            this.btHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHelp.Image = global::BackupHelper.Properties.Resources.question;
            this.btHelp.Location = new System.Drawing.Point(346, 12);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(50, 50);
            this.btHelp.TabIndex = 4;
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            this.btHelp.MouseEnter += new System.EventHandler(this.btHelp_MouseEnter);
            // 
            // pHelp
            // 
            this.pHelp.Controls.Add(this.tbHelp);
            this.pHelp.Location = new System.Drawing.Point(7, 67);
            this.pHelp.Name = "pHelp";
            this.pHelp.Size = new System.Drawing.Size(501, 276);
            this.pHelp.TabIndex = 5;
            this.pHelp.Visible = false;
            // 
            // tbHelp
            // 
            this.tbHelp.Location = new System.Drawing.Point(4, 4);
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Size = new System.Drawing.Size(493, 269);
            this.tbHelp.TabIndex = 0;
            this.tbHelp.Text = resources.GetString("tbHelp.Text");
            this.tbHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbHelp_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Controls.Add(this.pHelp);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.tvFiles);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pBackupButtons);
            this.Controls.Add(this.tbFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 490);
            this.MinimumSize = new System.Drawing.Size(533, 490);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Helper";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.pBackupButtons.ResumeLayout(false);
            this.pBackupButtons.PerformLayout();
            this.pHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.Button btSaveOneDrive;
        private System.Windows.Forms.Button btSaveUSB;
        private System.Windows.Forms.Button btSaveSelect;
        private System.Windows.Forms.Panel pBackupButtons;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Label lbThisPC;
        private System.Windows.Forms.Label lbUSB;
        private System.Windows.Forms.Label lbOneDrive;
        public System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Panel pHelp;
        private System.Windows.Forms.RichTextBox tbHelp;
    }
}