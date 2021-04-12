using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.Form
{
    public partial class NewUserForm
    {
        public NewUserForm()
        {
            InitializeComponent();
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private void CfPasTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }



        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "请输入密码")
            {
                PasswordTextBox.Text = "";
            }
            if (CheckBox_ShowPassword.Checked)
            {
                PasswordTextBox.PasswordChar = newchar;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordTextBox_Enter(null, null);
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (CheckBox_ShowPassword.Checked)
            {
                PasswordTextBox.PasswordChar = newchar;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "请输入密码";
                PasswordTextBox.PasswordChar = newchar;
            }

        }



        private void CfPasTextBox_Enter(object sender, EventArgs e)
        {
            if (CfPasTextBox.Text == "请再次输入密码")
            {
                CfPasTextBox.Text = "";
            }
            if (CheckBox_ShowPassword.Checked)
            {
                CfPasTextBox.PasswordChar = newchar;
            }
            else
            {
                CfPasTextBox.PasswordChar = '*';
            }
        }

        private void CfPasTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            CfPasTextBox_Enter(null, null);
        }

        private void CfPasTextBox_Leave(object sender, EventArgs e)
        {
            if (CheckBox_ShowPassword.Checked)
            {
                CfPasTextBox.PasswordChar = newchar;
            }
            else
            {
                CfPasTextBox.PasswordChar = '*';
            }
            if (CfPasTextBox.Text == "")
            {
                CfPasTextBox.Text = "请再次输入密码";
                CfPasTextBox.PasswordChar = newchar;
            }
        }

        char newchar = new char();
        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //输入密码框
            if (PasswordTextBox.Text == "请输入密码")
            {
                PasswordTextBox.PasswordChar = newchar;
            }
            else
            {
                if (CheckBox_ShowPassword.Checked)
                {
                    PasswordTextBox.PasswordChar = newchar;
                }
                else
                {
                    PasswordTextBox.PasswordChar = '*';
                }
            }
            //确认输入密码框
            if (CfPasTextBox.Text == "请再次输入密码")
            {
                CfPasTextBox.PasswordChar = newchar;
            }
            else
            {
                if (CheckBox_ShowPassword.Checked)
                {
                    CfPasTextBox.PasswordChar = newchar;
                }
                else
                {
                    CfPasTextBox.PasswordChar = '*';
                }
            }

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserForm_Activated(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "请输入账号")
            {
                UsernameTextBox.Text = "";
            }
        }

        private void UsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UsernameTextBox_Enter(null, null);
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "请输入账号";
            }
        }


        //查询库是否已有账号，若无则注册，否则不成功
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Trim() == "请输入账号" || PasswordTextBox.Text.Trim() == "请输入密码" || CfPasTextBox.Text.Trim() == "请再次输入密码" || PasswordTextBox .Text .Trim () !=CfPasTextBox .Text .Trim ())
            {
                ErrorLabel.Visible = true;
                return;
            }

            string str = LoginForm.SL.Query($"select UserName from Login where UserName='{ UsernameTextBox.Text.Trim()}'");
            if (str == "")
            {
                MessageBox.Show("此账号已注册");
                return;
            }

            str = LoginForm.SL.CommandDatabase($"insert into Login (UserName,Password) Values ({UsernameTextBox.Text.Trim()},{PasswordTextBox.Text.Trim()})");
            if (str=="")
            {
                MessageBox.Show("账号注册成功");
            }
        }
        }
    }

