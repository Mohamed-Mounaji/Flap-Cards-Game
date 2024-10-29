namespace Flip_Cards_Game
{
    partial class frmFruitsEasy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFruitsEasy));
            this.picBoxCard12 = new System.Windows.Forms.PictureBox();
            this.picBoxCard11 = new System.Windows.Forms.PictureBox();
            this.picBoxCard10 = new System.Windows.Forms.PictureBox();
            this.picBoxCard9 = new System.Windows.Forms.PictureBox();
            this.picBoxCard8 = new System.Windows.Forms.PictureBox();
            this.picBoxCard7 = new System.Windows.Forms.PictureBox();
            this.picBoxCard6 = new System.Windows.Forms.PictureBox();
            this.picBoxCard5 = new System.Windows.Forms.PictureBox();
            this.picBoxCard4 = new System.Windows.Forms.PictureBox();
            this.picBoxCard3 = new System.Windows.Forms.PictureBox();
            this.picBoxCard2 = new System.Windows.Forms.PictureBox();
            this.picBoxCard1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.Size = new System.Drawing.Size(69, 28);
            this.lblMode.Text = "Fruits";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Size = new System.Drawing.Size(57, 28);
            this.lblDifficulty.Text = "Easy";
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.picBoxCard12);
            this.panel1.Controls.Add(this.picBoxCard11);
            this.panel1.Controls.Add(this.picBoxCard10);
            this.panel1.Controls.Add(this.picBoxCard9);
            this.panel1.Controls.Add(this.picBoxCard8);
            this.panel1.Controls.Add(this.picBoxCard7);
            this.panel1.Controls.Add(this.picBoxCard6);
            this.panel1.Controls.Add(this.picBoxCard5);
            this.panel1.Controls.Add(this.picBoxCard4);
            this.panel1.Controls.Add(this.picBoxCard3);
            this.panel1.Controls.Add(this.picBoxCard2);
            this.panel1.Controls.Add(this.picBoxCard1);
            // 
            // picBoxCard12
            // 
            this.picBoxCard12.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard12.Image")));
            this.picBoxCard12.Location = new System.Drawing.Point(575, 421);
            this.picBoxCard12.Name = "picBoxCard12";
            this.picBoxCard12.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard12.TabIndex = 26;
            this.picBoxCard12.TabStop = false;
            this.picBoxCard12.Tag = "Banana";
            this.picBoxCard12.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard12.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard12.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard11
            // 
            this.picBoxCard11.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard11.Image")));
            this.picBoxCard11.Location = new System.Drawing.Point(376, 421);
            this.picBoxCard11.Name = "picBoxCard11";
            this.picBoxCard11.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard11.TabIndex = 25;
            this.picBoxCard11.TabStop = false;
            this.picBoxCard11.Tag = "Kiwi";
            this.picBoxCard11.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard11.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard11.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard10
            // 
            this.picBoxCard10.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard10.Image")));
            this.picBoxCard10.Location = new System.Drawing.Point(177, 421);
            this.picBoxCard10.Name = "picBoxCard10";
            this.picBoxCard10.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard10.TabIndex = 24;
            this.picBoxCard10.TabStop = false;
            this.picBoxCard10.Tag = "Watermelon";
            this.picBoxCard10.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard10.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard10.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard9
            // 
            this.picBoxCard9.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard9.Image")));
            this.picBoxCard9.Location = new System.Drawing.Point(575, 295);
            this.picBoxCard9.Name = "picBoxCard9";
            this.picBoxCard9.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard9.TabIndex = 23;
            this.picBoxCard9.TabStop = false;
            this.picBoxCard9.Tag = "Apple";
            this.picBoxCard9.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard9.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard9.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard8
            // 
            this.picBoxCard8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard8.Image")));
            this.picBoxCard8.Location = new System.Drawing.Point(376, 295);
            this.picBoxCard8.Name = "picBoxCard8";
            this.picBoxCard8.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard8.TabIndex = 22;
            this.picBoxCard8.TabStop = false;
            this.picBoxCard8.Tag = "Orange";
            this.picBoxCard8.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard8.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard8.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard7
            // 
            this.picBoxCard7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard7.Image")));
            this.picBoxCard7.Location = new System.Drawing.Point(177, 295);
            this.picBoxCard7.Name = "picBoxCard7";
            this.picBoxCard7.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard7.TabIndex = 21;
            this.picBoxCard7.TabStop = false;
            this.picBoxCard7.Tag = "Banana";
            this.picBoxCard7.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard7.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard7.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard6
            // 
            this.picBoxCard6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard6.Image")));
            this.picBoxCard6.Location = new System.Drawing.Point(575, 169);
            this.picBoxCard6.Name = "picBoxCard6";
            this.picBoxCard6.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard6.TabIndex = 20;
            this.picBoxCard6.TabStop = false;
            this.picBoxCard6.Tag = "Peach";
            this.picBoxCard6.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard6.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard6.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard5
            // 
            this.picBoxCard5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard5.Image")));
            this.picBoxCard5.Location = new System.Drawing.Point(376, 169);
            this.picBoxCard5.Name = "picBoxCard5";
            this.picBoxCard5.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard5.TabIndex = 19;
            this.picBoxCard5.TabStop = false;
            this.picBoxCard5.Tag = "Kiwi";
            this.picBoxCard5.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard5.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard5.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard4
            // 
            this.picBoxCard4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard4.Image")));
            this.picBoxCard4.Location = new System.Drawing.Point(177, 169);
            this.picBoxCard4.Name = "picBoxCard4";
            this.picBoxCard4.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard4.TabIndex = 18;
            this.picBoxCard4.TabStop = false;
            this.picBoxCard4.Tag = "Peach";
            this.picBoxCard4.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard4.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard4.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard3
            // 
            this.picBoxCard3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard3.Image")));
            this.picBoxCard3.Location = new System.Drawing.Point(575, 43);
            this.picBoxCard3.Name = "picBoxCard3";
            this.picBoxCard3.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard3.TabIndex = 17;
            this.picBoxCard3.TabStop = false;
            this.picBoxCard3.Tag = "Watermelon";
            this.picBoxCard3.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard3.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard3.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard2
            // 
            this.picBoxCard2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard2.Image")));
            this.picBoxCard2.Location = new System.Drawing.Point(376, 43);
            this.picBoxCard2.Name = "picBoxCard2";
            this.picBoxCard2.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard2.TabIndex = 16;
            this.picBoxCard2.TabStop = false;
            this.picBoxCard2.Tag = "Orange";
            this.picBoxCard2.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard2.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard2.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // picBoxCard1
            // 
            this.picBoxCard1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCard1.Image")));
            this.picBoxCard1.Location = new System.Drawing.Point(177, 43);
            this.picBoxCard1.Name = "picBoxCard1";
            this.picBoxCard1.Size = new System.Drawing.Size(139, 92);
            this.picBoxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCard1.TabIndex = 15;
            this.picBoxCard1.TabStop = false;
            this.picBoxCard1.Tag = "Apple";
            this.picBoxCard1.Click += new System.EventHandler(this.BoxCard_Click);
            this.picBoxCard1.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.picBoxCard1.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // frmFruitsEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1302, 541);
            this.Name = "frmFruitsEasy";
            this.Click += new System.EventHandler(this.BoxCard_Click);
            this.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.MouseLeave += new System.EventHandler(this.PictureBox_MouseEnterLeave);
            this.Controls.SetChildIndex(this.lblMode, 0);
            this.Controls.SetChildIndex(this.lblDifficulty, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCard1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCard12;
        private System.Windows.Forms.PictureBox picBoxCard11;
        private System.Windows.Forms.PictureBox picBoxCard10;
        private System.Windows.Forms.PictureBox picBoxCard9;
        private System.Windows.Forms.PictureBox picBoxCard8;
        private System.Windows.Forms.PictureBox picBoxCard7;
        private System.Windows.Forms.PictureBox picBoxCard6;
        private System.Windows.Forms.PictureBox picBoxCard5;
        private System.Windows.Forms.PictureBox picBoxCard4;
        private System.Windows.Forms.PictureBox picBoxCard3;
        private System.Windows.Forms.PictureBox picBoxCard2;
        private System.Windows.Forms.PictureBox picBoxCard1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}
