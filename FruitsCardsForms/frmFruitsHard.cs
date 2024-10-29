using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flip_Cards_Game
{
    public partial class frmFruitsHard : Flip_Cards_Game.frmParentScreen
    {
        public frmFruitsHard()
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
            ResetFruitBoxCard(picBoxCard1);
            ResetFruitBoxCard(picBoxCard2);
            ResetFruitBoxCard(picBoxCard3);
            ResetFruitBoxCard(picBoxCard4);
            ResetFruitBoxCard(picBoxCard5);
            ResetFruitBoxCard(picBoxCard6);
            ResetFruitBoxCard(picBoxCard7);
            ResetFruitBoxCard(picBoxCard8);
            ResetFruitBoxCard(picBoxCard9);
            ResetFruitBoxCard(picBoxCard10);
            ResetFruitBoxCard(picBoxCard11);
            ResetFruitBoxCard(picBoxCard12);
            ResetFruitBoxCard(picBoxCard13);
            ResetFruitBoxCard(picBoxCard14);
            ResetFruitBoxCard(picBoxCard15);
            ResetFruitBoxCard(picBoxCard16);
            ResetFruitBoxCard(picBoxCard17);
            ResetFruitBoxCard(picBoxCard18);
            ResetFruitBoxCard(picBoxCard19);
            ResetFruitBoxCard(picBoxCard20);
            ResetFruitBoxCard(picBoxCard21);
            ResetFruitBoxCard(picBoxCard22);
            ResetFruitBoxCard(picBoxCard23);
            ResetFruitBoxCard(picBoxCard24);
            ResetFruitBoxCard(picBoxCard25);
            ResetFruitBoxCard(picBoxCard26);
            ResetFruitBoxCard(picBoxCard27);
            ResetFruitBoxCard(picBoxCard28);
            ResetFruitBoxCard(picBoxCard29);
            ResetFruitBoxCard(picBoxCard30);
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
            FlipFruitBoxCard(BoxCard);
            CheckEnd();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLevel();
        }
    }
}
