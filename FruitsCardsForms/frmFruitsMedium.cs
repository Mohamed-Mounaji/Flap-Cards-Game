﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flip_Cards_Game
{
    public partial class frmFruitsMedium : Flip_Cards_Game.frmParentScreen
    {
        public frmFruitsMedium()
        {
            InitializeComponent();
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
            FlipFruitBoxCard(BoxCard);

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