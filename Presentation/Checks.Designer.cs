namespace Bursty.Presentation
{
    partial class Checks
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
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPattern = new System.Windows.Forms.Label();
            this.labelHit = new System.Windows.Forms.Label();
            this.labelLastCheck = new System.Windows.Forms.Label();
            this.comboBoxLogs = new System.Windows.Forms.ComboBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.textBoxHit = new System.Windows.Forms.TextBox();
            this.textBoxLastCheck = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonManageLogs = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(15, 17);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(25, 13);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Log";
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(15, 44);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(41, 13);
            this.labelPattern.TabIndex = 1;
            this.labelPattern.Text = "Pattern";
            // 
            // labelHit
            // 
            this.labelHit.AutoSize = true;
            this.labelHit.Location = new System.Drawing.Point(15, 92);
            this.labelHit.Name = "labelHit";
            this.labelHit.Size = new System.Drawing.Size(20, 13);
            this.labelHit.TabIndex = 3;
            this.labelHit.Text = "Hit";
            // 
            // labelLastCheck
            // 
            this.labelLastCheck.AutoSize = true;
            this.labelLastCheck.Location = new System.Drawing.Point(15, 122);
            this.labelLastCheck.Name = "labelLastCheck";
            this.labelLastCheck.Size = new System.Drawing.Size(61, 13);
            this.labelLastCheck.TabIndex = 4;
            this.labelLastCheck.Text = "Last Check";
            // 
            // comboBoxLogs
            // 
            this.comboBoxLogs.FormattingEnabled = true;
            this.comboBoxLogs.Location = new System.Drawing.Point(103, 14);
            this.comboBoxLogs.Name = "comboBoxLogs";
            this.comboBoxLogs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLogs.TabIndex = 5;
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(103, 41);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(100, 20);
            this.textBoxPattern.TabIndex = 6;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(103, 67);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(141, 17);
            this.checkBoxRepeat.TabIndex = 7;
            this.checkBoxRepeat.Text = "Keep checking after hits";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // textBoxHit
            // 
            this.textBoxHit.Location = new System.Drawing.Point(103, 89);
            this.textBoxHit.Name = "textBoxHit";
            this.textBoxHit.Size = new System.Drawing.Size(100, 20);
            this.textBoxHit.TabIndex = 8;
            // 
            // textBoxLastCheck
            // 
            this.textBoxLastCheck.Location = new System.Drawing.Point(103, 115);
            this.textBoxLastCheck.Name = "textBoxLastCheck";
            this.textBoxLastCheck.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastCheck.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonManageLogs);
            this.panel1.Controls.Add(this.labelLog);
            this.panel1.Controls.Add(this.textBoxLastCheck);
            this.panel1.Controls.Add(this.comboBoxLogs);
            this.panel1.Controls.Add(this.labelLastCheck);
            this.panel1.Controls.Add(this.textBoxHit);
            this.panel1.Controls.Add(this.labelPattern);
            this.panel1.Controls.Add(this.checkBoxRepeat);
            this.panel1.Controls.Add(this.labelHit);
            this.panel1.Controls.Add(this.textBoxPattern);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 149);
            this.panel1.TabIndex = 10;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(13, 13);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(95, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonManageLogs
            // 
            this.buttonManageLogs.Location = new System.Drawing.Point(230, 12);
            this.buttonManageLogs.Name = "buttonManageLogs";
            this.buttonManageLogs.Size = new System.Drawing.Size(75, 23);
            this.buttonManageLogs.TabIndex = 10;
            this.buttonManageLogs.Text = "Manage";
            this.buttonManageLogs.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(347, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 186);
            this.listBox1.TabIndex = 14;
            // 
            // Checks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 217);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panel1);
            this.Name = "Checks";
            this.Text = "Checks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Label labelHit;
        private System.Windows.Forms.Label labelLastCheck;
        private System.Windows.Forms.ComboBox comboBoxLogs;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.TextBox textBoxHit;
        private System.Windows.Forms.TextBox textBoxLastCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonManageLogs;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBox1;
    }
}