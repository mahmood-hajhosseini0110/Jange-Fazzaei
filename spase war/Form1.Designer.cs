namespace spase_war
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txt_NamePlayer = new TextBox();
            btn_StartGame = new Button();
            btn_Exit = new Button();
            H1 = new PictureBox();
            bH1 = new Button();
            bH2 = new Button();
            pictureBox2 = new PictureBox();
            bH3 = new Button();
            pictureBox3 = new PictureBox();
            t3h = new Button();
            pictureBox4 = new PictureBox();
            t2h = new Button();
            pictureBox5 = new PictureBox();
            t1h = new Button();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)H1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Book Antiqua", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(71, 10);
            label1.Name = "label1";
            label1.Size = new Size(588, 73);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Gane Jet Fighter ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(19, 608);
            label2.Name = "label2";
            label2.Size = new Size(329, 43);
            label2.TabIndex = 0;
            label2.Text = "Please Enter your Name :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_NamePlayer
            // 
            txt_NamePlayer.Font = new Font("Book Antiqua", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NamePlayer.Location = new Point(395, 608);
            txt_NamePlayer.Multiline = true;
            txt_NamePlayer.Name = "txt_NamePlayer";
            txt_NamePlayer.Size = new Size(319, 43);
            txt_NamePlayer.TabIndex = 1;
            // 
            // btn_StartGame
            // 
            btn_StartGame.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btn_StartGame.FlatStyle = FlatStyle.Flat;
            btn_StartGame.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_StartGame.ForeColor = Color.Cyan;
            btn_StartGame.Location = new Point(19, 713);
            btn_StartGame.Margin = new Padding(0);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(224, 107);
            btn_StartGame.TabIndex = 2;
            btn_StartGame.Text = "Start Game ";
            btn_StartGame.UseVisualStyleBackColor = true;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(490, 713);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(224, 107);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // H1
            // 
            H1.BorderStyle = BorderStyle.Fixed3D;
            H1.Image = (Image)resources.GetObject("H1.Image");
            H1.Location = new Point(34, 119);
            H1.Name = "H1";
            H1.Size = new Size(99, 94);
            H1.SizeMode = PictureBoxSizeMode.StretchImage;
            H1.TabIndex = 3;
            H1.TabStop = false;
            // 
            // bH1
            // 
            bH1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            bH1.FlatStyle = FlatStyle.Flat;
            bH1.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bH1.ForeColor = Color.Cyan;
            bH1.Location = new Point(34, 233);
            bH1.Margin = new Padding(0);
            bH1.Name = "bH1";
            bH1.Size = new Size(99, 47);
            bH1.TabIndex = 6;
            bH1.Text = "انتخاب";
            bH1.UseVisualStyleBackColor = true;
            bH1.Click += button1_Click;
            // 
            // bH2
            // 
            bH2.FlatAppearance.MouseDownBackColor = Color.Cyan;
            bH2.FlatStyle = FlatStyle.Flat;
            bH2.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bH2.ForeColor = Color.Cyan;
            bH2.Location = new Point(305, 233);
            bH2.Margin = new Padding(0);
            bH2.Name = "bH2";
            bH2.Size = new Size(99, 47);
            bH2.TabIndex = 8;
            bH2.Text = "انتخاب";
            bH2.UseVisualStyleBackColor = true;
            bH2.Click += bH2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // bH3
            // 
            bH3.FlatAppearance.MouseDownBackColor = Color.Cyan;
            bH3.FlatStyle = FlatStyle.Flat;
            bH3.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bH3.ForeColor = Color.Cyan;
            bH3.Location = new Point(611, 233);
            bH3.Margin = new Padding(0);
            bH3.Name = "bH3";
            bH3.Size = new Size(101, 47);
            bH3.TabIndex = 10;
            bH3.Text = "انتخاب";
            bH3.UseVisualStyleBackColor = true;
            bH3.Click += bH3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(611, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // t3h
            // 
            t3h.FlatAppearance.MouseDownBackColor = Color.Cyan;
            t3h.FlatStyle = FlatStyle.Flat;
            t3h.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            t3h.ForeColor = Color.Cyan;
            t3h.Location = new Point(611, 478);
            t3h.Margin = new Padding(0);
            t3h.Name = "t3h";
            t3h.Size = new Size(101, 49);
            t3h.TabIndex = 16;
            t3h.Text = "انتخاب";
            t3h.UseVisualStyleBackColor = true;
            t3h.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(639, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // t2h
            // 
            t2h.FlatAppearance.MouseDownBackColor = Color.Cyan;
            t2h.FlatStyle = FlatStyle.Flat;
            t2h.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            t2h.ForeColor = Color.Cyan;
            t2h.Location = new Point(310, 476);
            t2h.Margin = new Padding(0);
            t2h.Name = "t2h";
            t2h.Size = new Size(101, 49);
            t2h.TabIndex = 14;
            t2h.Text = "انتخاب";
            t2h.UseVisualStyleBackColor = true;
            t2h.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(335, 337);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 122);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // t1h
            // 
            t1h.FlatAppearance.MouseDownBackColor = Color.Cyan;
            t1h.FlatStyle = FlatStyle.Flat;
            t1h.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            t1h.ForeColor = Color.Cyan;
            t1h.Location = new Point(34, 476);
            t1h.Margin = new Padding(0);
            t1h.Name = "t1h";
            t1h.Size = new Size(101, 49);
            t1h.TabIndex = 12;
            t1h.Text = "انتخاب";
            t1h.UseVisualStyleBackColor = true;
            t1h.Click += button6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(59, 339);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 121);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 263);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 17;
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(740, 854);
            Controls.Add(label3);
            Controls.Add(t3h);
            Controls.Add(pictureBox4);
            Controls.Add(t2h);
            Controls.Add(pictureBox5);
            Controls.Add(t1h);
            Controls.Add(pictureBox6);
            Controls.Add(bH3);
            Controls.Add(pictureBox3);
            Controls.Add(bH2);
            Controls.Add(pictureBox2);
            Controls.Add(bH1);
            Controls.Add(H1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_StartGame);
            Controls.Add(txt_NamePlayer);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            KeyDown += keydown_cklick_btn;
            ((System.ComponentModel.ISupportInitialize)H1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_StartGame;
        private Button btn_Exit;
        private PictureBox H1;
        private Button bH1;
        private Button bH2;
        private PictureBox pictureBox2;
        private Button bH3;
        private PictureBox pictureBox3;
        private Button t3h;
        private PictureBox pictureBox4;
        private Button t2h;
        private PictureBox pictureBox5;
        private Button t1h;
        private PictureBox pictureBox6;
        private Label label3;
        public TextBox txt_NamePlayer;
    }
}
