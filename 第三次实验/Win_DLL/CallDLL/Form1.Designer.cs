namespace CallDLL
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
            menuStrip1 = new MenuStrip();
            阶乘ToolStripMenuItem = new ToolStripMenuItem();
            计算差值ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            labelResult = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 阶乘ToolStripMenuItem, 计算差值ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 阶乘ToolStripMenuItem
            // 
            阶乘ToolStripMenuItem.Name = "阶乘ToolStripMenuItem";
            阶乘ToolStripMenuItem.Size = new Size(62, 28);
            阶乘ToolStripMenuItem.Text = "阶乘";
            阶乘ToolStripMenuItem.Click += 阶乘ToolStripMenuItem_Click;
            // 
            // 计算差值ToolStripMenuItem
            // 
            计算差值ToolStripMenuItem.Name = "计算差值ToolStripMenuItem";
            计算差值ToolStripMenuItem.Size = new Size(98, 28);
            计算差值ToolStripMenuItem.Text = "计算差值";
            计算差值ToolStripMenuItem.Click += 计算差值ToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 117);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 2;
            label1.Text = "请输入数据a：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 168);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 3;
            label2.Text = "请输入数据b：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(327, 261);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "阶乘";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(312, 330);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(46, 24);
            labelResult.TabIndex = 6;
            labelResult.Text = "结果";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label labelResult;
        private ToolStripMenuItem 阶乘ToolStripMenuItem;
        private ToolStripMenuItem 计算差值ToolStripMenuItem;
    }
}