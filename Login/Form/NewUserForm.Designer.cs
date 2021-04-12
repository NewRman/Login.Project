
namespace Login.Form
{
    partial class NewUserForm : MetroFramework .Forms .MetroForm 
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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CfPasTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CheckBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("宋体", 20F);
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextBox.Location = new System.Drawing.Point(349, 24);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(220, 38);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Text = "请输入账号";
            this.UsernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsernameTextBox_MouseClick);
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(314, 176);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(294, 19);
            this.ErrorLabel.TabIndex = 31;
            this.ErrorLabel.Text = "两次密码不一致或含有不规范字符";
            this.ErrorLabel.Visible = false;
            // 
            // CfPasTextBox
            // 
            this.CfPasTextBox.Font = new System.Drawing.Font("宋体", 20F);
            this.CfPasTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CfPasTextBox.Location = new System.Drawing.Point(349, 135);
            this.CfPasTextBox.Name = "CfPasTextBox";
            this.CfPasTextBox.Size = new System.Drawing.Size(220, 38);
            this.CfPasTextBox.TabIndex = 2;
            this.CfPasTextBox.Text = "请再次输入密码";
            this.CfPasTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CfPasTextBox_MouseClick);
            this.CfPasTextBox.TextChanged += new System.EventHandler(this.CfPasTextBox_TextChanged);
            this.CfPasTextBox.Enter += new System.EventHandler(this.CfPasTextBox_Enter);
            this.CfPasTextBox.Leave += new System.EventHandler(this.CfPasTextBox_Leave);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("宋体", 20F);
            this.Label1.Location = new System.Drawing.Point(183, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 38);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "确认密码(&P)";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckBox_ShowPassword
            // 
            this.CheckBox_ShowPassword.AutoSize = true;
            this.CheckBox_ShowPassword.Font = new System.Drawing.Font("宋体", 16F);
            this.CheckBox_ShowPassword.Location = new System.Drawing.Point(575, 85);
            this.CheckBox_ShowPassword.Name = "CheckBox_ShowPassword";
            this.CheckBox_ShowPassword.Size = new System.Drawing.Size(117, 26);
            this.CheckBox_ShowPassword.TabIndex = 29;
            this.CheckBox_ShowPassword.Text = "显示密码";
            this.CheckBox_ShowPassword.UseVisualStyleBackColor = true;
            this.CheckBox_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ShowPassword_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("宋体", 20F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(349, 79);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 38);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "请输入密码";
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.PasswordLabel.Location = new System.Drawing.Point(183, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(160, 38);
            this.PasswordLabel.TabIndex = 28;
            this.PasswordLabel.Text = "密码(&P)";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.UsernameLabel.Location = new System.Drawing.Point(183, 24);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(160, 38);
            this.UsernameLabel.TabIndex = 27;
            this.UsernameLabel.Text = "账号(&U)";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
            this.Exitbutton.Font = new System.Drawing.Font("微软雅黑", 20.25F);
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(413, 206);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(200, 65);
            this.Exitbutton.TabIndex = 4;
            this.Exitbutton.Text = "退出(&E)";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
            this.Loginbutton.Font = new System.Drawing.Font("微软雅黑", 20.25F);
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(188, 206);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(200, 65);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "注册(&R)";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CfPasTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CheckBox_ShowPassword);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "NewUserForm";
            this.Text = "注册新用户";
            this.Activated += new System.EventHandler(this.NewUserForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.Label ErrorLabel;
        internal System.Windows.Forms.TextBox CfPasTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox CheckBox_ShowPassword;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Loginbutton;
    }
}