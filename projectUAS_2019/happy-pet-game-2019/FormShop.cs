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
    public partial class FormShop : Form
    {
        FormBattle battle;
        public FormShop()
        {
            InitializeComponent();
        }

        #region toy
        private void buttonToy_Click(object sender, EventArgs e)
        {
            panelToy2.Width = panelToy3.Width = 0;
            panelToy1.Width = 1474;
        }

        private void buttonToToys2_2_Click(object sender, EventArgs e)
        {
            panelToy1.Width = panelToy3.Width = 0;
            panelToy2.Width = 1474;
        }

        private void buttonToToys2_1_Click(object sender, EventArgs e)
        {
            panelToy1.Width = panelToy3.Width = 0;
            panelToy2.Width = 1474;
        }

        private void buttonToToys1_Click(object sender, EventArgs e)
        {
            panelToy2.Width = panelToy3.Width = 0;
            panelToy1.Width = 1474;
        }

        private void buttonToToys3_Click(object sender, EventArgs e)
        {
            panelToy2.Width = panelToy1.Width = 0;
            panelToy3.Width = 1474;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyToyHammer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region consumable
        #endregion

        #region action
        private void buttonAction_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void FormShop_Load(object sender, EventArgs e)
        {

        }
    }
}
