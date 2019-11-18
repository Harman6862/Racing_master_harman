namespace Racing_master_harman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choosePlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChooseDog = new System.Windows.Forms.ComboBox();
            this.setBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.fillBet = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.runningModule = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePlayer
            // 
            this.choosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePlayer.FormattingEnabled = true;
            this.choosePlayer.ItemHeight = 33;
            this.choosePlayer.Items.AddRange(new object[] {
            "Player1",
            "Player2",
            "Player3"});
            this.choosePlayer.Location = new System.Drawing.Point(12, 52);
            this.choosePlayer.Name = "choosePlayer";
            this.choosePlayer.Size = new System.Drawing.Size(138, 41);
            this.choosePlayer.TabIndex = 1;
            this.choosePlayer.SelectedIndexChanged += new System.EventHandler(this.ChoosePlayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(402, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Bet Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Dog";
            // 
            // ChooseDog
            // 
            this.ChooseDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDog.FormattingEnabled = true;
            this.ChooseDog.ItemHeight = 33;
            this.ChooseDog.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ChooseDog.Location = new System.Drawing.Point(12, 136);
            this.ChooseDog.Name = "ChooseDog";
            this.ChooseDog.Size = new System.Drawing.Size(138, 41);
            this.ChooseDog.TabIndex = 5;
            // 
            // setBet
            // 
            this.setBet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.setBet.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBet.ForeColor = System.Drawing.Color.White;
            this.setBet.Location = new System.Drawing.Point(405, 77);
            this.setBet.Name = "setBet";
            this.setBet.Size = new System.Drawing.Size(120, 31);
            this.setBet.TabIndex = 6;
            this.setBet.Text = "Set Bet";
            this.setBet.UseVisualStyleBackColor = false;
            this.setBet.Click += new System.EventHandler(this.setBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartRace.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRace.ForeColor = System.Drawing.Color.White;
            this.StartRace.Location = new System.Drawing.Point(406, 125);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(120, 31);
            this.StartRace.TabIndex = 7;
            this.StartRace.Text = "Race";
            this.StartRace.UseVisualStyleBackColor = false;
            this.StartRace.Visible = false;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // fillBet
            // 
            this.fillBet.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBet.Location = new System.Drawing.Point(406, 41);
            this.fillBet.Name = "fillBet";
            this.fillBet.Size = new System.Drawing.Size(100, 30);
            this.fillBet.TabIndex = 8;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Player1.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player1.Location = new System.Drawing.Point(133, 180);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(326, 23);
            this.Player1.TabIndex = 10;
            this.Player1.Text = "Player 1  has Total 120$ to Bet in this Game";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Player2.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player2.Location = new System.Drawing.Point(130, 217);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(328, 23);
            this.Player2.TabIndex = 11;
            this.Player2.Text = "Player 2  has Total 120$ to Bet in this Game";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Player3.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player3.Location = new System.Drawing.Point(130, 252);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(328, 23);
            this.Player3.TabIndex = 12;
            this.Player3.Text = "Player 3  has Total 120$ to Bet in this Game";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 673);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(498, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "  Game Finished || Game Finished  Game Finished || Game Finished";
            // 
            // dog1
            // 
            this.dog1.Image = global::Racing_master_harman.Properties.Resources.dog4;
            this.dog1.Location = new System.Drawing.Point(461, 295);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(64, 93);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 16;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::Racing_master_harman.Properties.Resources.dog3;
            this.dog2.Location = new System.Drawing.Point(309, 295);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(62, 93);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 15;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::Racing_master_harman.Properties.Resources.dog2;
            this.dog3.Location = new System.Drawing.Point(159, 295);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(56, 93);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 14;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::Racing_master_harman.Properties.Resources.dog1;
            this.dog4.Location = new System.Drawing.Point(12, 295);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(64, 93);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 13;
            this.dog4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(565, 11);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // runningModule
            // 
            this.runningModule.Tick += new System.EventHandler(this.runningModule_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 693);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fillBet);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.setBet);
            this.Controls.Add(this.ChooseDog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox choosePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ChooseDog;
        private System.Windows.Forms.Button setBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.TextBox fillBet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer runningModule;
    }
}

