namespace Flip_Cards_Game
{
    partial class frmParentScreen
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
            this.picboxBackToMainMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBackToMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxBackToMainMenu
            // 
            this.picboxBackToMainMenu.BackColor = System.Drawing.Color.Red;
            this.picboxBackToMainMenu.Image = global::Flip_Cards_Game.Properties.Resources.Arrow;
            this.picboxBackToMainMenu.Location = new System.Drawing.Point(4, 4);
            this.picboxBackToMainMenu.Name = "picboxBackToMainMenu";
            this.picboxBackToMainMenu.Size = new System.Drawing.Size(40, 35);
            this.picboxBackToMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxBackToMainMenu.TabIndex = 0;
            this.picboxBackToMainMenu.TabStop = false;
            this.picboxBackToMainMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picboxBackToMainMenu.MouseEnter += new System.EventHandler(this.ChangeCursorBetHandDef);
            this.picboxBackToMainMenu.MouseLeave += new System.EventHandler(this.ChangeCursorBetHandDef);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Difficulty :";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(14)))), ((int)(((byte)(115)))));
            this.lblMode.Location = new System.Drawing.Point(341, 20);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(30, 28);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "...";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(14)))), ((int)(((byte)(115)))));
            this.lblDifficulty.Location = new System.Drawing.Point(673, 20);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(30, 28);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel1.Location = new System.Drawing.Point(44, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 556);
            this.panel1.TabIndex = 5;
            // 
            // frmParentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParentScreen";
            this.Text = "frmParentScreen";
            this.Load += new System.EventHandler(this.frmParentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxBackToMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxBackToMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lblMode;
        protected System.Windows.Forms.Label lblDifficulty;
        protected System.Windows.Forms.Panel panel1;
    }
}