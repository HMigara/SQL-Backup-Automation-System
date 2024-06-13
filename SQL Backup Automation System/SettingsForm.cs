using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Backup_Automation_System
{
    public partial class SettingsForm : Form
    {
        public Datamodel model;

        public SettingsForm()
        {
            InitializeComponent();
            model = new Datamodel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setData()
        {
            // Set data in the Datamodel
            int.TryParse(comboxTime.Text, out int num) ;
            model.SettingsTime = num;
            model.SettingsFolderPath = txtDefultPath.Text;

            // Close the form and return OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Getter to retrieve the Datamodel instance
        public Datamodel GetDatamodel()
        {
            return model;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            setData();
        }
    }
}
