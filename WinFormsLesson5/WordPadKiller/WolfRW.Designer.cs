namespace WinFormsLesson5.WordPadKiller
{
    partial class WolfWR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_selecFont = new System.Windows.Forms.Button();
            this.btn_selectColorAll = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_selectColor = new System.Windows.Forms.Button();
            this.btn_saveas = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AlgRight = new System.Windows.Forms.Button();
            this.btn_AlgCenter = new System.Windows.Forms.Button();
            this.btn_AlgLeft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_italic = new System.Windows.Forms.Button();
            this.btn_underLine = new System.Windows.Forms.Button();
            this.btn_bold = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nup_size = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbx_text = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_size)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_selecFont);
            this.groupBox1.Controls.Add(this.btn_selectColorAll);
            this.groupBox1.Controls.Add(this.btn_color);
            this.groupBox1.Controls.Add(this.btn_selectColor);
            this.groupBox1.Controls.Add(this.btn_saveas);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_AlgRight);
            this.groupBox1.Controls.Add(this.btn_AlgCenter);
            this.groupBox1.Controls.Add(this.btn_AlgLeft);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_italic);
            this.groupBox1.Controls.Add(this.btn_underLine);
            this.groupBox1.Controls.Add(this.btn_bold);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nup_size);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-11, -37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1170, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // btn_selecFont
            // 
            this.btn_selecFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecFont.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_selecFont.Location = new System.Drawing.Point(223, 86);
            this.btn_selecFont.Name = "btn_selecFont";
            this.btn_selecFont.Size = new System.Drawing.Size(66, 30);
            this.btn_selecFont.TabIndex = 16;
            this.btn_selecFont.Text = "Select";
            this.btn_selecFont.UseVisualStyleBackColor = true;
            this.btn_selecFont.Click += new System.EventHandler(this.btn_selecFont_Click);
            // 
            // btn_selectColorAll
            // 
            this.btn_selectColorAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selectColorAll.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_selectColorAll.Location = new System.Drawing.Point(806, 121);
            this.btn_selectColorAll.Name = "btn_selectColorAll";
            this.btn_selectColorAll.Size = new System.Drawing.Size(70, 29);
            this.btn_selectColorAll.TabIndex = 15;
            this.btn_selectColorAll.Text = "Select All";
            this.btn_selectColorAll.UseVisualStyleBackColor = true;
            this.btn_selectColorAll.Click += new System.EventHandler(this.btn_selectColor_Click);
            // 
            // btn_color
            // 
            this.btn_color.Enabled = false;
            this.btn_color.Location = new System.Drawing.Point(766, 105);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(34, 29);
            this.btn_color.TabIndex = 14;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.BackColorChanged += new System.EventHandler(this.btn_color_BackColorChanged);
            // 
            // btn_selectColor
            // 
            this.btn_selectColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selectColor.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_selectColor.Location = new System.Drawing.Point(806, 88);
            this.btn_selectColor.Name = "btn_selectColor";
            this.btn_selectColor.Size = new System.Drawing.Size(70, 29);
            this.btn_selectColor.TabIndex = 13;
            this.btn_selectColor.Text = "Select";
            this.btn_selectColor.UseVisualStyleBackColor = true;
            this.btn_selectColor.Click += new System.EventHandler(this.btn_selectColor_Click);
            // 
            // btn_saveas
            // 
            this.btn_saveas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveas.Enabled = false;
            this.btn_saveas.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_saveas.Location = new System.Drawing.Point(1008, 119);
            this.btn_saveas.Name = "btn_saveas";
            this.btn_saveas.Size = new System.Drawing.Size(94, 29);
            this.btn_saveas.TabIndex = 8;
            this.btn_saveas.Text = "Save as";
            this.btn_saveas.UseVisualStyleBackColor = true;
            this.btn_saveas.Click += new System.EventHandler(this.btn_saveas_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(1008, 84);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_load.Location = new System.Drawing.Point(1008, 49);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(94, 29);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(782, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color";
            // 
            // btn_AlgRight
            // 
            this.btn_AlgRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlgRight.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AlgRight.Location = new System.Drawing.Point(701, 88);
            this.btn_AlgRight.Name = "btn_AlgRight";
            this.btn_AlgRight.Size = new System.Drawing.Size(34, 28);
            this.btn_AlgRight.TabIndex = 4;
            this.btn_AlgRight.Text = "R";
            this.btn_AlgRight.UseVisualStyleBackColor = true;
            this.btn_AlgRight.Click += new System.EventHandler(this.btn_AlgRight_Click);
            // 
            // btn_AlgCenter
            // 
            this.btn_AlgCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlgCenter.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AlgCenter.Location = new System.Drawing.Point(661, 88);
            this.btn_AlgCenter.Name = "btn_AlgCenter";
            this.btn_AlgCenter.Size = new System.Drawing.Size(34, 28);
            this.btn_AlgCenter.TabIndex = 4;
            this.btn_AlgCenter.Text = "C";
            this.btn_AlgCenter.UseVisualStyleBackColor = true;
            this.btn_AlgCenter.Click += new System.EventHandler(this.btn_AlgRight_Click);
            // 
            // btn_AlgLeft
            // 
            this.btn_AlgLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlgLeft.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AlgLeft.Location = new System.Drawing.Point(621, 88);
            this.btn_AlgLeft.Name = "btn_AlgLeft";
            this.btn_AlgLeft.Size = new System.Drawing.Size(34, 28);
            this.btn_AlgLeft.TabIndex = 4;
            this.btn_AlgLeft.Text = "L";
            this.btn_AlgLeft.UseVisualStyleBackColor = true;
            this.btn_AlgLeft.Click += new System.EventHandler(this.btn_AlgRight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(621, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alignment";
            // 
            // btn_italic
            // 
            this.btn_italic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_italic.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_italic.Location = new System.Drawing.Point(546, 88);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(34, 28);
            this.btn_italic.TabIndex = 3;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // btn_underLine
            // 
            this.btn_underLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_underLine.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_underLine.Location = new System.Drawing.Point(506, 88);
            this.btn_underLine.Name = "btn_underLine";
            this.btn_underLine.Size = new System.Drawing.Size(34, 28);
            this.btn_underLine.TabIndex = 3;
            this.btn_underLine.Text = "U";
            this.btn_underLine.UseVisualStyleBackColor = true;
            this.btn_underLine.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // btn_bold
            // 
            this.btn_bold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bold.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bold.Location = new System.Drawing.Point(466, 88);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(34, 28);
            this.btn_bold.TabIndex = 3;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(466, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font Style";
            // 
            // nup_size
            // 
            this.nup_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nup_size.Location = new System.Drawing.Point(368, 88);
            this.nup_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_size.Name = "nup_size";
            this.nup_size.Size = new System.Drawing.Size(53, 27);
            this.nup_size.TabIndex = 2;
            this.nup_size.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nup_size.ValueChanged += new System.EventHandler(this.nup_size_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(368, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // rtbx_text
            // 
            this.rtbx_text.Location = new System.Drawing.Point(1, 117);
            this.rtbx_text.Name = "rtbx_text";
            this.rtbx_text.Size = new System.Drawing.Size(1139, 649);
            this.rtbx_text.TabIndex = 1;
            this.rtbx_text.Text = "";
            this.rtbx_text.TextChanged += new System.EventHandler(this.rtbx_text_TextChanged);
            // 
            // WolfRW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1139, 771);
            this.Controls.Add(this.rtbx_text);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1157, 818);
            this.MinimumSize = new System.Drawing.Size(1157, 818);
            this.Name = "WolfRW";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WolfRW";
            this.Load += new System.EventHandler(this.WolfRW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btn_save;
        private Button btn_load;
        private Label label5;
        private Button btn_AlgRight;
        private Button btn_AlgCenter;
        private Button btn_AlgLeft;
        private Label label4;
        private Button btn_italic;
        private Button btn_underLine;
        private Button btn_bold;
        private Label label3;
        private NumericUpDown nup_size;
        private RichTextBox rtbx_text;
        private Button btn_saveas;
        private Button btn_color;
        private Button btn_selectColor;
        private Button btn_selectColorAll;
        private Button btn_selecFont;
    }
}