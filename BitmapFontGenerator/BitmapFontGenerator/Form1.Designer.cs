namespace BitmapFontGenerator
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            sizeInput = new TextBox();
            label3 = new Label();
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(136, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 426);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "输入文本：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 422);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 30);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(386, 417);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 3;
            button1.Text = "生成JSON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 466);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(723, 239);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 335);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 5;
            label2.Text = "size:";
            // 
            // sizeInput
            // 
            sizeInput.Location = new Point(112, 332);
            sizeInput.Name = "sizeInput";
            sizeInput.Size = new Size(117, 30);
            sizeInput.TabIndex = 6;
            sizeInput.Text = "16,16";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 385);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 7;
            label3.Text = "选择字体:";
            // 
            // button2
            // 
            button2.Location = new Point(148, 378);
            button2.Name = "button2";
            button2.Size = new Size(177, 38);
            button2.TabIndex = 8;
            button2.Text = "Open dialog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 711);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 9;
            label4.Text = "Github主页：";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(166, 711);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(234, 24);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/xy660";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button3
            // 
            button3.Location = new Point(509, 417);
            button3.Name = "button3";
            button3.Size = new Size(121, 43);
            button3.TabIndex = 11;
            button3.Text = "打开图像";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(636, 416);
            button4.Name = "button4";
            button4.Size = new Size(121, 43);
            button4.TabIndex = 12;
            button4.Text = "完整字体";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 744);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(sizeInput);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "1bit位图生成器";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox sizeInput;
        private Label label3;
        private Button button2;
        private NotifyIcon notifyIcon1;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button3;
        private Button button4;
    }
}
