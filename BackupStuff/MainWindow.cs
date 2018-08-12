using System;
using System.IO;
using System.Windows.Forms;
using Dolinay;
using DirectoryCopy;

namespace backupHelper
{
    public partial class MainWindow : Form
    {
        private DriveDetector driveDetector = null;

        string destDirOnedrive = BackupHelper.Properties.Settings.Default.pathOneDrive;
        string distDirUS = BackupHelper.Properties.Settings.Default.backupPath;
        string destDirUSB;
        string sourceDir = BackupHelper.Properties.Settings.Default.pathSourceFiles;
        String user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string date = DateTime.Today.ToString("d");        
        bool copySubDirs = true;
        public bool update = false;

        public MainWindow()
        {
            InitializeComponent();
            driveDetector = new DriveDetector();
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
            //driveDetector.QueryRemove += new DriveDetectorEventHandler(OnQueryRemove);

            tbFilePath.Text = sourceDir;
            int count = 0;            

            DriveInfo[] mydrives = DriveInfo.GetDrives();
            foreach (DriveInfo mydrive in mydrives)
            {
                if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel == "BACKUP")
                {
                    count += 1;
                    btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconOk;
                }
                else if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel != "BACKUP")
                {
                    count += 1;
                    btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconWarn;
                }
                if(mydrive.DriveType != DriveType.Removable)
                {

                }
            }
            if (count >= 1)
            {
                btSaveUSB.Enabled = true;
            }
            else
            {
                btSaveUSB.Enabled = false;
                btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconNot;
            }           

            DirectoryInfo directoryInfo = new DirectoryInfo(sourceDir);
            TreeNode node = new TreeNode(directoryInfo.Name, 0, 1);

            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, tvFiles.Nodes);
                tvFiles.ExpandAll();
            }        
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);            
            foreach (FileInfo file in directoryInfo.GetFiles())
            {   ////Vis filer i undermapper (nodes på tree)
                // curNode.Nodes.Add(file.FullName, file.Name);
            }            
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void tvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            sourceDir = BackupHelper.Properties.Settings.Default.pathSourceFiles;
            if (e.Node.Text == e.Node.FullPath) 
            {
                tbFilePath.Text = sourceDir + "\\";
                return;
            }
            else
            {
                tbFilePath.Text = sourceDir + "\\" + e.Node.Text;
                //sourceDir = pathStart + "\\" + e.Node.Text + "\\";
                destDirOnedrive = destDirOnedrive + e.Node.Text + "\\";
                destDirUSB = destDirUSB + e.Node.Text + "\\";
            }
        }

        private void btSaveOneDrive_Click(object sender, EventArgs e)
        {
            destDirOnedrive = destDirOnedrive + "//Backup//" + date;
            DC.DirectoryCopy(sourceDir, destDirOnedrive, copySubDirs);                        
            MessageBox.Show("Filerne er gemt på OneDrive!");
            destDirOnedrive = "";       
        }

        private void btSaveUSB_Click(object sender, EventArgs e)
        {
            DriveInfo[] mydrives = DriveInfo.GetDrives();
            bool cancel = false;
            int count = 0;

            foreach (DriveInfo mydrive in mydrives)
            {
                if (mydrive.DriveType == DriveType.Removable)
                {
                    count++;

                    if (count >= 2)
                    {
                        MessageBox.Show("Der er mere end én USB-stick i din PC - sørg for at kun den du ønsker at gemme på sidder i!");
                        return;
                    }
                    else if (mydrive.VolumeLabel == "BACKUP")
                    {
                        destDirUSB = mydrive.Name + "Backup//" + date + "//";
                        DC.DirectoryCopy(sourceDir, destDirUSB, copySubDirs);
                        destDirUSB = "";
                        MessageBox.Show("Filerne er gemt på din USB!");
                    }
                    else if (mydrive.VolumeLabel != "BACKUP")
                    {
                        DialogResult result = MessageBox.Show("Dette er ikke din normale backup USB, vil du fortsætte?", "Fremmed USB?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            destDirUSB = mydrive.Name + "Backup//" + date + "//";
                            DC.DirectoryCopy(sourceDir, destDirUSB, copySubDirs);
                            destDirUSB = "";
                            MessageBox.Show("Filerne er gemt på din USB!");
                        }
                    }
                    else
                    {
                        cancel = true;
                        break;
                    }
                }
                if (cancel == true)
                {
                    ///////////
                }
                else
                {
                    ///////////
                }
            }
        }

        private void btSaveSelect_Click(object sender, EventArgs e)
        {
            DC.DirectoryCopy(sourceDir, distDirUS, copySubDirs);           
        }
        

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            SettingsBS settings = new SettingsBS(this);            
            settings.Show();                             
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Vil du afslutte programmet?", "Afslut?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btSettings_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipSettings = new ToolTip();
            toolTipSettings.SetToolTip(btSettings, "Indstillinger");
        }

        private void btHelp_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipSettings = new ToolTip();
            toolTipSettings.SetToolTip(btHelp, "Hjælp");
        }

        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipClose = new ToolTip();
            toolTipClose.SetToolTip(btClose, "Luk programmet");
        }

        private void btSaveOneDrive_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipOneDrive = new ToolTip();
            toolTipOneDrive.SetToolTip(btSaveOneDrive, "Gem til OneDrive");
        }

        private void btSaveUSB_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipUSB = new ToolTip();
            toolTipUSB.SetToolTip(btSaveUSB, "Gem til USB");
        }

        private void btSaveSelect_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipSaveSelect = new ToolTip();
            toolTipSaveSelect.SetToolTip(btSaveSelect, "Gem til brugermappe" + " (" + sourceDir+")");
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            sourceDir = BackupHelper.Properties.Settings.Default.pathSourceFiles;
            
            if (update == true)
            {
                tvFiles.Nodes.Clear();
                DirectoryInfo directoryInfo = new DirectoryInfo(sourceDir);
                TreeNode node = new TreeNode(directoryInfo.Name, 0, 1);                
                if (directoryInfo.Exists)
                {
                    BuildTree(directoryInfo, tvFiles.Nodes);
                    tvFiles.ExpandAll();
                }                
                tvFiles.Refresh();
                tbFilePath.Text = sourceDir;
            }
        }        

        private void OnDriveArrived(object sender, DriveDetectorEventArgs e)
        {
         //   e.HookQueryRemove = true;
            btSaveUSB.Enabled = true;

            DriveInfo[] mydrives = DriveInfo.GetDrives();
            foreach (DriveInfo mydrive in mydrives)
            if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel == "BACKUP")
            {
                btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconOk;
            }
            else if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel != "BACKUP")
            {
                btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconWarn;
            }
        }
        private void OnDriveRemoved(object sender, DriveDetectorEventArgs e)
        {
         //   e.HookQueryRemove = true;

            DriveInfo[] mydrives = DriveInfo.GetDrives();
            foreach (DriveInfo mydrive in mydrives)
                if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel == "BACKUP")
                {
                    btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconOk;
                }
                else if (mydrive.DriveType == DriveType.Removable && mydrive.VolumeLabel != "BACKUP")
                {
                    btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconWarn;
                }
                else if (1==1)
                {
                    btSaveUSB.Enabled = false;
                    btSaveUSB.Image = BackupHelper.Properties.Resources.usbSmallIconNot;
                }


        }
        private void OnQueryRemove(object sender, DriveDetectorEventArgs e)
        {

        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            pHelp.Show();
        }

        private void tbHelp_MouseClick(object sender, MouseEventArgs e)
        {
            pHelp.Hide();
        }

    }
}
