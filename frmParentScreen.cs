using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flip_Cards_Game
{
    public partial class frmParentScreen : Form
    {
        public frmParentScreen()
        {
            InitializeComponent();
        }

        protected PictureBox Box1 = null;
        protected PictureBox Box2 = null;

        private void frmParentScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            Location = new Point(0,0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ((frmMainMenu)this.MdiParent).AppearMainForm();
            this.Close();
        }

        protected void ChangeCursorBetHandDef(object sender, EventArgs e)
        {
            if (Cursor == Cursors.Hand)
                Cursor = Cursors.Default;
            else
                Cursor = Cursors.Hand;
        }

        protected void ResetAnimalBoxCard(PictureBox BoxCard)
        {
            BoxCard.Image = Properties.Resources.AnimalsQuestionMark;
            BoxCard.Enabled = true;
        }

        protected void ResetFruitBoxCard(PictureBox BoxCard)
        {
            BoxCard.Image = Properties.Resources.FruitsQuestionMark;
            BoxCard.Enabled = true;
        }

        private void CompareAnimalBoxes()
        {
            if (Box1.Tag != Box2.Tag)
            {
                ResetAnimalBoxCard(Box1);
                ResetAnimalBoxCard(Box2);
            }
        }

        private void CompareFruitBoxes()
        {
            if (Box1.Tag != Box2.Tag)
            {
                ResetFruitBoxCard(Box1);
                ResetFruitBoxCard(Box2);
            }
        }

        private void ChangeAnimalBoxImage(PictureBox Box)
        {
            switch (Box.Tag.ToString())
            {
                case "Lion":
                    Box.Image = Properties.Resources.Lion ;
                    return;
                case "Mouse":
                    Box.Image = Properties.Resources.Mouse;
                    return;
                case "Owl":
                    Box.Image = Properties.Resources.Owl;
                    return;
                case "Elephent":
                    Box.Image = Properties.Resources.Elephent;
                    return;
                case "Cheep":
                    Box.Image = Properties.Resources.Cheep;
                    return;
                case "Turtle":
                    Box.Image = Properties.Resources.Turtle;
                    return;
                case "Monkey":
                    Box.Image = Properties.Resources.Monkey;
                    return;
                case "Fox":
                    Box.Image = Properties.Resources.Fox;
                    return;
                case "Squirrel":
                    Box.Image = Properties.Resources.Squirrel;
                    return;
                case "Cow":
                    Box.Image = Properties.Resources.Cow;
                    return;
                case "Dog":
                    Box.Image = Properties.Resources.Dog;
                    return;
                case "Bird":
                    Box.Image = Properties.Resources.Bird;
                    return;
                case "Panda":
                    Box.Image = Properties.Resources.Panda;
                    return;
                case "Frog":
                    Box.Image = Properties.Resources.Frog;
                    return;
                case "Rooster":
                    Box.Image = Properties.Resources.Rooster;
                    return;
                default:
                    Box.Image = Properties.Resources.AnimalsQuestionMark;
                    return;
            }
        }

        private void ChangeFruitBoxImage(PictureBox Box)
        {
            switch (Box.Tag.ToString())
            {
                case "Apple":
                    Box.Image = Properties.Resources.Apple;
                    return;
                case "Banana":
                    Box.Image = Properties.Resources.Banana;
                    return;
                case "Orange":
                    Box.Image = Properties.Resources.Orange;
                    return;
                case "Mango":
                    Box.Image = Properties.Resources.Mango;
                    return;
                case "Strawberry":
                    Box.Image = Properties.Resources.Strawberry;
                    return;
                case "Grape":
                    Box.Image = Properties.Resources.Grape;
                    return;
                case "Pineapple":
                    Box.Image = Properties.Resources.Pineapple;
                    return;
                case "Watermelon":
                    Box.Image = Properties.Resources.Watermelon;
                    return;
                case "Blueberry":
                    Box.Image = Properties.Resources.Blueberry;
                    return;
                case "Raspberry":
                    Box.Image = Properties.Resources.Raspberry;
                    return;
                case "Cherry":
                    Box.Image = Properties.Resources.Cherry;
                    return;
                case "Peach":
                    Box.Image = Properties.Resources.Peach;
                    return;
                case "Kiwi":
                    Box.Image = Properties.Resources.Kiwi;
                    return;
                case "Papaya":
                    Box.Image = Properties.Resources.Papaya;
                    return;
                case "Pomegranate":
                    Box.Image = Properties.Resources.Pomegranate;
                    return;
                default:
                    Box.Image = Properties.Resources.FruitsQuestionMark;
                    return;
            }
        }

        protected async void FlipAnimalBoxCard(PictureBox BoxCard)
        {
            ChangeAnimalBoxImage(BoxCard);

            if (Box1 == null)
            {
                Box1 = BoxCard;
                BoxCard.Enabled = false;
                return;
            }
            else if (Box1 != null && Box2 == null)
            {
                Box2 = BoxCard;
                BoxCard.Enabled = false;

                await Task.Delay(500);
                CompareAnimalBoxes();
                Box1 = null;
                Box2 = null;
            }
        }

        protected async void FlipFruitBoxCard(PictureBox BoxCard)
        {
            ChangeFruitBoxImage(BoxCard);

            if (Box1 == null)
            {
                Box1 = BoxCard;
                BoxCard.Enabled = false;
                return;
            }
            else if (Box1 != null && Box2 == null)
            {
                Box2 = BoxCard;
                BoxCard.Enabled = false;

                await Task.Delay(500);
                CompareFruitBoxes();
                Box1 = null;
                Box2 = null;
            }
        }
    }
}
