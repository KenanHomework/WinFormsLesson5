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
    public partial class WolfRW : Form
    {
        public WolfRW()
        {
            InitializeComponent();
            CenterToScreen();
        }


        string fileAdress = null;


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
    }
}
