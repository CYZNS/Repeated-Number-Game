namespace Repeated_Number_Game
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nd1 = new System.Windows.Forms.NumericUpDown();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nd1)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(295, 280);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 53);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nd1
            // 
            this.nd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nd1.Location = new System.Drawing.Point(295, 373);
            this.nd1.Name = "nd1";
            this.nd1.Size = new System.Drawing.Size(135, 36);
            this.nd1.TabIndex = 23;
            this.nd1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(295, 508);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(154, 53);
            this.btnCheck.TabIndex = 24;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtChoice
            // 
            this.txtChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChoice.Enabled = false;
            this.txtChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtChoice.Location = new System.Drawing.Point(295, 452);
            this.txtChoice.MaxLength = 2;
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(135, 36);
            this.txtChoice.TabIndex = 25;
            this.txtChoice.TextChanged += new System.EventHandler(this.txtChoice_TextChanged);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbNumber.Location = new System.Drawing.Point(708, 144);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(0, 46);
            this.lbNumber.TabIndex = 32;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.btn25);
            this.GamePanel.Controls.Add(this.btn20);
            this.GamePanel.Controls.Add(this.btn15);
            this.GamePanel.Controls.Add(this.btn10);
            this.GamePanel.Controls.Add(this.btn5);
            this.GamePanel.Controls.Add(this.btn24);
            this.GamePanel.Controls.Add(this.btn23);
            this.GamePanel.Controls.Add(this.btn22);
            this.GamePanel.Controls.Add(this.btn21);
            this.GamePanel.Controls.Add(this.btn19);
            this.GamePanel.Controls.Add(this.btn18);
            this.GamePanel.Controls.Add(this.btn17);
            this.GamePanel.Controls.Add(this.btn14);
            this.GamePanel.Controls.Add(this.btn13);
            this.GamePanel.Controls.Add(this.btn12);
            this.GamePanel.Controls.Add(this.btn9);
            this.GamePanel.Controls.Add(this.btn8);
            this.GamePanel.Controls.Add(this.btn7);
            this.GamePanel.Controls.Add(this.btn4);
            this.GamePanel.Controls.Add(this.btn3);
            this.GamePanel.Controls.Add(this.btn2);
            this.GamePanel.Controls.Add(this.btn16);
            this.GamePanel.Controls.Add(this.btn11);
            this.GamePanel.Controls.Add(this.btn6);
            this.GamePanel.Controls.Add(this.btn1);
            this.GamePanel.Location = new System.Drawing.Point(503, 208);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(497, 396);
            this.GamePanel.TabIndex = 33;
            this.GamePanel.Visible = false;
            // 
            // btn25
            // 
            this.btn25.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn25.Enabled = false;
            this.btn25.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn25.FlatAppearance.BorderSize = 0;
            this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25.Location = new System.Drawing.Point(399, 328);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(68, 60);
            this.btn25.TabIndex = 56;
            this.btn25.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn20.Enabled = false;
            this.btn20.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn20.FlatAppearance.BorderSize = 0;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Location = new System.Drawing.Point(399, 248);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(68, 60);
            this.btn20.TabIndex = 55;
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn15.Enabled = false;
            this.btn15.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn15.FlatAppearance.BorderSize = 0;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Location = new System.Drawing.Point(399, 168);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(68, 60);
            this.btn15.TabIndex = 54;
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn10.Enabled = false;
            this.btn10.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(399, 88);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(68, 60);
            this.btn10.TabIndex = 53;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn5.Enabled = false;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(399, 8);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 60);
            this.btn5.TabIndex = 52;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn24
            // 
            this.btn24.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn24.Enabled = false;
            this.btn24.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn24.FlatAppearance.BorderSize = 0;
            this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn24.Location = new System.Drawing.Point(305, 328);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(68, 60);
            this.btn24.TabIndex = 51;
            this.btn24.UseVisualStyleBackColor = false;
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn23.Enabled = false;
            this.btn23.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn23.FlatAppearance.BorderSize = 0;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Location = new System.Drawing.Point(213, 328);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(68, 60);
            this.btn23.TabIndex = 50;
            this.btn23.UseVisualStyleBackColor = false;
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn22.Enabled = false;
            this.btn22.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn22.FlatAppearance.BorderSize = 0;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Location = new System.Drawing.Point(121, 328);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(68, 60);
            this.btn22.TabIndex = 49;
            this.btn22.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn21.Enabled = false;
            this.btn21.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn21.FlatAppearance.BorderSize = 0;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Location = new System.Drawing.Point(29, 328);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(68, 60);
            this.btn21.TabIndex = 48;
            this.btn21.UseVisualStyleBackColor = false;
            // 
            // btn19
            // 
            this.btn19.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn19.Enabled = false;
            this.btn19.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn19.FlatAppearance.BorderSize = 0;
            this.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn19.Location = new System.Drawing.Point(305, 248);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(68, 60);
            this.btn19.TabIndex = 47;
            this.btn19.UseVisualStyleBackColor = false;
            // 
            // btn18
            // 
            this.btn18.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn18.Enabled = false;
            this.btn18.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn18.FlatAppearance.BorderSize = 0;
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn18.Location = new System.Drawing.Point(213, 248);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(68, 60);
            this.btn18.TabIndex = 46;
            this.btn18.UseVisualStyleBackColor = false;
            // 
            // btn17
            // 
            this.btn17.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn17.Enabled = false;
            this.btn17.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn17.FlatAppearance.BorderSize = 0;
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn17.Location = new System.Drawing.Point(121, 248);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(68, 60);
            this.btn17.TabIndex = 45;
            this.btn17.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn14.Enabled = false;
            this.btn14.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn14.FlatAppearance.BorderSize = 0;
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Location = new System.Drawing.Point(305, 168);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(68, 60);
            this.btn14.TabIndex = 44;
            this.btn14.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn13.Enabled = false;
            this.btn13.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn13.FlatAppearance.BorderSize = 0;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Location = new System.Drawing.Point(213, 168);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(68, 60);
            this.btn13.TabIndex = 43;
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn12.Enabled = false;
            this.btn12.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn12.FlatAppearance.BorderSize = 0;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Location = new System.Drawing.Point(121, 168);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(68, 60);
            this.btn12.TabIndex = 42;
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn9.Enabled = false;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(305, 88);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 60);
            this.btn9.TabIndex = 41;
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn8.Enabled = false;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(213, 88);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 60);
            this.btn8.TabIndex = 40;
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn7.Enabled = false;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(121, 88);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 60);
            this.btn7.TabIndex = 39;
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn4.Enabled = false;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(305, 8);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 60);
            this.btn4.TabIndex = 38;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn3.Enabled = false;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(213, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 60);
            this.btn3.TabIndex = 37;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(121, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 60);
            this.btn2.TabIndex = 36;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn16.Enabled = false;
            this.btn16.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn16.FlatAppearance.BorderSize = 0;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Location = new System.Drawing.Point(29, 248);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(68, 60);
            this.btn16.TabIndex = 35;
            this.btn16.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn11.Enabled = false;
            this.btn11.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Location = new System.Drawing.Point(29, 168);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(68, 60);
            this.btn11.TabIndex = 34;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn6.Enabled = false;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(29, 88);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 60);
            this.btn6.TabIndex = 33;
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.Enabled = false;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(29, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 60);
            this.btn1.TabIndex = 32;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repeated Number Game";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.SeaShell;
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.lbTimer.ForeColor = System.Drawing.Color.Black;
            this.lbTimer.Location = new System.Drawing.Point(85, 316);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(128, 142);
            this.lbTimer.TabIndex = 38;
            this.lbTimer.Text = "0";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTimer.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Repeated_Number_Game.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(30, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 47);
            this.label2.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.nd1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Repeated Number Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nd1)).EndInit();
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nd1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

