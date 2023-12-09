namespace interprocess_communication
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
            label2 = new Label();
            txtIPAddress = new TextBox();
            btnStartSyncComm = new Button();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            btnStartAsyncComm = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 58);
            label1.TabIndex = 0;
            label1.Text = "进程通信实验";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 97);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 1;
            label2.Text = "IP地址/域名输入：";
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(349, 98);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(199, 30);
            txtIPAddress.TabIndex = 2;
            // 
            // btnStartSyncComm
            // 
            btnStartSyncComm.Location = new Point(140, 232);
            btnStartSyncComm.Name = "btnStartSyncComm";
            btnStartSyncComm.Size = new Size(131, 34);
            btnStartSyncComm.TabIndex = 3;
            btnStartSyncComm.Text = "启动同步通信";
            btnStartSyncComm.UseVisualStyleBackColor = true;
            btnStartSyncComm.Click += btnStartSyncComm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 143);
            label3.Name = "label3";
            label3.Size = new Size(219, 24);
            label3.TabIndex = 4;
            label3.Text = "(默认为www.whu.edu.cn)";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(161, 371);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(371, 378);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnStartAsyncComm
            // 
            btnStartAsyncComm.Location = new Point(418, 232);
            btnStartAsyncComm.Name = "btnStartAsyncComm";
            btnStartAsyncComm.Size = new Size(130, 34);
            btnStartAsyncComm.TabIndex = 7;
            btnStartAsyncComm.Text = "启动异步通信";
            btnStartAsyncComm.UseVisualStyleBackColor = true;
            btnStartAsyncComm.Click += btnStartAsyncComm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 330);
            label4.Name = "label4";
            label4.Size = new Size(154, 24);
            label4.TabIndex = 8;
            label4.Text = "进程通信输出结果";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 794);
            Controls.Add(label4);
            Controls.Add(btnStartAsyncComm);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(btnStartSyncComm);
            Controls.Add(txtIPAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIPAddress;
        private Button btnStartSyncComm;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button btnStartAsyncComm;
        private Label label4;
    }
}