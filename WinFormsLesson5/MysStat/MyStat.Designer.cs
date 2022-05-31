namespace WinFormsLesson5.MysStat
{
    partial class MyStat
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
            this.studentuc1 = new WinFormsLesson5.MysStat.StudentUC();
            this.studentuc2 = new WinFormsLesson5.MysStat.StudentUC();
            this.SuspendLayout();
            // 
            // studentuc1
            // 
            this.studentuc1.Location = new System.Drawing.Point(10, 9);
            this.studentuc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentuc1.Name = "studentuc1";
            this.studentuc1.Size = new System.Drawing.Size(967, 92);
            this.studentuc1.TabIndex = 0;
            // 
            // studentuc2
            // 
            this.studentuc2.Location = new System.Drawing.Point(10, 105);
            this.studentuc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentuc2.Name = "studentuc2";
            this.studentuc2.Size = new System.Drawing.Size(967, 95);
            this.studentuc2.TabIndex = 1;
            // 
            // MyStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 214);
            this.Controls.Add(this.studentuc2);
            this.Controls.Add(this.studentuc1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyStat";
            this.Text = "MysStat";
            this.ResumeLayout(false);

        }

        #endregion

        private StudentUC studentuc1;
        private StudentUC studentuc2;
    }
}