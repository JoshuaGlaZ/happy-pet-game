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
            panelToy1.Width = 783;
            panelAction1.Width = panelToy2.Width = panelConsumable1.Width = panelConsumable2.Width = 0;
            buttonNextItem.Visible = true;
            buttonBackItem.Visible = false;
        }

        private void buttonToy_MouseEnter(object sender, EventArgs e)
        {
            buttonToy.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonToy_MouseLeave(object sender, EventArgs e)
        {
            buttonToy.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyToyWrench_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyToyWrench_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyToyWrench.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonBuyToyWrench_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyToyWrench.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyToyHammer_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyToyHammer_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyToyHammer.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonBuyToyHammer_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyToyHammer.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyBoxingGloves_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyBoxingGloves_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyBoxingGloves.BackgroundImage = Properties.Resources.buttonlarge_pressed;

        }

        private void buttonBuyBoxingGloves_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyBoxingGloves.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyMagicWand_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyMagicWand_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyMagicWand.BackgroundImage = Properties.Resources.buttonlarge_pressed;

        }

        private void buttonBuyMagicWand_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyMagicWand.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyLightSaber_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyLightSaber_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyLightSaber.BackgroundImage = Properties.Resources.buttonlarge_pressed;

        }

        private void buttonBuyLightSaber_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyLightSaber.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }
        #endregion

        #region consumable
        private void buttonConsumable_Click(object sender, EventArgs e)
        {
            panelConsumable1.Width = 783;
            panelAction1.Width = panelToy1.Width  = panelToy2.Width = panelConsumable2.Width = 0;
            buttonNextItem.Visible = true;
            buttonBackItem.Visible = false;

        }

        private void buttonConsumable_MouseEnter(object sender, EventArgs e)
        {
            buttonConsumable.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonConsumable_MouseLeave(object sender, EventArgs e)
        {
            buttonConsumable.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }
        private void buttonBuyApple_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyApple.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonBuyApple_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyApple.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void buttonBuyCherry_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyCherry.BackgroundImage = Properties.Resources.buttonlarge_pressed;

        }

        private void buttonBuyCherry_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyCherry.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }
        private void buttonBuyCake_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyCake.BackgroundImage = Properties.Resources.buttonlarge_pressed;

        }
        private void buttonBuyCake_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyCake.BackgroundImage = Properties.Resources.buttonlarge_normal;

        }

        private void buttonBuyApple_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCherry_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCake_Click(object sender, EventArgs e)
        {

        }


        private void buttonBuyWater_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuySoda_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCoffee_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region action
        private void buttonAction_Click(object sender, EventArgs e)
        {
            panelAction1.Width = 783;
            panelConsumable1.Width = panelToy1.Width = panelToy2.Width = panelConsumable2.Width = 0;
            buttonBackItem.Visible = false;

        }

        private void buttonAction_MouseEnter(object sender, EventArgs e)
        {
            buttonAction.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonAction_MouseLeave(object sender, EventArgs e)
        {
            buttonAction.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void buttonBuyCatVaccine_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCatSleep_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCatBath_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void FormShop_Load(object sender, EventArgs e)
        {
            panelToy1.Width = panelToy2.Width = 0;
        }

        private void buttonNextItem_Click(object sender, EventArgs e)
        {
            buttonNextItem.Visible = false;
            buttonBackItem.Visible = true;
            if(panelToy1.Width == 783)
            {
                panelToy1.Width = 0;
                panelToy2.Width = 783;
            }
            else 
            {
                panelConsumable1.Width = 0;
                panelConsumable2.Width = 783;
            }
        }

        private void buttonNextItem_MouseEnter(object sender, EventArgs e)
        {
            buttonNextItem.BackgroundImage = Properties.Resources.buttonback_pressed_flip;
        }

        private void buttonNextItem_MouseLeave(object sender, EventArgs e)
        {
            buttonNextItem.BackgroundImage = Properties.Resources.buttonback_flip;
        }

        private void buttonBackItem_Click(object sender, EventArgs e)
        {
            buttonNextItem.Visible = true;
            buttonBackItem.Visible = false;
            if (panelToy2.Width == 783)
            {
                panelToy2.Width = 0;
                panelToy1.Width = 783;
            }
            else
            {
                panelConsumable2.Width = 0;
                panelConsumable1.Width = 783;
            }
        }

        private void buttonBackItem_MouseEnter(object sender, EventArgs e)
        {
            buttonBackItem.BackgroundImage = Properties.Resources.buttonback_pressed;
        }

        private void buttonBackItem_MouseLeave(object sender, EventArgs e)
        {
            buttonBackItem.BackgroundImage = Properties.Resources.buttonback;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
