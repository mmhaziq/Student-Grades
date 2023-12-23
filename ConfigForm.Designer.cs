namespace StudentGrades
{
    partial class ConfigForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPassFailThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfigFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configure";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(345, 320);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 30);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxPassFailThreshold
            // 
            this.textBoxPassFailThreshold.Location = new System.Drawing.Point(274, 190);
            this.textBoxPassFailThreshold.Name = "textBoxPassFailThreshold";
            this.textBoxPassFailThreshold.Size = new System.Drawing.Size(245, 26);
            this.textBoxPassFailThreshold.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter cut out marks for pass fail";
            // 
            // buttonConfigFile
            // 
            this.buttonConfigFile.Location = new System.Drawing.Point(345, 260);
            this.buttonConfigFile.Name = "buttonConfigFile";
            this.buttonConfigFile.Size = new System.Drawing.Size(91, 30);
            this.buttonConfigFile.TabIndex = 5;
            this.buttonConfigFile.Text = "Select file";
            this.buttonConfigFile.UseVisualStyleBackColor = true;
            this.buttonConfigFile.Click += new System.EventHandler(this.buttonConfigFile_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfigFile);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPassFailThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxPassFailThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfigFile;
    }
}