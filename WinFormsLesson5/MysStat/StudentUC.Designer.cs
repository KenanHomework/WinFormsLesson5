namespace WinFormsLesson5.MysStat
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx_pp = new System.Windows.Forms.PictureBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_lastseen = new System.Windows.Forms.Label();
            this.rbtn_ok = new System.Windows.Forms.RadioButton();
            this.rbtn_late = new System.Windows.Forms.RadioButton();
            this.rbtn_absence = new System.Windows.Forms.RadioButton();
            this.cbx_test = new System.Windows.Forms.ComboBox();
            this.cbx_classwork = new System.Windows.Forms.ComboBox();
            this.btn_crystal1 = new System.Windows.Forms.Button();
            this.btn_crystal2 = new System.Windows.Forms.Button();
            this.btn_crystal3 = new System.Windows.Forms.Button();
            this.btn_deleteCrystal = new System.Windows.Forms.Button();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_showComment = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_pp
            // 
            this.pbx_pp.BackgroundImage = global::WinFormsLesson5.Properties.Resources.user_default_pp;
            this.pbx_pp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_pp.Location = new System.Drawing.Point(23, 23);
            this.pbx_pp.Name = "pbx_pp";
            this.pbx_pp.Size = new System.Drawing.Size(50, 50);
            this.pbx_pp.TabIndex = 0;
            this.pbx_pp.TabStop = false;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_fullname.Location = new System.Drawing.Point(79, 34);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(67, 24);
            this.lbl_fullname.TabIndex = 1;
            this.lbl_fullname.Text = "Full Name";
            // 
            // lbl_lastseen
            // 
            this.lbl_lastseen.AutoSize = true;
            this.lbl_lastseen.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_lastseen.Location = new System.Drawing.Point(182, 34);
            this.lbl_lastseen.Name = "lbl_lastseen";
            this.lbl_lastseen.Size = new System.Drawing.Size(66, 24);
            this.lbl_lastseen.TabIndex = 2;
            this.lbl_lastseen.Text = "Last Seen";
            // 
            // rbtn_ok
            // 
            this.rbtn_ok.AutoSize = true;
            this.rbtn_ok.BackColor = System.Drawing.Color.Lime;
            this.rbtn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_ok.Location = new System.Drawing.Point(290, 40);
            this.rbtn_ok.Name = "rbtn_ok";
            this.rbtn_ok.Size = new System.Drawing.Size(17, 16);
            this.rbtn_ok.TabIndex = 3;
            this.rbtn_ok.TabStop = true;
            this.rbtn_ok.UseVisualStyleBackColor = false;
            // 
            // rbtn_late
            // 
            this.rbtn_late.AutoSize = true;
            this.rbtn_late.BackColor = System.Drawing.Color.Yellow;
            this.rbtn_late.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_late.Location = new System.Drawing.Point(313, 40);
            this.rbtn_late.Name = "rbtn_late";
            this.rbtn_late.Size = new System.Drawing.Size(17, 16);
            this.rbtn_late.TabIndex = 4;
            this.rbtn_late.TabStop = true;
            this.rbtn_late.UseVisualStyleBackColor = false;
            // 
            // rbtn_absence
            // 
            this.rbtn_absence.AutoSize = true;
            this.rbtn_absence.BackColor = System.Drawing.Color.Red;
            this.rbtn_absence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_absence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_absence.Location = new System.Drawing.Point(336, 40);
            this.rbtn_absence.Name = "rbtn_absence";
            this.rbtn_absence.Size = new System.Drawing.Size(16, 15);
            this.rbtn_absence.TabIndex = 5;
            this.rbtn_absence.TabStop = true;
            this.rbtn_absence.UseVisualStyleBackColor = false;
            // 
            // cbx_test
            // 
            this.cbx_test.BackColor = System.Drawing.Color.Blue;
            this.cbx_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_test.FormattingEnabled = true;
            this.cbx_test.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbx_test.Location = new System.Drawing.Point(404, 34);
            this.cbx_test.Name = "cbx_test";
            this.cbx_test.Size = new System.Drawing.Size(57, 28);
            this.cbx_test.TabIndex = 6;
            // 
            // cbx_classwork
            // 
            this.cbx_classwork.BackColor = System.Drawing.Color.Yellow;
            this.cbx_classwork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_classwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_classwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_classwork.FormattingEnabled = true;
            this.cbx_classwork.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbx_classwork.Location = new System.Drawing.Point(467, 33);
            this.cbx_classwork.Name = "cbx_classwork";
            this.cbx_classwork.Size = new System.Drawing.Size(57, 28);
            this.cbx_classwork.TabIndex = 7;
            // 
            // btn_crystal1
            // 
            this.btn_crystal1.BackColor = System.Drawing.Color.Transparent;
            this.btn_crystal1.BackgroundImage = global::WinFormsLesson5.Properties.Resources.crystal;
            this.btn_crystal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crystal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crystal1.FlatAppearance.BorderSize = 0;
            this.btn_crystal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crystal1.Location = new System.Drawing.Point(546, 29);
            this.btn_crystal1.Name = "btn_crystal1";
            this.btn_crystal1.Size = new System.Drawing.Size(35, 29);
            this.btn_crystal1.TabIndex = 8;
            this.btn_crystal1.UseVisualStyleBackColor = false;
            this.btn_crystal1.Click += new System.EventHandler(this.btn_crystal3_Click);
            // 
            // btn_crystal2
            // 
            this.btn_crystal2.BackColor = System.Drawing.Color.Transparent;
            this.btn_crystal2.BackgroundImage = global::WinFormsLesson5.Properties.Resources.crystal;
            this.btn_crystal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crystal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crystal2.FlatAppearance.BorderSize = 0;
            this.btn_crystal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crystal2.Location = new System.Drawing.Point(587, 29);
            this.btn_crystal2.Name = "btn_crystal2";
            this.btn_crystal2.Size = new System.Drawing.Size(35, 29);
            this.btn_crystal2.TabIndex = 9;
            this.btn_crystal2.UseVisualStyleBackColor = false;
            this.btn_crystal2.Click += new System.EventHandler(this.btn_crystal3_Click);
            // 
            // btn_crystal3
            // 
            this.btn_crystal3.BackColor = System.Drawing.Color.Transparent;
            this.btn_crystal3.BackgroundImage = global::WinFormsLesson5.Properties.Resources.crystal;
            this.btn_crystal3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crystal3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crystal3.FlatAppearance.BorderSize = 0;
            this.btn_crystal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crystal3.Location = new System.Drawing.Point(628, 29);
            this.btn_crystal3.Name = "btn_crystal3";
            this.btn_crystal3.Size = new System.Drawing.Size(35, 29);
            this.btn_crystal3.TabIndex = 10;
            this.btn_crystal3.UseVisualStyleBackColor = false;
            this.btn_crystal3.Click += new System.EventHandler(this.btn_crystal3_Click);
            // 
            // btn_deleteCrystal
            // 
            this.btn_deleteCrystal.BackgroundImage = global::WinFormsLesson5.Properties.Resources.x;
            this.btn_deleteCrystal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleteCrystal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteCrystal.FlatAppearance.BorderSize = 0;
            this.btn_deleteCrystal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCrystal.Location = new System.Drawing.Point(669, 29);
            this.btn_deleteCrystal.Name = "btn_deleteCrystal";
            this.btn_deleteCrystal.Size = new System.Drawing.Size(35, 28);
            this.btn_deleteCrystal.TabIndex = 11;
            this.btn_deleteCrystal.UseVisualStyleBackColor = true;
            this.btn_deleteCrystal.Click += new System.EventHandler(this.btn_deleteCrystal_Click);
            // 
            // tbx_comment
            // 
            this.tbx_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_comment.Location = new System.Drawing.Point(828, 13);
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(266, 20);
            this.tbx_comment.TabIndex = 12;
            // 
            // btn_comment
            // 
            this.btn_comment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comment.Location = new System.Drawing.Point(828, 45);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(130, 29);
            this.btn_comment.TabIndex = 13;
            this.btn_comment.Text = "COMMENT";
            this.btn_comment.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(964, 45);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 29);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_showComment
            // 
            this.btn_showComment.BackgroundImage = global::WinFormsLesson5.Properties.Resources.comment;
            this.btn_showComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showComment.FlatAppearance.BorderSize = 0;
            this.btn_showComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showComment.Location = new System.Drawing.Point(735, 22);
            this.btn_showComment.Name = "btn_showComment";
            this.btn_showComment.Size = new System.Drawing.Size(49, 40);
            this.btn_showComment.TabIndex = 15;
            this.btn_showComment.UseVisualStyleBackColor = true;
            this.btn_showComment.Click += new System.EventHandler(this.btn_showComment_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DarkGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 93);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1104, 25);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // StudentUC
            // 
            this.Controls.Add(this.pbx_pp);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_lastseen);
            this.Controls.Add(this.rbtn_ok);
            this.Controls.Add(this.rbtn_late);
            this.Controls.Add(this.rbtn_absence);
            this.Controls.Add(this.cbx_test);
            this.Controls.Add(this.cbx_classwork);
            this.Controls.Add(this.btn_crystal1);
            this.Controls.Add(this.btn_crystal2);
            this.Controls.Add(this.btn_crystal3);
            this.Controls.Add(this.btn_deleteCrystal);
            this.Controls.Add(this.tbx_comment);
            this.Controls.Add(this.btn_comment);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_showComment);
            this.Controls.Add(this.splitter1);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(1104, 118);
            this.Load += new System.EventHandler(this.StudentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbx_pp;
        private Label lbl_fullname;
        private Label lbl_lastseen;
        private RadioButton rbtn_ok;
        private RadioButton rbtn_late;
        private RadioButton rbtn_absence;
        private ComboBox cbx_test;
        private ComboBox cbx_classwork;
        private Button btn_crystal1;
        private Button btn_crystal2;
        private Button btn_crystal3;
        private Button btn_deleteCrystal;
        private TextBox tbx_comment;
        private Button btn_comment;
        private Button btn_cancel;
        private Button btn_showComment;
        private Splitter splitter1;
    }
}
