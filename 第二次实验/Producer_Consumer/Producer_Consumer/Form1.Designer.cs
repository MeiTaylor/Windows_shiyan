namespace Producer_Consumer
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
            label1 = new Label();
            listViewProducer = new ListView();
            label2 = new Label();
            btnProducer1 = new Button();
            btnProducer2 = new Button();
            btnProducer3 = new Button();
            btnProducer4 = new Button();
            txtAllProducer = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            btnConsumer = new Button();
            txtConsumer1 = new RichTextBox();
            label5 = new Label();
            txtConsumer2 = new RichTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 0;
            label1.Text = "生产者-消费者系统 ";
            // 
            // listViewProducer
            // 
            listViewProducer.Alignment = ListViewAlignment.Default;
            listViewProducer.Location = new Point(136, 96);
            listViewProducer.Name = "listViewProducer";
            listViewProducer.Size = new Size(588, 172);
            listViewProducer.TabIndex = 1;
            listViewProducer.UseCompatibleStateImageBehavior = false;
            listViewProducer.View = View.List;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 65);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 2;
            label2.Text = "生产者生产记录";
            // 
            // btnProducer1
            // 
            btnProducer1.Location = new Point(136, 311);
            btnProducer1.Name = "btnProducer1";
            btnProducer1.Size = new Size(112, 34);
            btnProducer1.TabIndex = 3;
            btnProducer1.Text = "开始生产1";
            btnProducer1.UseVisualStyleBackColor = true;
            btnProducer1.Click += btnProducer1_Click;
            // 
            // btnProducer2
            // 
            btnProducer2.Location = new Point(295, 311);
            btnProducer2.Name = "btnProducer2";
            btnProducer2.Size = new Size(112, 34);
            btnProducer2.TabIndex = 4;
            btnProducer2.Text = "开始生产2";
            btnProducer2.UseVisualStyleBackColor = true;
            btnProducer2.Click += btnProducer2_Click;
            // 
            // btnProducer3
            // 
            btnProducer3.Location = new Point(460, 311);
            btnProducer3.Name = "btnProducer3";
            btnProducer3.Size = new Size(112, 34);
            btnProducer3.TabIndex = 5;
            btnProducer3.Text = "开始生产3";
            btnProducer3.UseVisualStyleBackColor = true;
            btnProducer3.Click += btnProducer3_Click;
            // 
            // btnProducer4
            // 
            btnProducer4.Location = new Point(612, 311);
            btnProducer4.Name = "btnProducer4";
            btnProducer4.Size = new Size(112, 34);
            btnProducer4.TabIndex = 6;
            btnProducer4.Text = "开始生产4";
            btnProducer4.UseVisualStyleBackColor = true;
            btnProducer4.Click += btnProducer4_Click;
            // 
            // txtAllProducer
            // 
            txtAllProducer.Location = new Point(321, 374);
            txtAllProducer.Name = "txtAllProducer";
            txtAllProducer.Size = new Size(235, 103);
            txtAllProducer.TabIndex = 7;
            txtAllProducer.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 390);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 8;
            label3.Text = "所有生产的内容";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 594);
            label4.Name = "label4";
            label4.Size = new Size(147, 24);
            label4.TabIndex = 10;
            label4.Text = "消费者1消费记录";
            // 
            // btnConsumer
            // 
            btnConsumer.Location = new Point(384, 804);
            btnConsumer.Name = "btnConsumer";
            btnConsumer.Size = new Size(112, 34);
            btnConsumer.TabIndex = 11;
            btnConsumer.Text = "开始消费";
            btnConsumer.UseVisualStyleBackColor = true;
            btnConsumer.Click += btnConsumer_Click;
            // 
            // txtConsumer1
            // 
            txtConsumer1.Location = new Point(140, 632);
            txtConsumer1.Name = "txtConsumer1";
            txtConsumer1.Size = new Size(229, 144);
            txtConsumer1.TabIndex = 12;
            txtConsumer1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 594);
            label5.Name = "label5";
            label5.Size = new Size(147, 24);
            label5.TabIndex = 13;
            label5.Text = "消费者2消费记录";
            // 
            // txtConsumer2
            // 
            txtConsumer2.Location = new Point(495, 632);
            txtConsumer2.Name = "txtConsumer2";
            txtConsumer2.Size = new Size(229, 144);
            txtConsumer2.TabIndex = 14;
            txtConsumer2.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(188, 535);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 28);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "消费者1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(548, 535);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 28);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "消费者2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 880);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtConsumer2);
            Controls.Add(label5);
            Controls.Add(txtConsumer1);
            Controls.Add(btnConsumer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAllProducer);
            Controls.Add(btnProducer4);
            Controls.Add(btnProducer3);
            Controls.Add(btnProducer2);
            Controls.Add(btnProducer1);
            Controls.Add(label2);
            Controls.Add(listViewProducer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewProducer;
        private Label label2;
        private Button btnProducer1;
        private Button btnProducer2;
        private Button btnProducer3;
        private Button btnProducer4;
        private RichTextBox txtAllProducer;
        private Label label3;
        private Label label4;
        private Button btnConsumer;
        private RichTextBox txtConsumer1;
        private Label label5;
        private RichTextBox txtConsumer2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}