using System;
using System.Windows.Forms;

namespace backupHelper
{
    public partial class SettingsBS : Form
    {        
        string backupPath = BackupHelper.Properties.Settings.Default.backupPath;
        string pathOneDrive = BackupHelper.Properties.Settings.Default.pathOneDrive;
        string pathSource = BackupHelper.Properties.Settings.Default.pathSourceFiles;
        
        public SettingsBS()
        {
            InitializeComponent();
        }

        private MainWindow mainForm = null;
        public SettingsBS(Form callingForm)
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();

            tbPathSource.Text = pathSource;
            tbPathOneDrive.Text = pathOneDrive;
            tbPathUS.Text = backupPath;            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            BackupHelper.Properties.Settings.Default.pathSourceFiles = tbPathSource.Text;
            BackupHelper.Properties.Settings.Default.pathOneDrive = tbPathOneDrive.Text;
            BackupHelper.Properties.Settings.Default.backupPath = tbPathUS.Text;
            BackupHelper.Properties.Settings.Default.Save();
            mainForm.update = true;                                
            this.Hide();            
        }

        private void btSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog source = new FolderBrowserDialog();

            DialogResult result = source.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = source.SelectedPath;                
            }
            tbPathSource.Text = source.SelectedPath;
        }

        private void btOneDrive_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog source = new FolderBrowserDialog();

            DialogResult result = source.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = source.SelectedPath;
            }
            tbPathOneDrive.Text = source.SelectedPath;
        }

        private void btUS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog source = new FolderBrowserDialog();
            DialogResult result = source.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = source.SelectedPath;
            }
            tbPathUS.Text = source.SelectedPath;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
                this.Close();    
        }

        private void SettingsBS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Vil du gå tilbage uden at gemme dine ændringer?", "Ændringer ikke gemt!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btSave_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipSave = new ToolTip();
            toolTipSave.SetToolTip(btSave, "Gem og gå tilbage");
        }

        private void btBack_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipBack = new ToolTip();
            toolTipBack.SetToolTip(btBack , "Gå tilbage");
        }

        private void btSource_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipSource = new ToolTip();
            toolTipSource.SetToolTip(btSource, "Søg...");
        }

        private void btOneDrive_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipOneDrive = new ToolTip();
            toolTipOneDrive.SetToolTip(btOneDrive, "Søg...");
        }

        private void btUS_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTipUS = new ToolTip();
            toolTipUS.SetToolTip(btUS, "Søg...");
        }
    }
}
