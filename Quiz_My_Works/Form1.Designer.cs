namespace Quiz_My_Works
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
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            RichTextBoxSoru = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4SN = new Label();
            label5DD = new Label();
            label6YY = new Label();
            buttonNEXT = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonA
            // 
            buttonA.Location = new Point(22, 193);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(200, 50);
            buttonA.TabIndex = 0;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(228, 193);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(200, 50);
            buttonB.TabIndex = 1;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(22, 250);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(200, 50);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(228, 250);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(200, 50);
            buttonD.TabIndex = 3;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // RichTextBoxSoru
            // 
            RichTextBoxSoru.Location = new Point(22, 17);
            RichTextBoxSoru.Name = "RichTextBoxSoru";
            RichTextBoxSoru.Size = new Size(406, 170);
            RichTextBoxSoru.TabIndex = 4;
            RichTextBoxSoru.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 7;
            label3.Text = "Yanlış";
            // 
            // label4SN
            // 
            label4SN.AutoSize = true;
            label4SN.Location = new Point(542, 27);
            label4SN.Name = "label4SN";
            label4SN.Size = new Size(18, 19);
            label4SN.TabIndex = 8;
            label4SN.Text = "0";
            // 
            // label5DD
            // 
            label5DD.AutoSize = true;
            label5DD.Location = new Point(542, 73);
            label5DD.Name = "label5DD";
            label5DD.Size = new Size(18, 19);
            label5DD.TabIndex = 9;
            label5DD.Text = "0";
            // 
            // label6YY
            // 
            label6YY.AutoSize = true;
            label6YY.Location = new Point(542, 116);
            label6YY.Name = "label6YY";
            label6YY.Size = new Size(18, 19);
            label6YY.TabIndex = 10;
            label6YY.Text = "0";
            // 
            // buttonNEXT
            // 
            buttonNEXT.Location = new Point(457, 151);
            buttonNEXT.Name = "buttonNEXT";
            buttonNEXT.Size = new Size(165, 34);
            buttonNEXT.TabIndex = 11;
            buttonNEXT.Text = "Sonraki";
            buttonNEXT.UseVisualStyleBackColor = true;
            buttonNEXT.Click += buttonNEXT_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(539, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 27);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 60);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 305);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNEXT);
            Controls.Add(label6YY);
            Controls.Add(label5DD);
            Controls.Add(label4SN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RichTextBoxSoru);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private RichTextBox RichTextBoxSoru;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4SN;
        private Label label5DD;
        private Label label6YY;
        private Button buttonNEXT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}