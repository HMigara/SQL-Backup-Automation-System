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

namespace SQL_Backup_Automation_System
{

    public partial class Form1 : Form
    {
        private Timer timer;
        private DateTime startTime;
        private string sourcePath;
        private string destinationPath;
        private Datamodel model = new Datamodel(); // Assuming Datamodel class is defined with SettingsTime and SettingsFolderPath properties
        private int newTime = 0;
        private string newFilePath;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Hide();
            lblWarnig.Hide();

            // Set the start time to the desired time today
            startTime = DateTime.Today.AddHours(8).AddMinutes(30);

            // Calculate the initial delay before the first trigger
            TimeSpan initialDelay = startTime > DateTime.Now ? startTime - DateTime.Now : TimeSpan.FromHours(24) - (DateTime.Now - startTime);

            // Initialize the timer
            timer = new Timer();
            timer.Interval = (int)initialDelay.TotalMilliseconds;
            timer.Tick += btnstart_Click;
            timer.Start(); // Start the timer
        }

        private void BtnSelectBkup_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtdestinationPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void btnBrowsBK_Click(object sender, EventArgs e)
        {
            if (newFilePath == null)
            { txtsourcePath.Text = "\\\\192.168.2.113\\f$\\SQL_AUTO_Backup"; }
            else
            { txtsourcePath.Text = newFilePath; }
            
            lblWarnig.Hide();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdestinationPath.Text) || string.IsNullOrEmpty(txtsourcePath.Text))
            {
                MessageBox.Show("Please select the correct paths.");
                return;
            }

            // Specify the source and destination folder paths
            sourcePath = txtsourcePath.Text;
            destinationPath = txtdestinationPath.Text;

            // Reset the timer interval to 3 hours
            if (newTime == 0)
            {
                timer.Interval = (int)TimeSpan.FromHours(3).TotalMilliseconds;
                //MessageBox.Show("BackUp Automation Start After every 3 Houers!");
            }
            else
            {
                timer.Interval = (int)TimeSpan.FromMinutes(newTime).TotalMilliseconds;
                //MessageBox.Show("BackUp Automation Start After every " + newTime + " Houers!");
            }

            // Call the method to copy files
            CopyFromSharedFolder(sourcePath, destinationPath);
            lblWarnig.Hide();
        }

        private void btncansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsourcePath_Click(object sender, EventArgs e)
        {
            txtsourcePath.Text = "";
            lblWarnig.Show();
        }

        // new copy method
        private void CopyFromSharedFolder(string sourceFolderPath, string destinationFolderPath)
        {
            try
            {
                // Check if the source folder exists
                if (!Directory.Exists(sourceFolderPath))
                {
                    MessageBox.Show("Source folder does not exist.");
                    return;
                }

                // Check if the destination folder exists, create it if not
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                // Get files in the source folder
                string[] files = Directory.GetFiles(sourceFolderPath);

                // progress bar
                progressBar1.Minimum = 0;
                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;
                progressBar1.Show();

                // Copy each file to the destination folder
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFilePath = Path.Combine(destinationFolderPath, fileName);
                    File.Copy(file, destFilePath, true); // true to overwrite existing files

                    // Update progress bar
                    progressBar1.Value++;
                }

                MessageBox.Show("Database Backup successful.");
                progressBar1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the updated settings from SettingsForm
                    newFilePath = settingsForm.model.SettingsFolderPath;
                    newTime = settingsForm.model.SettingsTime; 

                    // Update UI or perform other actions with the new settings data
                    MessageBox.Show($"Updated Settings: \nFile Path : {newFilePath}\n New Time : {newTime}");
                    lblHeadline.Text = "**This system will automatically backup the \r\ndatabase in every " + newTime + " hours\r\ndon't close the application \r\nafter run**\r\n";
                }
            }
        }

    }

}
