namespace WinFormsLesson5
{
    partial class Starter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.btn_wolfwr = new System.Windows.Forms.Button();
            this.btn_mystat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wolfwr
            // 
            this.btn_wolfwr.BackColor = System.Drawing.Color.Transparent;
            this.btn_wolfwr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wolfwr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_wolfwr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_wolfwr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wolfwr.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_wolfwr.ForeColor = System.Drawing.Color.White;
            this.btn_wolfwr.Location = new System.Drawing.Point(39, 120);
            this.btn_wolfwr.Name = "btn_wolfwr";
            this.btn_wolfwr.Size = new System.Drawing.Size(64, 54);
            this.btn_wolfwr.TabIndex = 0;
            this.btn_wolfwr.Text = "WolfWR";
            this.btn_wolfwr.UseVisualStyleBackColor = false;
            this.btn_wolfwr.Click += new System.EventHandler(this.btn_wolfwr_Click);
            // 
            // btn_mystat
            // 
            this.btn_mystat.BackColor = System.Drawing.Color.Transparent;
            this.btn_mystat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mystat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_mystat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_mystat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mystat.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_mystat.ForeColor = System.Drawing.Color.White;
            this.btn_mystat.Location = new System.Drawing.Point(194, 12);
            this.btn_mystat.Name = "btn_mystat";
            this.btn_mystat.Size = new System.Drawing.Size(64, 54);
            this.btn_mystat.TabIndex = 1;
            this.btn_mystat.Text = "MysStat";
            this.btn_mystat.UseVisualStyleBackColor = false;
            this.btn_mystat.Click += new System.EventHandler(this.btn_mystat_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(379, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "FootBall";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_mystat);
            this.Controls.Add(this.btn_wolfwr);
            this.Name = "Starter";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.Starter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_wolfwr;
        private Button btn_mystat;
        private Button button2;
    }
}