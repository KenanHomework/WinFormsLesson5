using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson5.WordPadKiller
{
    public partial class MysStat : Form
    {
        public MysStat()
        {
            InitializeComponent();
            CenterToScreen();
        }



        private void WolfRW_Load(object sender, EventArgs e)
        {
            btn_color.BackColor = Color.White;
            rtbx_text.ForeColor = Color.Black;
            rtbx_text.SelectionColor = Color.Black;
        }



        /* General Fields */

        string fileAdress = null;

        bool SelectedAll = false;

        /*~~~~~~~~~~~~~~~~~~~~~*/



        void TexChanged(bool changed)
        {
            Text = GetFileName(fileAdress);
            if (changed)
                Text = $"*{Text.TrimStart('*')}";
            else
                Text = Text.TrimStart('*');

            btn_saveas.Enabled = changed;
            btn_save.Enabled = changed;
        }

        void ReverseFileAdress(ref string adress)
        {
            StringBuilder builder = new();
            for (int i = adress.Length - 1; i >= 0; i--)
            {
                builder.Append(adress[i]);
            }
            adress = builder.ToString();
        }

        string GetFileName(string fadress)
        {
            if (string.IsNullOrWhiteSpace(fadress))
                return Text;

            ReverseFileAdress(ref fadress);
            StringBuilder builder = new();
            bool read = false;
            foreach (char ch in fadress)
            {
                if (ch == '\\')
                    break;
                if (ch == '.')
                {
                    read = true;
                    continue;
                }
                if (read)
                    builder.Append(ch);
            }

            fadress = builder.ToString();
            ReverseFileAdress(ref fadress);
            return fadress;
        }

        private void rtbx_text_TextChanged(object sender, EventArgs e)
            => TexChanged(true);

        private void nup_size_ValueChanged(object sender, EventArgs e)
            => rtbx_text.SelectionFont = new(rtbx_text.SelectionFont.FontFamily, (float)(nup_size.Value));

        private void btn_color_BackColorChanged(object sender, EventArgs e)
        {
            if (SelectedAll)
                rtbx_text.ForeColor = btn_color.BackColor;
            else
                rtbx_text.SelectionColor = btn_color.BackColor;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileAdress))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Tex File (*.txt)| *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                    fileAdress = sfd.FileName;
            }

            TexChanged(false);
            File.WriteAllText(fileAdress, rtbx_text.Text);
        }

        private void btn_saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Tex File (*.txt)| *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileAdress = sfd.FileName;
                File.WriteAllText(fileAdress, rtbx_text.Text);
                TexChanged(false);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "Tex File (*.txt)| *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbx_text.Text = File.ReadAllText(ofd.FileName);
                fileAdress = ofd.FileName;
                TexChanged(false);
            }
        }

        private void btn_selectColor_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
                if (btn.Name == "btn_selectColorAll") { SelectedAll = true; }
                else { SelectedAll = false; }


            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn_color.BackColor = colorDialog.Color;
            }
        }

        private void btn_AlgRight_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == btn_AlgLeft.Name)
                    rtbx_text.SelectionAlignment = HorizontalAlignment.Left;
                else if (btn.Name == btn_AlgRight.Name)
                    rtbx_text.SelectionAlignment = HorizontalAlignment.Right;
                else if (btn.Name == btn_AlgCenter.Name)
                    rtbx_text.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                FontStyle style = new();
                if (btn.Name == btn_bold.Name)
                    style = FontStyle.Bold;
                else if (btn.Name == btn_italic.Name)
                    style = FontStyle.Italic;
                else if (btn.Name == btn_underLine.Name)
                    style = FontStyle.Underline;

                if (style == rtbx_text.SelectionFont.Style)
                    style = FontStyle.Regular;

                rtbx_text.SelectionFont = new(rtbx_text.SelectionFont, style);
            }
        }

        private void btn_selecFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbx_text.SelectionFont = fontDialog.Font;
            }
        }
    }
}