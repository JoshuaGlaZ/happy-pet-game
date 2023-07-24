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
        Image image;

        public FormShop()
        {
            InitializeComponent();
        }

        #region toy
        private void buttonToy_Click(object sender, EventArgs e)
        {
            panelReset();
            panelToy1.Width = 1474;
        }
        private void buttonToToys1_Click(object sender, EventArgs e)
        {
            panelReset();
            panelToy1.Width = 1474;
        }
        private void buttonToToys3_Click(object sender, EventArgs e)
        {
            panelReset();
            panelToy3.Width = 1474;
        }

        private void buttonBuyToyHammer_Click(object sender, EventArgs e)
        {
            try
            {
                if (battle.activePlayer.Coins >= 1000)
                {
                    battle.activePlayer.BuyToy("Toy Hammer", Properties.Resources.border, 1000, 500, 100, 5, -0.2);
                }
                else { throw new Exception("not enough coins"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonBuyBoxxingGloves_Click(object sender, EventArgs e)
        {
            try
            {
                if (battle.activePlayer.Coins >= 1000)
                {
                    battle.activePlayer.BuyToy("Boxxing Gloves", Properties.Resources.border, 1000, 100, 200, 2, 0.2);
                }
                else { throw new Exception("not enough coins"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonBuyWrench_Click(object sender, EventArgs e)
        {
            try
            {
                if (battle.activePlayer.Coins >= 1000)
                {
                    battle.activePlayer.BuyToy("Wrench", Properties.Resources.border, 1000, 0, 100, -2, 0.5);
                }
                else { throw new Exception("not enough coins"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonBuyLightSaber_Click(object sender, EventArgs e)
        {
            try
            {
                if (battle.activePlayer.Coins >= 1000)
                {
                    battle.activePlayer.BuyToy("Toy Hammer", Properties.Resources.border, 1000, 250, 150, 2, 0.2);
                }
                else { throw new Exception("not enough coins"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonBuyMagicWand_Click(object sender, EventArgs e)
        {
            try
            {
                if (battle.activePlayer.Coins >= 1000)
                {
                    battle.activePlayer.BuyToy("Toy Hammer", Properties.Resources.border, 1000, 100, -50, 5, 0.5);
                }
                else { throw new Exception("not enough coins"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region consumable
        private void buttonConsumable_Click(object sender, EventArgs e)
        {
            panelReset();
            panelConsumable1.Width = 1474;
        }
        private void buttonToConsumable1_Click(object sender, EventArgs e)
        {
            panelReset();
            panelConsumable1.Width = 1474;
        }
        private void buttonToConsumable2_Click(object sender, EventArgs e)
        {
            panelReset();
            panelConsumable2.Width = 1474;
        }

        private void buttonBuyWater_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuySoda_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCoffe_Click(object sender, EventArgs e)
        {

        }
        private void buttonBuyApple_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCherry_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyDrumStick_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region action
        private void buttonAction_Click(object sender, EventArgs e)
        {
            panelReset();
            if(battle.activePlayer.ChoosenPet is Cat)
            {

            }
            else if (battle.activePlayer.ChoosenPet is Fish)
            {

            }
            else
            {

            }
        }
        #endregion

        private void FormShop_Load(object sender, EventArgs e)
        {
            battle = (FormBattle)this.Owner;
        }

        private void panelReset()
        {
            panelConsumable1.Width = panelConsumable2.Width = 0;
            panelToy1.Width = panelToy3.Width = 0;
        }
    }
}
