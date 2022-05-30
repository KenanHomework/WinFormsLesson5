using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson5.MysStat
{
    public partial class StudentUC : UserControl
    {
        public StudentUC()
        {
            InitializeComponent();
            ViewComment();
            visibility = true;
        }
        public static int CountCrystals = 5;

        private void StudentUC_Load(object sender, EventArgs e)
        {
            btn_cancel.BackColor = Color.FromArgb(0, 157, 248);
            btn_comment.BackColor = Color.FromArgb(0, 157, 248);
        }

        bool visibility = false;

        void ViewComment()
        {
            tbx_comment.Visible = visibility;
            btn_cancel.Visible = visibility;
            btn_comment.Visible = visibility;
        }

        void SelectCrystal(ref Button btn, bool select = false)
        {
            if (select)
                btn.BackColor = Color.DarkBlue;
            else
                btn.BackColor = Color.Transparent;
        }

        void CrystalSelect(object sender)
        {
            
            if (sender is Button btn_c)
            {
                int count = btn_c.Name == "btn_crystal3" ? 3 : btn_c.Name == "btn_crystal2" ? 2 : 1;
                if (btn_c.BackColor == Color.Transparent)
                    if (CountCrystals >= count - Count)
                        CountCrystals -= count - Count;
                    //else if (Count < count && Count > 0)
                    //    CountCrystals = Count - count;
                    else
                        return;
                else
                    CountCrystals += count;

                bool cond1 = count > 0;
                bool cond2 = count > 1;
                bool cond3 = count > 2;

                SelectCrystal(ref btn_crystal1, cond1);
                SelectCrystal(ref btn_crystal2, cond2);
                SelectCrystal(ref btn_crystal3, cond3);
                Count = count;
            }
        }

        int Count = 0;

        private void btn_crystal3_Click(object sender, EventArgs e)
        => CrystalSelect(sender);

        private void btn_showComment_Click(object sender, EventArgs e)
        {
            ViewComment();
            if (visibility)
                visibility = false;
            else
                visibility = true;
        }

        private void btn_deleteCrystal_Click(object sender, EventArgs e)
        {
            CountCrystals += Count;

            SelectCrystal(ref btn_crystal1, false);
            SelectCrystal(ref btn_crystal2, false);
            SelectCrystal(ref btn_crystal3, false);
        }
    }
}
