namespace SQL_Backup_Automation_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectBkup = new System.Windows.Forms.Button();
            this.txtdestinationPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsBK = new System.Windows.Forms.Button();
            this.txtsourcePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnstart = new System.Windows.Forms.Button();
            this.btncansel = new System.Windows.Forms.Button();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblWarnig = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set BackUp Location : ";
            // 
            // BtnSelectBkup
            // 
            this.BtnSelectBkup.Location = new System.Drawing.Point(570, 94);
            this.BtnSelectBkup.Name = "BtnSelectBkup";
            this.BtnSelectBkup.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectBkup.TabIndex = 1;
            this.BtnSelectBkup.Text = "Browse";
            this.BtnSelectBkup.UseVisualStyleBackColor = true;
            this.BtnSelectBkup.Click += new System.EventHandler(this.BtnSelectBkup_Click);
            // 
            // txtdestinationPath
            // 
            this.txtdestinationPath.Location = new System.Drawing.Point(215, 97);
            this.txtdestinationPath.Name = "txtdestinationPath";
            this.txtdestinationPath.ReadOnly = true;
            this.txtdestinationPath.Size = new System.Drawing.Size(337, 20);
            this.txtdestinationPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chooes DataBase File : ";
            // 
            // btnBrowsBK
            // 
            this.btnBrowsBK.Location = new System.Drawing.Point(570, 132);
            this.btnBrowsBK.Name = "btnBrowsBK";
            this.btnBrowsBK.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsBK.TabIndex = 1;
            this.btnBrowsBK.Text = "Get Defult";
            this.btnBrowsBK.UseVisualStyleBackColor = true;
            this.btnBrowsBK.Click += new System.EventHandler(this.btnBrowsBK_Click);
            // 
            // txtsourcePath
            // 
            this.txtsourcePath.Location = new System.Drawing.Point(215, 132);
            this.txtsourcePath.Name = "txtsourcePath";
            this.txtsourcePath.Size = new System.Drawing.Size(337, 20);
            this.txtsourcePath.TabIndex = 2;
            this.txtsourcePath.Click += new System.EventHandler(this.txtsourcePath_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(659, 357);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(84, 26);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btncansel
            // 
            this.btncansel.Location = new System.Drawing.Point(557, 357);
            this.btncansel.Name = "btncansel";
            this.btncansel.Size = new System.Drawing.Size(84, 26);
            this.btncansel.TabIndex = 3;
            this.btncansel.Text = "Cancel";
            this.btncansel.UseVisualStyleBackColor = true;
            this.btncansel.Click += new System.EventHandler(this.btncansel_Click);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.Color.Red;
            this.lblHeadline.Location = new System.Drawing.Point(244, 194);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(308, 64);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "**This system will automatically backup the \r\ndatabase in every 3 hours\r\ndon\'t cl" +
    "ose the application \r\nafter run**\r\n";
            this.lblHeadline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "BackUp Automation System";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(229, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // lblWarnig
            // 
            this.lblWarnig.AutoSize = true;
            this.lblWarnig.ForeColor = System.Drawing.Color.Red;
            this.lblWarnig.Location = new System.Drawing.Point(266, 156);
            this.lblWarnig.Name = "lblWarnig";
            this.lblWarnig.Size = new System.Drawing.Size(209, 13);
            this.lblWarnig.TabIndex = 6;
            this.lblWarnig.Text = "**Enter the Correct Database Folder Path**";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(72, 357);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(85, 26);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblWarnig);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btncansel);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtsourcePath);
            this.Controls.Add(this.btnBrowsBK);
            this.Controls.Add(this.txtdestinationPath);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelectBkup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUp Automation System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectBkup;
        private System.Windows.Forms.TextBox txtdestinationPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsBK;
        private System.Windows.Forms.TextBox txtsourcePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btncansel;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWarnig;
        private System.Windows.Forms.Button btnSettings;
    }
}

