namespace backupHelper
{
    partial class SettingsBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsBS));
            this.tbPathOneDrive = new System.Windows.Forms.TextBox();
            this.tbPathSource = new System.Windows.Forms.TextBox();
            this.tbPathUS = new System.Windows.Forms.TextBox();
            this.lbOneDrive = new System.Windows.Forms.Label();
            this.lbSource = new System.Windows.Forms.Label();
            this.lbUS = new System.Windows.Forms.Label();
            this.pUS = new System.Windows.Forms.Panel();
            this.btUS = new System.Windows.Forms.Button();
            this.pOneDrive = new System.Windows.Forms.Panel();
            this.btOneDrive = new System.Windows.Forms.Button();
            this.pSource = new System.Windows.Forms.Panel();
            this.btSource = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pUS.SuspendLayout();
            this.pOneDrive.SuspendLayout();
            this.pSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPathOneDrive
            // 
            this.tbPathOneDrive.Location = new System.Drawing.Point(8, 23);
            this.tbPathOneDrive.Name = "tbPathOneDrive";
            this.tbPathOneDrive.Size = new System.Drawing.Size(227, 20);
            this.tbPathOneDrive.TabIndex = 0;
            // 
            // tbPathSource
            // 
            this.tbPathSource.Location = new System.Drawing.Point(8, 23);
            this.tbPathSource.Name = "tbPathSource";
            this.tbPathSource.Size = new System.Drawing.Size(227, 20);
            this.tbPathSource.TabIndex = 4;
            // 
            // tbPathUS
            // 
            this.tbPathUS.Location = new System.Drawing.Point(8, 22);
            this.tbPathUS.Name = "tbPathUS";
            this.tbPathUS.Size = new System.Drawing.Size(227, 20);
            this.tbPathUS.TabIndex = 6;
            // 
            // lbOneDrive
            // 
            this.lbOneDrive.AutoSize = true;
            this.lbOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbOneDrive.Location = new System.Drawing.Point(5, 7);
            this.lbOneDrive.Name = "lbOneDrive";
            this.lbOneDrive.Size = new System.Drawing.Size(97, 13);
            this.lbOneDrive.TabIndex = 8;
            this.lbOneDrive.Text = "Sti til OneDrive:";
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.Location = new System.Drawing.Point(5, 7);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(92, 13);
            this.lbSource.TabIndex = 9;
            this.lbSource.Text = "Sti til kildefiler:";
            // 
            // lbUS
            // 
            this.lbUS.AutoSize = true;
            this.lbUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUS.Location = new System.Drawing.Point(5, 6);
            this.lbUS.Name = "lbUS";
            this.lbUS.Size = new System.Drawing.Size(121, 13);
            this.lbUS.TabIndex = 10;
            this.lbUS.Text = "Sti til bruger mappe:";
            // 
            // pUS
            // 
            this.pUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUS.Controls.Add(this.tbPathUS);
            this.pUS.Controls.Add(this.lbUS);
            this.pUS.Controls.Add(this.btUS);
            this.pUS.Location = new System.Drawing.Point(12, 140);
            this.pUS.Name = "pUS";
            this.pUS.Size = new System.Drawing.Size(310, 55);
            this.pUS.TabIndex = 11;
            // 
            // btUS
            // 
            this.btUS.Image = global::BackupHelper.Properties.Resources.search;
            this.btUS.Location = new System.Drawing.Point(261, 10);
            this.btUS.Name = "btUS";
            this.btUS.Size = new System.Drawing.Size(41, 36);
            this.btUS.TabIndex = 7;
            this.btUS.UseVisualStyleBackColor = true;
            this.btUS.Click += new System.EventHandler(this.btUS_Click);
            this.btUS.MouseEnter += new System.EventHandler(this.btUS_MouseEnter);
            // 
            // pOneDrive
            // 
            this.pOneDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOneDrive.Controls.Add(this.tbPathOneDrive);
            this.pOneDrive.Controls.Add(this.btOneDrive);
            this.pOneDrive.Controls.Add(this.lbOneDrive);
            this.pOneDrive.Location = new System.Drawing.Point(12, 75);
            this.pOneDrive.Name = "pOneDrive";
            this.pOneDrive.Size = new System.Drawing.Size(310, 55);
            this.pOneDrive.TabIndex = 12;
            // 
            // btOneDrive
            // 
            this.btOneDrive.Image = global::BackupHelper.Properties.Resources.search;
            this.btOneDrive.Location = new System.Drawing.Point(261, 10);
            this.btOneDrive.Name = "btOneDrive";
            this.btOneDrive.Size = new System.Drawing.Size(41, 36);
            this.btOneDrive.TabIndex = 2;
            this.btOneDrive.UseVisualStyleBackColor = true;
            this.btOneDrive.Click += new System.EventHandler(this.btOneDrive_Click);
            this.btOneDrive.MouseEnter += new System.EventHandler(this.btOneDrive_MouseEnter);
            // 
            // pSource
            // 
            this.pSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSource.Controls.Add(this.tbPathSource);
            this.pSource.Controls.Add(this.btSource);
            this.pSource.Controls.Add(this.lbSource);
            this.pSource.Location = new System.Drawing.Point(12, 10);
            this.pSource.Name = "pSource";
            this.pSource.Size = new System.Drawing.Size(310, 55);
            this.pSource.TabIndex = 13;
            // 
            // btSource
            // 
            this.btSource.Image = global::BackupHelper.Properties.Resources.search;
            this.btSource.Location = new System.Drawing.Point(261, 10);
            this.btSource.Name = "btSource";
            this.btSource.Size = new System.Drawing.Size(41, 36);
            this.btSource.TabIndex = 5;
            this.btSource.UseVisualStyleBackColor = true;
            this.btSource.Click += new System.EventHandler(this.btSource_Click);
            this.btSource.MouseEnter += new System.EventHandler(this.btSource_MouseEnter);
            // 
            // btBack
            // 
            this.btBack.Image = global::BackupHelper.Properties.Resources.backIcon;
            this.btBack.Location = new System.Drawing.Point(249, 220);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 61);
            this.btBack.TabIndex = 14;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            this.btBack.MouseEnter += new System.EventHandler(this.btBack_MouseEnter);
            // 
            // btSave
            // 
            this.btSave.Image = global::BackupHelper.Properties.Resources.saveIcon;
            this.btSave.Location = new System.Drawing.Point(12, 220);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 61);
            this.btSave.TabIndex = 3;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btOK_Click);
            this.btSave.MouseEnter += new System.EventHandler(this.btSave_MouseEnter);
            // 
            // SettingsBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 293);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pSource);
            this.Controls.Add(this.pOneDrive);
            this.Controls.Add(this.pUS);
            this.Controls.Add(this.btSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 332);
            this.MinimumSize = new System.Drawing.Size(352, 332);
            this.Name = "SettingsBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indstillinger";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsBS_FormClosing);
            this.pUS.ResumeLayout(false);
            this.pUS.PerformLayout();
            this.pOneDrive.ResumeLayout(false);
            this.pOneDrive.PerformLayout();
            this.pSource.ResumeLayout(false);
            this.pSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPathOneDrive;
        private System.Windows.Forms.Button btOneDrive;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSource;
        private System.Windows.Forms.TextBox tbPathSource;
        private System.Windows.Forms.Button btUS;
        private System.Windows.Forms.TextBox tbPathUS;
        private System.Windows.Forms.Label lbOneDrive;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Label lbUS;
        private System.Windows.Forms.Panel pUS;
        private System.Windows.Forms.Panel pOneDrive;
        private System.Windows.Forms.Panel pSource;
        private System.Windows.Forms.Button btBack;
    }
}