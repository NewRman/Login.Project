
namespace Login.Form
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Regeditbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.UserNametextBox1 = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CheckBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.AvatarpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.UserNametextBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // Regeditbutton
            // 
            this.Regeditbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Regeditbutton.FlatAppearance.BorderSize = 0;
            this.Regeditbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Regeditbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Regeditbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regeditbutton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Regeditbutton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Regeditbutton.Location = new System.Drawing.Point(0, 301);
            this.Regeditbutton.Name = "Regeditbutton";
            this.Regeditbutton.Size = new System.Drawing.Size(99, 65);
            this.Regeditbutton.TabIndex = 15;
            this.Regeditbutton.Text = "注册账号";
            this.Regeditbutton.UseVisualStyleBackColor = true;
            this.Regeditbutton.Click += new System.EventHandler(this.Regeditbutton_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
            this.Loginbutton.Font = new System.Drawing.Font("微软雅黑", 20.25F);
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(111, 295);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(200, 65);
            this.Loginbutton.TabIndex = 2;
            this.Loginbutton.Text = "登录(&O)";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Font = new System.Drawing.Font("宋体", 20.25F);
            this.Passwordtextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Passwordtextbox.Location = new System.Drawing.Point(211, 222);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(252, 38);
            this.Passwordtextbox.TabIndex = 1;
            this.Passwordtextbox.Text = "请输入密码";
            this.Passwordtextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Passwordtextbox_MouseClick);
            this.Passwordtextbox.TextChanged += new System.EventHandler(this.Passwordtextbox_TextChanged);
            this.Passwordtextbox.Enter += new System.EventHandler(this.Passwordtextbox_Enter);
            this.Passwordtextbox.Leave += new System.EventHandler(this.Passwordtextbox_Leave);
            // 
            // UserNametextBox1
            // 
            this.UserNametextBox1.Font = new System.Drawing.Font("宋体", 20.25F);
            this.UserNametextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNametextBox1.Location = new System.Drawing.Point(210, 486);
            this.UserNametextBox1.Name = "UserNametextBox1";
            this.UserNametextBox1.Size = new System.Drawing.Size(252, 38);
            this.UserNametextBox1.TabIndex = 17;
            this.UserNametextBox1.Text = "请输入账号";
            this.UserNametextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNametextBox1.Visible = false;
            this.UserNametextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserNametextBox_MouseClick);
            this.UserNametextBox1.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            this.UserNametextBox1.Leave += new System.EventHandler(this.UserNametextBox_Leave);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
            this.Exitbutton.Font = new System.Drawing.Font("微软雅黑", 20.25F);
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(336, 295);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(200, 65);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "退出(&E)";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(207, 266);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(256, 19);
            this.ErrorLabel.TabIndex = 13;
            this.ErrorLabel.Text = "账号或密码错误，请重新输入";
            this.ErrorLabel.Visible = false;
            // 
            // CheckBox_ShowPassword
            // 
            this.CheckBox_ShowPassword.AutoSize = true;
            this.CheckBox_ShowPassword.Font = new System.Drawing.Font("宋体", 16F);
            this.CheckBox_ShowPassword.Location = new System.Drawing.Point(473, 228);
            this.CheckBox_ShowPassword.Name = "CheckBox_ShowPassword";
            this.CheckBox_ShowPassword.Size = new System.Drawing.Size(117, 26);
            this.CheckBox_ShowPassword.TabIndex = 12;
            this.CheckBox_ShowPassword.Text = "显示密码";
            this.CheckBox_ShowPassword.UseVisualStyleBackColor = true;
            this.CheckBox_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ShowPassword_CheckedChanged);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.Passwordlabel.Image = global::Login.Properties.Resources.key_64;
            this.Passwordlabel.Location = new System.Drawing.Point(131, 211);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(64, 64);
            this.Passwordlabel.TabIndex = 11;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.UserNamelabel.Image = global::Login.Properties.Resources.user_64;
            this.UserNamelabel.Location = new System.Drawing.Point(131, 148);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(64, 64);
            this.UserNamelabel.TabIndex = 10;
            // 
            // AvatarpictureBox
            // 
            this.AvatarpictureBox.Image = global::Login.Properties.Resources.bubble_64;
            this.AvatarpictureBox.Location = new System.Drawing.Point(264, 46);
            this.AvatarpictureBox.Name = "AvatarpictureBox";
            this.AvatarpictureBox.Size = new System.Drawing.Size(100, 100);
            this.AvatarpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarpictureBox.TabIndex = 9;
            this.AvatarpictureBox.TabStop = false;
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(600, 120);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 8;
            this.pictureBoxLine.TabStop = false;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1500;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Font = new System.Drawing.Font("宋体", 20.25F);
            this.UserNametextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNametextBox.FormattingEnabled = true;
            this.UserNametextBox.Location = new System.Drawing.Point(211, 164);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(252, 35);
            this.UserNametextBox.TabIndex = 0;
            this.UserNametextBox.Text = "请输入账号";
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged_1);
            this.UserNametextBox.Leave += new System.EventHandler(this.UserNametextBox_Leave_1);
            this.UserNametextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserNametextBox_MouseClick_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.CheckBox_ShowPassword);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Regeditbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.UserNametextBox1);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.AvatarpictureBox);
            this.Controls.Add(this.pictureBoxLine);
            this.Name = "LoginForm";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regeditbutton;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.TextBox UserNametextBox1;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.PictureBox AvatarpictureBox;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Button Exitbutton;
        internal System.Windows.Forms.Label ErrorLabel;
        internal System.Windows.Forms.CheckBox CheckBox_ShowPassword;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ComboBox UserNametextBox;
    }
}