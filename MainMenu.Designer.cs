namespace Flip_Cards_Game
{
    partial class frmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picboxAnimalMode = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picboxMainFormBackground = new System.Windows.Forms.PictureBox();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnimalMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMainFormBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(14)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flip Cards Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.MainFormPanel.Controls.Add(this.label5);
            this.MainFormPanel.Controls.Add(this.label4);
            this.MainFormPanel.Controls.Add(this.cboxDifficulty);
            this.MainFormPanel.Controls.Add(this.label3);
            this.MainFormPanel.Controls.Add(this.label2);
            this.MainFormPanel.Controls.Add(this.pictureBox3);
            this.MainFormPanel.Controls.Add(this.picboxAnimalMode);
            this.MainFormPanel.Controls.Add(this.label1);
            this.MainFormPanel.Location = new System.Drawing.Point(529, -1);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(456, 669);
            this.MainFormPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Copyright - 2024 | Mohamed Mounaji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Difficulty Level";
            // 
            // cboxDifficulty
            // 
            this.cboxDifficulty.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDifficulty.FormattingEnabled = true;
            this.cboxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cboxDifficulty.Location = new System.Drawing.Point(149, 531);
            this.cboxDifficulty.Name = "cboxDifficulty";
            this.cboxDifficulty.Size = new System.Drawing.Size(157, 26);
            this.cboxDifficulty.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fruits Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Animals Mode";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Flip_Cards_Game.Properties.Resources.btnFruits;
            this.pictureBox3.Location = new System.Drawing.Point(116, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.ChangeCursorBetHandDefault);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.ChangeCursorBetHandDefault);
            // 
            // picboxAnimalMode
            // 
            this.picboxAnimalMode.Image = global::Flip_Cards_Game.Properties.Resources.btnAnimals;
            this.picboxAnimalMode.Location = new System.Drawing.Point(116, 167);
            this.picboxAnimalMode.Name = "picboxAnimalMode";
            this.picboxAnimalMode.Size = new System.Drawing.Size(223, 121);
            this.picboxAnimalMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAnimalMode.TabIndex = 4;
            this.picboxAnimalMode.TabStop = false;
            this.picboxAnimalMode.Click += new System.EventHandler(this.picboxAnimalMode_Click);
            this.picboxAnimalMode.MouseEnter += new System.EventHandler(this.ChangeCursorBetHandDefault);
            this.picboxAnimalMode.MouseLeave += new System.EventHandler(this.ChangeCursorBetHandDefault);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picboxMainFormBackground
            // 
            this.picboxMainFormBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxMainFormBackground.Image = global::Flip_Cards_Game.Properties.Resources.MainMenuBackground;
            this.picboxMainFormBackground.Location = new System.Drawing.Point(-2, -2);
            this.picboxMainFormBackground.Name = "picboxMainFormBackground";
            this.picboxMainFormBackground.Size = new System.Drawing.Size(986, 670);
            this.picboxMainFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMainFormBackground.TabIndex = 2;
            this.picboxMainFormBackground.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.MainFormPanel);
            this.Controls.Add(this.picboxMainFormBackground);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Text = "Flip Cards Game";
            this.MainFormPanel.ResumeLayout(false);
            this.MainFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnimalMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMainFormBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxMainFormBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picboxAnimalMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

