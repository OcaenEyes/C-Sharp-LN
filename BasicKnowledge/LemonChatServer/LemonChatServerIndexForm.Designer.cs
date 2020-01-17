namespace LemonChatServer
{
    partial class LemonChatServerIndexForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IpLabel = new System.Windows.Forms.Label();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.StopServerButton = new System.Windows.Forms.Button();
            this.ListboxStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(16, 365);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(41, 12);
            this.IpLabel.TabIndex = 0;
            this.IpLabel.Text = "服务器";
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(64, 361);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(138, 21);
            this.IpTextBox.TabIndex = 1;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(221, 365);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(41, 12);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "端口号";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(269, 361);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(82, 21);
            this.PortTextBox.TabIndex = 3;
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(488, 360);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(75, 23);
            this.StartServerButton.TabIndex = 4;
            this.StartServerButton.Text = "启动";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // StopServerButton
            // 
            this.StopServerButton.Location = new System.Drawing.Point(593, 360);
            this.StopServerButton.Name = "StopServerButton";
            this.StopServerButton.Size = new System.Drawing.Size(75, 23);
            this.StopServerButton.TabIndex = 5;
            this.StopServerButton.Text = "关闭";
            this.StopServerButton.UseVisualStyleBackColor = true;
            this.StopServerButton.Click += new System.EventHandler(this.StopServerButton_Click);
            // 
            // ListboxStatus
            // 
            this.ListboxStatus.FormattingEnabled = true;
            this.ListboxStatus.ItemHeight = 12;
            this.ListboxStatus.Location = new System.Drawing.Point(18, 19);
            this.ListboxStatus.Name = "ListboxStatus";
            this.ListboxStatus.Size = new System.Drawing.Size(650, 316);
            this.ListboxStatus.TabIndex = 6;
            // 
            // LemonChatServerIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 401);
            this.Controls.Add(this.ListboxStatus);
            this.Controls.Add(this.StopServerButton);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.IpLabel);
            this.Name = "LemonChatServerIndexForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.LemonChatServerIndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Button StopServerButton;
        private System.Windows.Forms.ListBox ListboxStatus;
    }
}

