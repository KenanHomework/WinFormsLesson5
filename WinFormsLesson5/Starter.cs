using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson5
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        public enum ChangableScreens { WolfWR, MyStat, FootBall, Exit }

        public ChangableScreens ToScreen = ChangableScreens.Exit;

        private void Starter_Load(object sender, EventArgs e)
        {

        }

        private void btn_wolfwr_Click(object sender, EventArgs e)
        {
            ToScreen = ChangableScreens.WolfWR;
            Close();
        }

        private void btn_mystat_Click(object sender, EventArgs e)
        {
            ToScreen = ChangableScreens.MyStat;
            Close();
        }
    }
}
