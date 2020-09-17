namespace WasteCollection
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnlScoreBoard = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScoreBackground = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeBackground = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmptyOrganicWaste = new System.Windows.Forms.Button();
            this.pgBarOrganicWaste = new System.Windows.Forms.ProgressBar();
            this.listBoxOrganicWaste = new System.Windows.Forms.ListBox();
            this.btnOrganicWaste = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmptyPaper = new System.Windows.Forms.Button();
            this.pgBarPaper = new System.Windows.Forms.ProgressBar();
            this.listBoxPaper = new System.Windows.Forms.ListBox();
            this.btnPaperBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmptyGlass = new System.Windows.Forms.Button();
            this.pgBarGlass = new System.Windows.Forms.ProgressBar();
            this.listBoxGlass = new System.Windows.Forms.ListBox();
            this.btnGlassBox = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEmptyMetal = new System.Windows.Forms.Button();
            this.pgBarMetal = new System.Windows.Forms.ProgressBar();
            this.listBoxMetal = new System.Windows.Forms.ListBox();
            this.btnMetalBox = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlScoreBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlPicture.Controls.Add(this.pictureBox);
            this.pnlPicture.Location = new System.Drawing.Point(8, 8);
            this.pnlPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(197, 161);
            this.pnlPicture.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(173, 144);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pnlScoreBoard
            // 
            this.pnlScoreBoard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlScoreBoard.Controls.Add(this.textBox2);
            this.pnlScoreBoard.Controls.Add(this.button1);
            this.pnlScoreBoard.Controls.Add(this.txtScoreBackground);
            this.pnlScoreBoard.Controls.Add(this.txtScore);
            this.pnlScoreBoard.Controls.Add(this.label1);
            this.pnlScoreBoard.Controls.Add(this.txtTimeBackground);
            this.pnlScoreBoard.Controls.Add(this.txtTime);
            this.pnlScoreBoard.Controls.Add(this.btnNewGame);
            this.pnlScoreBoard.Location = new System.Drawing.Point(8, 182);
            this.pnlScoreBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlScoreBoard.Name = "pnlScoreBoard";
            this.pnlScoreBoard.Size = new System.Drawing.Size(197, 334);
            this.pnlScoreBoard.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(33, 214);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 33);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScoreBackground
            // 
            this.txtScoreBackground.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtScoreBackground.Enabled = false;
            this.txtScoreBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScoreBackground.ForeColor = System.Drawing.Color.White;
            this.txtScoreBackground.Location = new System.Drawing.Point(12, 200);
            this.txtScoreBackground.Margin = new System.Windows.Forms.Padding(0);
            this.txtScoreBackground.Multiline = true;
            this.txtScoreBackground.Name = "txtScoreBackground";
            this.txtScoreBackground.Size = new System.Drawing.Size(173, 59);
            this.txtScoreBackground.TabIndex = 6;
            this.txtScoreBackground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.DimGray;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 179);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScore.Size = new System.Drawing.Size(173, 25);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "PUAN";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimeBackground
            // 
            this.txtTimeBackground.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimeBackground.Enabled = false;
            this.txtTimeBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimeBackground.ForeColor = System.Drawing.Color.White;
            this.txtTimeBackground.Location = new System.Drawing.Point(12, 103);
            this.txtTimeBackground.Margin = new System.Windows.Forms.Padding(0);
            this.txtTimeBackground.Multiline = true;
            this.txtTimeBackground.Name = "txtTimeBackground";
            this.txtTimeBackground.Size = new System.Drawing.Size(173, 59);
            this.txtTimeBackground.TabIndex = 3;
            this.txtTimeBackground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.DimGray;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(12, 81);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(173, 25);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "SÜRE";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(12, 10);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(172, 57);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "YENİ OYUN";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Bisque;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(216, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "ATIK KUTULARI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEmptyOrganicWaste);
            this.panel1.Controls.Add(this.pgBarOrganicWaste);
            this.panel1.Controls.Add(this.listBoxOrganicWaste);
            this.panel1.Controls.Add(this.btnOrganicWaste);
            this.panel1.Location = new System.Drawing.Point(216, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 232);
            this.panel1.TabIndex = 10;
            // 
            // btnEmptyOrganicWaste
            // 
            this.btnEmptyOrganicWaste.Location = new System.Drawing.Point(8, 190);
            this.btnEmptyOrganicWaste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmptyOrganicWaste.Name = "btnEmptyOrganicWaste";
            this.btnEmptyOrganicWaste.Size = new System.Drawing.Size(131, 32);
            this.btnEmptyOrganicWaste.TabIndex = 3;
            this.btnEmptyOrganicWaste.Text = "BOŞALT";
            this.btnEmptyOrganicWaste.UseVisualStyleBackColor = true;
            this.btnEmptyOrganicWaste.Click += new System.EventHandler(this.btnEmptyOrganicWaste_Click);
            // 
            // pgBarOrganicWaste
            // 
            this.pgBarOrganicWaste.Location = new System.Drawing.Point(8, 170);
            this.pgBarOrganicWaste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgBarOrganicWaste.Name = "pgBarOrganicWaste";
            this.pgBarOrganicWaste.Size = new System.Drawing.Size(131, 15);
            this.pgBarOrganicWaste.TabIndex = 2;
            // 
            // listBoxOrganicWaste
            // 
            this.listBoxOrganicWaste.FormattingEnabled = true;
            this.listBoxOrganicWaste.Location = new System.Drawing.Point(8, 34);
            this.listBoxOrganicWaste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOrganicWaste.Name = "listBoxOrganicWaste";
            this.listBoxOrganicWaste.Size = new System.Drawing.Size(133, 134);
            this.listBoxOrganicWaste.TabIndex = 1;
            // 
            // btnOrganicWaste
            // 
            this.btnOrganicWaste.Location = new System.Drawing.Point(8, 8);
            this.btnOrganicWaste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrganicWaste.Name = "btnOrganicWaste";
            this.btnOrganicWaste.Size = new System.Drawing.Size(131, 21);
            this.btnOrganicWaste.TabIndex = 0;
            this.btnOrganicWaste.Text = "ORGANİK ATIK";
            this.btnOrganicWaste.UseVisualStyleBackColor = true;
            this.btnOrganicWaste.Click += new System.EventHandler(this.btnOrganicWaste_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEmptyPaper);
            this.panel2.Controls.Add(this.pgBarPaper);
            this.panel2.Controls.Add(this.listBoxPaper);
            this.panel2.Controls.Add(this.btnPaperBox);
            this.panel2.Location = new System.Drawing.Point(375, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 232);
            this.panel2.TabIndex = 11;
            // 
            // btnEmptyPaper
            // 
            this.btnEmptyPaper.Location = new System.Drawing.Point(8, 190);
            this.btnEmptyPaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmptyPaper.Name = "btnEmptyPaper";
            this.btnEmptyPaper.Size = new System.Drawing.Size(131, 32);
            this.btnEmptyPaper.TabIndex = 3;
            this.btnEmptyPaper.Text = "BOŞALT";
            this.btnEmptyPaper.UseVisualStyleBackColor = true;
            this.btnEmptyPaper.Click += new System.EventHandler(this.btnEmptyPaper_Click);
            // 
            // pgBarPaper
            // 
            this.pgBarPaper.Location = new System.Drawing.Point(8, 170);
            this.pgBarPaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgBarPaper.Name = "pgBarPaper";
            this.pgBarPaper.Size = new System.Drawing.Size(131, 15);
            this.pgBarPaper.TabIndex = 2;
            // 
            // listBoxPaper
            // 
            this.listBoxPaper.FormattingEnabled = true;
            this.listBoxPaper.Location = new System.Drawing.Point(8, 34);
            this.listBoxPaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPaper.Name = "listBoxPaper";
            this.listBoxPaper.Size = new System.Drawing.Size(133, 134);
            this.listBoxPaper.TabIndex = 1;
            // 
            // btnPaperBox
            // 
            this.btnPaperBox.Location = new System.Drawing.Point(8, 8);
            this.btnPaperBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaperBox.Name = "btnPaperBox";
            this.btnPaperBox.Size = new System.Drawing.Size(131, 21);
            this.btnPaperBox.TabIndex = 0;
            this.btnPaperBox.Text = "KAĞIT";
            this.btnPaperBox.UseVisualStyleBackColor = true;
            this.btnPaperBox.Click += new System.EventHandler(this.btnPaperBox_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEmptyGlass);
            this.panel3.Controls.Add(this.pgBarGlass);
            this.panel3.Controls.Add(this.listBoxGlass);
            this.panel3.Controls.Add(this.btnGlassBox);
            this.panel3.Location = new System.Drawing.Point(216, 285);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 232);
            this.panel3.TabIndex = 12;
            // 
            // btnEmptyGlass
            // 
            this.btnEmptyGlass.Location = new System.Drawing.Point(8, 190);
            this.btnEmptyGlass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmptyGlass.Name = "btnEmptyGlass";
            this.btnEmptyGlass.Size = new System.Drawing.Size(131, 32);
            this.btnEmptyGlass.TabIndex = 3;
            this.btnEmptyGlass.Text = "BOŞALT";
            this.btnEmptyGlass.UseVisualStyleBackColor = true;
            this.btnEmptyGlass.Click += new System.EventHandler(this.btnEmptyGlass_Click);
            // 
            // pgBarGlass
            // 
            this.pgBarGlass.Location = new System.Drawing.Point(8, 170);
            this.pgBarGlass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgBarGlass.Name = "pgBarGlass";
            this.pgBarGlass.Size = new System.Drawing.Size(131, 15);
            this.pgBarGlass.TabIndex = 2;
            // 
            // listBoxGlass
            // 
            this.listBoxGlass.FormattingEnabled = true;
            this.listBoxGlass.Location = new System.Drawing.Point(8, 34);
            this.listBoxGlass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxGlass.Name = "listBoxGlass";
            this.listBoxGlass.Size = new System.Drawing.Size(133, 134);
            this.listBoxGlass.TabIndex = 1;
            // 
            // btnGlassBox
            // 
            this.btnGlassBox.Location = new System.Drawing.Point(8, 8);
            this.btnGlassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGlassBox.Name = "btnGlassBox";
            this.btnGlassBox.Size = new System.Drawing.Size(131, 21);
            this.btnGlassBox.TabIndex = 0;
            this.btnGlassBox.Text = "CAM";
            this.btnGlassBox.UseVisualStyleBackColor = true;
            this.btnGlassBox.Click += new System.EventHandler(this.btnGlassBox_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnEmptyMetal);
            this.panel4.Controls.Add(this.pgBarMetal);
            this.panel4.Controls.Add(this.listBoxMetal);
            this.panel4.Controls.Add(this.btnMetalBox);
            this.panel4.Location = new System.Drawing.Point(375, 285);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 232);
            this.panel4.TabIndex = 12;
            // 
            // btnEmptyMetal
            // 
            this.btnEmptyMetal.Location = new System.Drawing.Point(8, 190);
            this.btnEmptyMetal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmptyMetal.Name = "btnEmptyMetal";
            this.btnEmptyMetal.Size = new System.Drawing.Size(131, 32);
            this.btnEmptyMetal.TabIndex = 3;
            this.btnEmptyMetal.Text = "BOŞALT";
            this.btnEmptyMetal.UseVisualStyleBackColor = true;
            this.btnEmptyMetal.Click += new System.EventHandler(this.btnEmptyMetal_Click);
            // 
            // pgBarMetal
            // 
            this.pgBarMetal.Location = new System.Drawing.Point(8, 170);
            this.pgBarMetal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgBarMetal.Name = "pgBarMetal";
            this.pgBarMetal.Size = new System.Drawing.Size(131, 15);
            this.pgBarMetal.TabIndex = 2;
            // 
            // listBoxMetal
            // 
            this.listBoxMetal.FormattingEnabled = true;
            this.listBoxMetal.Location = new System.Drawing.Point(8, 34);
            this.listBoxMetal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMetal.Name = "listBoxMetal";
            this.listBoxMetal.Size = new System.Drawing.Size(133, 134);
            this.listBoxMetal.TabIndex = 1;
            // 
            // btnMetalBox
            // 
            this.btnMetalBox.Location = new System.Drawing.Point(8, 8);
            this.btnMetalBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMetalBox.Name = "btnMetalBox";
            this.btnMetalBox.Size = new System.Drawing.Size(131, 21);
            this.btnMetalBox.TabIndex = 0;
            this.btnMetalBox.Text = "METAL";
            this.btnMetalBox.UseVisualStyleBackColor = true;
            this.btnMetalBox.Click += new System.EventHandler(this.btnMetalBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(549, 538);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlScoreBoard);
            this.Controls.Add(this.pnlPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "WASTE COLLECTION";
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlScoreBoard.ResumeLayout(false);
            this.pnlScoreBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnEmptyGlass;
        private System.Windows.Forms.Button btnEmptyMetal;
        private System.Windows.Forms.Button btnEmptyOrganicWaste;
        private System.Windows.Forms.Button btnEmptyPaper;
        private System.Windows.Forms.Button btnGlassBox;
        private System.Windows.Forms.Button btnMetalBox;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnOrganicWaste;
        private System.Windows.Forms.Button btnPaperBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGlass;
        private System.Windows.Forms.ListBox listBoxMetal;
        private System.Windows.Forms.ListBox listBoxOrganicWaste;
        private System.Windows.Forms.ListBox listBoxPaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar pgBarGlass;
        private System.Windows.Forms.ProgressBar pgBarMetal;
        private System.Windows.Forms.ProgressBar pgBarOrganicWaste;
        private System.Windows.Forms.ProgressBar pgBarPaper;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Panel pnlScoreBoard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreBackground;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtTimeBackground;

        #endregion
    }
}