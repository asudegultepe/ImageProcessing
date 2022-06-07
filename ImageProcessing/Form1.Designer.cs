
namespace ImageProcessing
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.button20 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mean Filter 3x3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 267);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(602, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 267);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gaussian Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edge 4-connected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "Edge 8-connected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(429, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 25);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sharpen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "Sharpen More";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(429, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "Brightness";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(463, 312);
            this.hScrollBar1.Maximum = 70;
            this.hScrollBar1.Minimum = -70;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(122, 23);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(463, 371);
            this.hScrollBar2.Maximum = 70;
            this.hScrollBar2.Minimum = -70;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(122, 23);
            this.hScrollBar2.TabIndex = 13;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(429, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(429, 397);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 25);
            this.button8.TabIndex = 11;
            this.button8.Text = "Contrast";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(719, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Image After Processing";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(429, 516);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 28);
            this.button9.TabIndex = 16;
            this.button9.Text = "Down Scale";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(429, 550);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(156, 28);
            this.button10.TabIndex = 17;
            this.button10.Text = "Up Scale -NN";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(429, 584);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 28);
            this.button11.TabIndex = 18;
            this.button11.Text = "Up Scale Linear";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(681, 432);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 21);
            this.button12.TabIndex = 19;
            this.button12.Text = "Rot 90";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(747, 433);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 21);
            this.button13.TabIndex = 20;
            this.button13.Text = "Rot -90";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(813, 433);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 21);
            this.button14.TabIndex = 21;
            this.button14.Text = "Rot 180";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(696, 464);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 24);
            this.button15.TabIndex = 22;
            this.button15.Text = "Flip V";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(777, 464);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 24);
            this.button16.TabIndex = 23;
            this.button16.Text = "Flip H";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(696, 494);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 24);
            this.button17.TabIndex = 24;
            this.button17.Text = "Rot Ar.";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(429, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 23);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "0";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(129, 403);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(104, 31);
            this.button18.TabIndex = 26;
            this.button18.Text = "Load";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(475, 82);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 24);
            this.button19.TabIndex = 27;
            this.button19.Text = "<<";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(777, 495);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 23);
            this.textBox4.TabIndex = 28;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(463, 432);
            this.hScrollBar3.Maximum = 20;
            this.hScrollBar3.Minimum = 1;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(122, 23);
            this.hScrollBar3.TabIndex = 28;
            this.hScrollBar3.Value = 10;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll_1);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(429, 458);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(156, 25);
            this.button20.TabIndex = 29;
            this.button20.Text = "Gama";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 638);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Brightness";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Button button20;
    }
}

