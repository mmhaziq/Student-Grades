namespace StudentGrades
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textGrade1 = new System.Windows.Forms.TextBox();
            this.textGrade2 = new System.Windows.Forms.TextBox();
            this.textGrade3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGrade3 = new System.Windows.Forms.Label();
            this.labelGrade2 = new System.Windows.Forms.Label();
            this.labelGrade1 = new System.Windows.Forms.Label();
            this.btnCalcAvg = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.radioUndergraduate = new System.Windows.Forms.RadioButton();
            this.radioGraduate = new System.Windows.Forms.RadioButton();
            this.radioPassFail = new System.Windows.Forms.RadioButton();
            this.groupProgram = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLog = new System.Windows.Forms.Button();
            this.groupProgram.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(700, 172);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(226, 32);
            this.textName.TabIndex = 0;
            // 
            // textGrade1
            // 
            this.textGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGrade1.Location = new System.Drawing.Point(700, 235);
            this.textGrade1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGrade1.Name = "textGrade1";
            this.textGrade1.Size = new System.Drawing.Size(226, 32);
            this.textGrade1.TabIndex = 1;
            // 
            // textGrade2
            // 
            this.textGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGrade2.Location = new System.Drawing.Point(702, 295);
            this.textGrade2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGrade2.Name = "textGrade2";
            this.textGrade2.Size = new System.Drawing.Size(226, 32);
            this.textGrade2.TabIndex = 2;
            // 
            // textGrade3
            // 
            this.textGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGrade3.Location = new System.Drawing.Point(700, 349);
            this.textGrade3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGrade3.Name = "textGrade3";
            this.textGrade3.Size = new System.Drawing.Size(226, 32);
            this.textGrade3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Name:";
            // 
            // labelGrade3
            // 
            this.labelGrade3.AutoSize = true;
            this.labelGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade3.Location = new System.Drawing.Point(591, 354);
            this.labelGrade3.Name = "labelGrade3";
            this.labelGrade3.Size = new System.Drawing.Size(104, 26);
            this.labelGrade3.TabIndex = 6;
            this.labelGrade3.Text = "&Grade 3:";
            // 
            // labelGrade2
            // 
            this.labelGrade2.AutoSize = true;
            this.labelGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade2.Location = new System.Drawing.Point(591, 298);
            this.labelGrade2.Name = "labelGrade2";
            this.labelGrade2.Size = new System.Drawing.Size(104, 26);
            this.labelGrade2.TabIndex = 7;
            this.labelGrade2.Text = "&Grade 2:";
            // 
            // labelGrade1
            // 
            this.labelGrade1.AutoSize = true;
            this.labelGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade1.Location = new System.Drawing.Point(591, 240);
            this.labelGrade1.Name = "labelGrade1";
            this.labelGrade1.Size = new System.Drawing.Size(104, 26);
            this.labelGrade1.TabIndex = 8;
            this.labelGrade1.Text = "&Grade 1:";
            // 
            // btnCalcAvg
            // 
            this.btnCalcAvg.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAvg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcAvg.Location = new System.Drawing.Point(1044, 152);
            this.btnCalcAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcAvg.Name = "btnCalcAvg";
            this.btnCalcAvg.Size = new System.Drawing.Size(228, 52);
            this.btnCalcAvg.TabIndex = 9;
            this.btnCalcAvg.Text = "&Calculate Average";
            this.btnCalcAvg.UseVisualStyleBackColor = false;
            this.btnCalcAvg.Click += new System.EventHandler(this.btnCalcAvg_Click);
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.SystemColors.Control;
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClr.Location = new System.Drawing.Point(1044, 215);
            this.btnClr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(228, 52);
            this.btnClr.TabIndex = 10;
            this.btnClr.Text = "&Clear";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // listOutput
            // 
            this.listOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOutput.FormattingEnabled = true;
            this.listOutput.ItemHeight = 26;
            this.listOutput.Location = new System.Drawing.Point(232, 527);
            this.listOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOutput.Name = "listOutput";
            this.listOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listOutput.Size = new System.Drawing.Size(1463, 446);
            this.listOutput.TabIndex = 11;
            this.listOutput.TabStop = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuit.Location = new System.Drawing.Point(1044, 339);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(228, 52);
            this.buttonQuit.TabIndex = 12;
            this.buttonQuit.Text = "&Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // radioUndergraduate
            // 
            this.radioUndergraduate.AutoSize = true;
            this.radioUndergraduate.Checked = true;
            this.radioUndergraduate.Location = new System.Drawing.Point(6, 35);
            this.radioUndergraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioUndergraduate.Name = "radioUndergraduate";
            this.radioUndergraduate.Size = new System.Drawing.Size(142, 24);
            this.radioUndergraduate.TabIndex = 13;
            this.radioUndergraduate.TabStop = true;
            this.radioUndergraduate.Text = "&Undergraduate";
            this.radioUndergraduate.UseVisualStyleBackColor = true;
            this.radioUndergraduate.CheckedChanged += new System.EventHandler(this.radioUndergraduate_CheckedChanged);
            // 
            // radioGraduate
            // 
            this.radioGraduate.AutoSize = true;
            this.radioGraduate.Location = new System.Drawing.Point(154, 35);
            this.radioGraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGraduate.Name = "radioGraduate";
            this.radioGraduate.Size = new System.Drawing.Size(102, 24);
            this.radioGraduate.TabIndex = 14;
            this.radioGraduate.Text = "&Graduate";
            this.radioGraduate.UseVisualStyleBackColor = true;
            this.radioGraduate.CheckedChanged += new System.EventHandler(this.radioGraduate_CheckedChanged);
            // 
            // radioPassFail
            // 
            this.radioPassFail.AutoSize = true;
            this.radioPassFail.Location = new System.Drawing.Point(273, 35);
            this.radioPassFail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioPassFail.Name = "radioPassFail";
            this.radioPassFail.Size = new System.Drawing.Size(98, 24);
            this.radioPassFail.TabIndex = 15;
            this.radioPassFail.Text = "&Pass/Fail";
            this.radioPassFail.UseVisualStyleBackColor = true;
            this.radioPassFail.CheckedChanged += new System.EventHandler(this.radioPassFail_CheckedChanged);
            // 
            // groupProgram
            // 
            this.groupProgram.Controls.Add(this.radioUndergraduate);
            this.groupProgram.Controls.Add(this.radioGraduate);
            this.groupProgram.Controls.Add(this.radioPassFail);
            this.groupProgram.Location = new System.Drawing.Point(596, 410);
            this.groupProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupProgram.Name = "groupProgram";
            this.groupProgram.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupProgram.Size = new System.Drawing.Size(382, 82);
            this.groupProgram.TabIndex = 17;
            this.groupProgram.TabStop = false;
            this.groupProgram.Text = "&Select program:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1872, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConfig});
            this.ConfigMenu.Name = "ConfigMenu";
            this.ConfigMenu.Size = new System.Drawing.Size(137, 29);
            this.ConfigMenu.Text = "Configuration";
            // 
            // toolStripMenuItemConfig
            // 
            this.toolStripMenuItemConfig.Name = "toolStripMenuItemConfig";
            this.toolStripMenuItemConfig.Size = new System.Drawing.Size(263, 34);
            this.toolStripMenuItemConfig.Text = "Open Config Form";
            this.toolStripMenuItemConfig.Click += new System.EventHandler(this.toolStripMenuItemConfig_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLog.Location = new System.Drawing.Point(1044, 275);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(228, 52);
            this.buttonLog.TabIndex = 19;
            this.buttonLog.Text = "&Log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1872, 1050);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.groupProgram);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnCalcAvg);
            this.Controls.Add(this.labelGrade1);
            this.Controls.Add(this.labelGrade2);
            this.Controls.Add(this.labelGrade3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGrade3);
            this.Controls.Add(this.textGrade2);
            this.Controls.Add(this.textGrade1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Student Grades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupProgram.ResumeLayout(false);
            this.groupProgram.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textGrade1;
        private System.Windows.Forms.TextBox textGrade2;
        private System.Windows.Forms.TextBox textGrade3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGrade3;
        private System.Windows.Forms.Label labelGrade2;
        private System.Windows.Forms.Label labelGrade1;
        private System.Windows.Forms.Button btnCalcAvg;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.RadioButton radioUndergraduate;
        private System.Windows.Forms.RadioButton radioGraduate;
        private System.Windows.Forms.RadioButton radioPassFail;
        private System.Windows.Forms.GroupBox groupProgram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfig;
        private System.Windows.Forms.Button buttonLog;
    }
}
