namespace LemonChat
{
    partial class ClientLoginForm
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
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.ServerIpTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LocalIPLabel = new System.Windows.Forms.Label();
            this.LocalIpTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OnlineUserListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(107, 49);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(41, 12);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "服务器";
            // 
            // ServerIpTextBox
            // 
            this.ServerIpTextBox.Location = new System.Drawing.Point(173, 45);
            this.ServerIpTextBox.Name = "ServerIpTextBox";
            this.ServerIpTextBox.Size = new System.Drawing.Size(143, 21);
            this.ServerIpTextBox.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(109, 97);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(41, 12);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "用户名";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(173, 93);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(230, 21);
            this.UserNameTextBox.TabIndex = 3;
            // 
            // LocalIPLabel
            // 
            this.LocalIPLabel.AutoSize = true;
            this.LocalIPLabel.Location = new System.Drawing.Point(111, 145);
            this.LocalIPLabel.Name = "LocalIPLabel";
            this.LocalIPLabel.Size = new System.Drawing.Size(41, 12);
            this.LocalIPLabel.TabIndex = 4;
            this.LocalIPLabel.Text = "本地IP";
            // 
            // LocalIpTextBox
            // 
            this.LocalIpTextBox.Location = new System.Drawing.Point(173, 141);
            this.LocalIpTextBox.Name = "LocalIpTextBox";
            this.LocalIpTextBox.Size = new System.Drawing.Size(143, 21);
            this.LocalIpTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(221, 184);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(221, 221);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "注销";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(335, 45);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(68, 21);
            this.ServerPortTextBox.TabIndex = 8;
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(335, 141);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(68, 21);
            this.LocalPortTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(317, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(317, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // OnlineUserListView
            // 
            this.OnlineUserListView.HideSelection = false;
            this.OnlineUserListView.Location = new System.Drawing.Point(113, 260);
            this.OnlineUserListView.Name = "OnlineUserListView";
            this.OnlineUserListView.Size = new System.Drawing.Size(290, 160);
            this.OnlineUserListView.TabIndex = 12;
            this.OnlineUserListView.UseCompatibleStateImageBehavior = false;
            // 
            // ClientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 453);
            this.Controls.Add(this.OnlineUserListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LocalIpTextBox);
            this.Controls.Add(this.LocalIPLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ServerIpTextBox);
            this.Controls.Add(this.ServerIPLabel);
            this.MaximizeBox = false;
            this.Name = "ClientLoginForm";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.TextBox ServerIpTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LocalIPLabel;
        private System.Windows.Forms.TextBox LocalIpTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView OnlineUserListView;
    }
}