﻿namespace MotaConfig
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
            comboBox1 = new ComboBox();
            音量 = new Label();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "分辨率";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "640 x 480", "800 x 600", "960 x 720", "1120 x 840", "1280 x 960" });
            comboBox1.Location = new Point(80, 89);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 25);
            comboBox1.TabIndex = 1;
            // 
            // 音量
            // 
            音量.AutoSize = true;
            音量.Location = new Point(9, 171);
            音量.Margin = new Padding(2, 0, 2, 0);
            音量.Name = "音量";
            音量.Size = new Size(61, 17);
            音量.TabIndex = 2;
            音量.Text = "BGM音量";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.config;
            pictureBox1.Location = new Point(6, 8);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 69);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(72, 171);
            trackBar1.Margin = new Padding(2, 3, 2, 3);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(255, 45);
            trackBar1.TabIndex = 4;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(72, 224);
            trackBar2.Margin = new Padding(2, 3, 2, 3);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(255, 45);
            trackBar2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 5;
            label3.Text = "SE音量";
            // 
            // button1
            // 
            button1.Location = new Point(9, 263);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 7;
            button1.Text = "应用";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(119, 263);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 8;
            button2.Text = "确定并退出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(229, 263);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(100, 25);
            button3.TabIndex = 9;
            button3.Text = "退出";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 132);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 10;
            label2.Text = "刷新频率";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "16ms/次", "24ms/次", "32ms/次", "40ms/次", "48ms/次" });
            comboBox2.Location = new Point(80, 129);
            comboBox2.Margin = new Padding(2, 3, 2, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 25);
            comboBox2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 320);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(trackBar2);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox1);
            Controls.Add(音量);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MaximumSize = new Size(368, 359);
            MinimumSize = new Size(368, 359);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "游戏设置";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label 音量;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private ComboBox comboBox2;
    }
}