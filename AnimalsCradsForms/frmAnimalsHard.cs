using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CheckEnd Method

namespace Flip_Cards_Game
{
    public partial class frmAnimalsHard : Flip_Cards_Game.frmParentScreen
    {

        public frmAnimalsHard()
        {
            InitializeComponent();
        }

       private void CheckEnd()
        {
            if (picBoxCard1.Enabled == false && picBoxCard2.Enabled == false && picBoxCard3.Enabled == false &&
                picBoxCard4.Enabled == false && picBoxCard5.Enabled == false && picBoxCard6.Enabled == false &&
                picBoxCard7.Enabled == false && picBoxCard8.Enabled == false && picBoxCard9.Enabled == false &&
                picBoxCard10.Enabled == false && picBoxCard11.Enabled == false && picBoxCard12.Enabled == false &&
                picBoxCard13.Enabled == false && picBoxCard14.Enabled == false && picBoxCard15.Enabled == false &&
                picBoxCard16.Enabled == false && picBoxCard17.Enabled == false && picBoxCard18.Enabled == false &&
                picBoxCard19.Enabled == false && picBoxCard20.Enabled == false && picBoxCard21.Enabled == false &&
                picBoxCard22.Enabled == false && picBoxCard23.Enabled == false && picBoxCard24.Enabled == false &&
                picBoxCard25.Enabled == false && picBoxCard26.Enabled == false && picBoxCard27.Enabled == false &&
                picBoxCard28.Enabled == false && picBoxCard29.Enabled == false && picBoxCard30.Enabled == false
                )
            {
                MessageBox.Show("Congrats You Win :)", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                ResetLevel();
            }
        }

        private void ResetLevel()
        {
            ResetAnimalBoxCard(picBoxCard1);
            ResetAnimalBoxCard(picBoxCard2);
            ResetAnimalBoxCard(picBoxCard3);
            ResetAnimalBoxCard(picBoxCard4);
            ResetAnimalBoxCard(picBoxCard5);
            ResetAnimalBoxCard(picBoxCard6);
            ResetAnimalBoxCard(picBoxCard7);
            ResetAnimalBoxCard(picBoxCard8);
            ResetAnimalBoxCard(picBoxCard9);
            ResetAnimalBoxCard(picBoxCard10);
            ResetAnimalBoxCard(picBoxCard11);
            ResetAnimalBoxCard(picBoxCard12);
            ResetAnimalBoxCard(picBoxCard13);
            ResetAnimalBoxCard(picBoxCard14);
            ResetAnimalBoxCard(picBoxCard15);
            ResetAnimalBoxCard(picBoxCard16);
            ResetAnimalBoxCard(picBoxCard17);
            ResetAnimalBoxCard(picBoxCard18);
            ResetAnimalBoxCard(picBoxCard19);
            ResetAnimalBoxCard(picBoxCard20);
            ResetAnimalBoxCard(picBoxCard21);
            ResetAnimalBoxCard(picBoxCard22);
            ResetAnimalBoxCard(picBoxCard23);
            ResetAnimalBoxCard(picBoxCard24);
            ResetAnimalBoxCard(picBoxCard25);
            ResetAnimalBoxCard(picBoxCard26);
            ResetAnimalBoxCard(picBoxCard27);
            ResetAnimalBoxCard(picBoxCard28);
            ResetAnimalBoxCard(picBoxCard29);
            ResetAnimalBoxCard(picBoxCard30);
            Box1 = null;
            Box2 = null;
        }

        private void BoxCard_MouseEnterLeave(object sender, EventArgs e)
        {
           ChangeCursorBetHandDef(sender, e);
        }

        private void BoxCard_Click(object sender, EventArgs e)
        {
            PictureBox BoxCard = (PictureBox)sender;
            FlipAnimalBoxCard(BoxCard);
            CheckEnd();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLevel();
        }
    }
}
