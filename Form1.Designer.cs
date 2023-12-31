﻿namespace pokemonMachine
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
            this.tmr_reel1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_reel2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_reel3 = new System.Windows.Forms.Timer(this.components);
            this.tmr_master = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nudges = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tmr_hold = new System.Windows.Forms.Timer(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_winnings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudge_right = new System.Windows.Forms.PictureBox();
            this.nudge_centre = new System.Windows.Forms.PictureBox();
            this.nudge_left = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.PB_bottom_centre = new System.Windows.Forms.PictureBox();
            this.PB_bottom_left = new System.Windows.Forms.PictureBox();
            this.PB_bottom_right = new System.Windows.Forms.PictureBox();
            this.PB_top_right = new System.Windows.Forms.PictureBox();
            this.PB_top_centre = new System.Windows.Forms.PictureBox();
            this.PB_top_left = new System.Windows.Forms.PictureBox();
            this.PB_right_centre = new System.Windows.Forms.PictureBox();
            this.PB_middle_centre = new System.Windows.Forms.PictureBox();
            this.PB_left_centre = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_centre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_centre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_centre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_right_centre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_middle_centre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_left_centre)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_reel1
            // 
            this.tmr_reel1.Enabled = true;
            this.tmr_reel1.Tick += new System.EventHandler(this.tmr_reel1_Tick);
            // 
            // tmr_reel2
            // 
            this.tmr_reel2.Enabled = true;
            this.tmr_reel2.Tick += new System.EventHandler(this.tmr_reel2_Tick);
            // 
            // tmr_reel3
            // 
            this.tmr_reel3.Enabled = true;
            this.tmr_reel3.Tick += new System.EventHandler(this.tmr_reel3_Tick);
            // 
            // tmr_master
            // 
            this.tmr_master.Tick += new System.EventHandler(this.tmr_master_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PB_top_left);
            this.panel1.Location = new System.Drawing.Point(188, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 41);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PB_top_centre);
            this.panel2.Location = new System.Drawing.Point(292, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 41);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PB_top_right);
            this.panel3.Location = new System.Drawing.Point(394, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PB_bottom_right);
            this.panel4.Location = new System.Drawing.Point(394, 280);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 41);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PB_bottom_left);
            this.panel5.Location = new System.Drawing.Point(188, 280);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 41);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PB_bottom_centre);
            this.panel6.Location = new System.Drawing.Point(292, 280);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 41);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "NUDGES";
            // 
            // lbl_nudges
            // 
            this.lbl_nudges.AutoSize = true;
            this.lbl_nudges.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_nudges.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nudges.ForeColor = System.Drawing.Color.Lime;
            this.lbl_nudges.Location = new System.Drawing.Point(0, 0);
            this.lbl_nudges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nudges.Name = "lbl_nudges";
            this.lbl_nudges.Size = new System.Drawing.Size(52, 55);
            this.lbl_nudges.TabIndex = 4;
            this.lbl_nudges.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbl_nudges);
            this.panel7.ForeColor = System.Drawing.Color.Lime;
            this.panel7.Location = new System.Drawing.Point(548, 344);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 60);
            this.panel7.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit";
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_credit.ForeColor = System.Drawing.Color.Lime;
            this.lbl_credit.Location = new System.Drawing.Point(0, 0);
            this.lbl_credit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(80, 55);
            this.lbl_credit.TabIndex = 4;
            this.lbl_credit.Text = "20";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lbl_credit);
            this.panel8.ForeColor = System.Drawing.Color.Lime;
            this.panel8.Location = new System.Drawing.Point(542, 37);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(102, 60);
            this.panel8.TabIndex = 5;
            // 
            // tmr_hold
            // 
            this.tmr_hold.Interval = 500;
            this.tmr_hold.Tick += new System.EventHandler(this.tmr_hold_Tick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lbl_winnings);
            this.panel9.ForeColor = System.Drawing.Color.Lime;
            this.panel9.Location = new System.Drawing.Point(52, 37);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(102, 60);
            this.panel9.TabIndex = 5;
            // 
            // lbl_winnings
            // 
            this.lbl_winnings.AutoSize = true;
            this.lbl_winnings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_winnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnings.ForeColor = System.Drawing.Color.Lime;
            this.lbl_winnings.Location = new System.Drawing.Point(0, 0);
            this.lbl_winnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_winnings.Name = "lbl_winnings";
            this.lbl_winnings.Size = new System.Drawing.Size(52, 55);
            this.lbl_winnings.TabIndex = 4;
            this.lbl_winnings.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Winnings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::pokemonMachine.Properties.Resources.red_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(217, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pokemonMachine.Properties.Resources.winline;
            this.pictureBox1.Location = new System.Drawing.Point(742, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // nudge_right
            // 
            this.nudge_right.Image = global::pokemonMachine.Properties.Resources.nudge;
            this.nudge_right.Location = new System.Drawing.Point(394, 344);
            this.nudge_right.Margin = new System.Windows.Forms.Padding(2);
            this.nudge_right.Name = "nudge_right";
            this.nudge_right.Size = new System.Drawing.Size(75, 81);
            this.nudge_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nudge_right.TabIndex = 6;
            this.nudge_right.TabStop = false;
            this.nudge_right.Click += new System.EventHandler(this.nudge_right_Click);
            // 
            // nudge_centre
            // 
            this.nudge_centre.Image = global::pokemonMachine.Properties.Resources.nudge;
            this.nudge_centre.Location = new System.Drawing.Point(292, 344);
            this.nudge_centre.Margin = new System.Windows.Forms.Padding(2);
            this.nudge_centre.Name = "nudge_centre";
            this.nudge_centre.Size = new System.Drawing.Size(75, 81);
            this.nudge_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nudge_centre.TabIndex = 6;
            this.nudge_centre.TabStop = false;
            this.nudge_centre.Click += new System.EventHandler(this.nudge_centre_Click);
            // 
            // nudge_left
            // 
            this.nudge_left.Image = global::pokemonMachine.Properties.Resources.nudge;
            this.nudge_left.Location = new System.Drawing.Point(188, 344);
            this.nudge_left.Margin = new System.Windows.Forms.Padding(2);
            this.nudge_left.Name = "nudge_left";
            this.nudge_left.Size = new System.Drawing.Size(75, 81);
            this.nudge_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nudge_left.TabIndex = 6;
            this.nudge_left.TabStop = false;
            this.nudge_left.Click += new System.EventHandler(this.nudge_left_Click);
            // 
            // Play
            // 
            this.Play.Image = global::pokemonMachine.Properties.Resources.play;
            this.Play.Location = new System.Drawing.Point(536, 193);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(89, 91);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // PB_bottom_centre
            // 
            this.PB_bottom_centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_bottom_centre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_bottom_centre.Location = new System.Drawing.Point(0, 0);
            this.PB_bottom_centre.Margin = new System.Windows.Forms.Padding(2);
            this.PB_bottom_centre.Name = "PB_bottom_centre";
            this.PB_bottom_centre.Size = new System.Drawing.Size(75, 82);
            this.PB_bottom_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_bottom_centre.TabIndex = 0;
            this.PB_bottom_centre.TabStop = false;
            // 
            // PB_bottom_left
            // 
            this.PB_bottom_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_bottom_left.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_bottom_left.Location = new System.Drawing.Point(0, 0);
            this.PB_bottom_left.Margin = new System.Windows.Forms.Padding(2);
            this.PB_bottom_left.Name = "PB_bottom_left";
            this.PB_bottom_left.Size = new System.Drawing.Size(75, 82);
            this.PB_bottom_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_bottom_left.TabIndex = 0;
            this.PB_bottom_left.TabStop = false;
            // 
            // PB_bottom_right
            // 
            this.PB_bottom_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_bottom_right.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_bottom_right.Location = new System.Drawing.Point(0, 0);
            this.PB_bottom_right.Margin = new System.Windows.Forms.Padding(2);
            this.PB_bottom_right.Name = "PB_bottom_right";
            this.PB_bottom_right.Size = new System.Drawing.Size(75, 82);
            this.PB_bottom_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_bottom_right.TabIndex = 0;
            this.PB_bottom_right.TabStop = false;
            // 
            // PB_top_right
            // 
            this.PB_top_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_top_right.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_top_right.Location = new System.Drawing.Point(0, -41);
            this.PB_top_right.Margin = new System.Windows.Forms.Padding(2);
            this.PB_top_right.Name = "PB_top_right";
            this.PB_top_right.Size = new System.Drawing.Size(75, 82);
            this.PB_top_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_top_right.TabIndex = 0;
            this.PB_top_right.TabStop = false;
            // 
            // PB_top_centre
            // 
            this.PB_top_centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_top_centre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_top_centre.Location = new System.Drawing.Point(0, -41);
            this.PB_top_centre.Margin = new System.Windows.Forms.Padding(2);
            this.PB_top_centre.Name = "PB_top_centre";
            this.PB_top_centre.Size = new System.Drawing.Size(75, 82);
            this.PB_top_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_top_centre.TabIndex = 0;
            this.PB_top_centre.TabStop = false;
            // 
            // PB_top_left
            // 
            this.PB_top_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_top_left.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_top_left.Location = new System.Drawing.Point(0, -41);
            this.PB_top_left.Margin = new System.Windows.Forms.Padding(2);
            this.PB_top_left.Name = "PB_top_left";
            this.PB_top_left.Size = new System.Drawing.Size(75, 82);
            this.PB_top_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_top_left.TabIndex = 0;
            this.PB_top_left.TabStop = false;
            // 
            // PB_right_centre
            // 
            this.PB_right_centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_right_centre.ImageLocation = "";
            this.PB_right_centre.Location = new System.Drawing.Point(394, 193);
            this.PB_right_centre.Margin = new System.Windows.Forms.Padding(2);
            this.PB_right_centre.Name = "PB_right_centre";
            this.PB_right_centre.Size = new System.Drawing.Size(76, 82);
            this.PB_right_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_right_centre.TabIndex = 0;
            this.PB_right_centre.TabStop = false;
            // 
            // PB_middle_centre
            // 
            this.PB_middle_centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_middle_centre.ImageLocation = "";
            this.PB_middle_centre.Location = new System.Drawing.Point(292, 193);
            this.PB_middle_centre.Margin = new System.Windows.Forms.Padding(2);
            this.PB_middle_centre.Name = "PB_middle_centre";
            this.PB_middle_centre.Size = new System.Drawing.Size(76, 82);
            this.PB_middle_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_middle_centre.TabIndex = 0;
            this.PB_middle_centre.TabStop = false;
            // 
            // PB_left_centre
            // 
            this.PB_left_centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_left_centre.ImageLocation = "";
            this.PB_left_centre.Location = new System.Drawing.Point(188, 193);
            this.PB_left_centre.Margin = new System.Windows.Forms.Padding(0);
            this.PB_left_centre.Name = "PB_left_centre";
            this.PB_left_centre.Size = new System.Drawing.Size(76, 82);
            this.PB_left_centre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_left_centre.TabIndex = 0;
            this.PB_left_centre.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 505);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudge_right);
            this.Controls.Add(this.nudge_centre);
            this.Controls.Add(this.nudge_left);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_right_centre);
            this.Controls.Add(this.PB_middle_centre);
            this.Controls.Add(this.PB_left_centre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pokemon Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_centre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudge_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_centre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bottom_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_centre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_top_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_right_centre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_middle_centre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_left_centre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_reel1;
        private System.Windows.Forms.Timer tmr_reel2;
        private System.Windows.Forms.Timer tmr_reel3;
        private System.Windows.Forms.Timer tmr_master;
        private System.Windows.Forms.PictureBox PB_left_centre;
        private System.Windows.Forms.PictureBox PB_middle_centre;
        private System.Windows.Forms.PictureBox PB_right_centre;
        private System.Windows.Forms.PictureBox PB_top_left;
        private System.Windows.Forms.PictureBox PB_bottom_left;
        private System.Windows.Forms.PictureBox PB_bottom_centre;
        private System.Windows.Forms.PictureBox PB_bottom_right;
        private System.Windows.Forms.PictureBox PB_top_centre;
        private System.Windows.Forms.PictureBox PB_top_right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nudges;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox nudge_left;
        private System.Windows.Forms.PictureBox nudge_centre;
        private System.Windows.Forms.PictureBox nudge_right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_credit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer tmr_hold;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_winnings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

