using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flip_Cards_Game
{
    public partial class frmMainMenu : Form
    {
        
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public void ChangeCursorBetHandDefault(Object sender, EventArgs e)
        {
            if (Cursor == Cursors.Hand)
                Cursor = Cursors.Default;
            else
                Cursor = Cursors.Hand;
        }

        private bool CheckDifficultyBox()
        {
            errorProvider1.Clear();
            if (cboxDifficulty.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboxDifficulty, "Please Choose a difficulty mode");
                return false;
            }
            else
                return true;
        }

        public void DisappearMainForm()
        {
            picboxMainFormBackground.Visible = false;
            MainFormPanel.Visible = false;
        }
        public void AppearMainForm()
        {
            picboxMainFormBackground.Visible = true;
            MainFormPanel.Visible = true;
        }

        private void OpenChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            DisappearMainForm();
        }

        private void OpenAnimalsEasyModeForm()
        {
            Form form = new frmAnimalsEasy();
            OpenChildForm(form);
        }
        
        private void OpenAnimalsMediumModeForm()
        {
            Form form = new frmAnimalsMedium();
            OpenChildForm(form);
        }

        private void OpenAnimalsHardModeForm()
        {
            Form form = new frmAnimalsHard();
            OpenChildForm(form);
        }

        private void OpenFruitsEasyModeForm()
        {
            Form form = new frmFruitsEasy();
            OpenChildForm(form);
        }
        private void OpenFruitsMediumModeForm()
        {
            Form form = new frmFruitsMedium();
            OpenChildForm(form);
        }
        private void OpenFruitsHardModeForm()
        {
            Form form = new frmFruitsHard();
            OpenChildForm(form);
        }

        private void picboxAnimalMode_Click(object sender, EventArgs e)
        {
            if (!CheckDifficultyBox())
                return;

            if (cboxDifficulty.SelectedItem.ToString() == "Easy")
                OpenAnimalsEasyModeForm();
            else if (cboxDifficulty.SelectedItem.ToString() == "Medium")
                OpenAnimalsMediumModeForm();
            else if (cboxDifficulty.SelectedItem.ToString() == "Hard")
                OpenAnimalsHardModeForm();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!CheckDifficultyBox())
                return;
            if(cboxDifficulty.SelectedItem.ToString() == "Easy")
                OpenFruitsEasyModeForm();
            else if (cboxDifficulty.SelectedItem.ToString() == "Medium")
                OpenFruitsMediumModeForm();
            else if (cboxDifficulty.SelectedItem.ToString() == "Hard")
                OpenFruitsHardModeForm();
        }
    }
}

