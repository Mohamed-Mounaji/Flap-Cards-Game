using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flip_Cards_Game
{
    public partial class frmAnimalsMedium : Flip_Cards_Game.frmParentScreen
    {
        public frmAnimalsMedium()
        {
            InitializeComponent();
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
            Box1 = null;
            Box2 = null;
        }
        private void CheckGameEnd()
        {
            if (picBoxCard1.Enabled == false && picBoxCard2.Enabled == false && picBoxCard3.Enabled == false &&
                picBoxCard4.Enabled == false && picBoxCard5.Enabled == false && picBoxCard6.Enabled == false &&
                picBoxCard7.Enabled == false && picBoxCard8.Enabled == false && picBoxCard9.Enabled == false &&
                picBoxCard10.Enabled == false && picBoxCard11.Enabled == false && picBoxCard12.Enabled == false &&
                picBoxCard13.Enabled == false && picBoxCard14.Enabled == false && picBoxCard15.Enabled == false &&
                picBoxCard16.Enabled == false
                )
            {
                MessageBox.Show("Congrats You Won :)", "Game Over", MessageBoxButtons.OK);
                ResetLevel();
            }
        }
        private void BoxCard_Click(object sender, EventArgs e)
        {
            PictureBox BoxCard = (PictureBox)sender;
            FlipAnimalBoxCard(BoxCard);

            CheckGameEnd();
                
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLevel();
        }

        private void BoxCard_MouseEnterLeave(object sender, EventArgs e)
        {
            ChangeCursorBetHandDef(sender, e);
        }
    }
}
