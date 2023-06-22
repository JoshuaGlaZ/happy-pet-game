using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPetStatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop();
            formShop.Owner = this;
            formShop.ShowDialog();
        }

        private void maximizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizeresizeToolStripMenuItem.Text = "Resize";
                maximizeresizeToolStripMenuItem.Image = Properties.Resources.ExitFullScreen;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                maximizeresizeToolStripMenuItem.Text = "Maximize";
                maximizeresizeToolStripMenuItem.Image = Properties.Resources.Scale;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
