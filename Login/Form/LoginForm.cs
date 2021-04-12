using Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.Form
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        #region 窗体设置

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public List<string> TableCoulumnName = new List<string>();
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //读取所有用户名
           TableCoulumnName = SL.GetTableColunmnNames("select UserName from [Login] ");
            foreach (var i in TableCoulumnName)
            {
                UserNametextBox.Items.Add(i);
            }
        }
        char newchar = new char();
        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text == "请输入密码")
            {
                Passwordtextbox.PasswordChar = newchar;
            }
            else
            {
                if (CheckBox_ShowPassword.Checked == true)
                {
                    Passwordtextbox.PasswordChar = newchar;
                }
                else
                {
                    Passwordtextbox.PasswordChar = '*';
                }
            }

        }

        private void UserNametextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (UserNametextBox1.Text == "请输入账号")
            {
                UserNametextBox1.Text = "";
            }
        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private void Passwordtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Passwordtextbox.Text == "请输入密码")
            {
                Passwordtextbox.Text = "";
            }
        }

        private void Passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private void Passwordtextbox_Enter(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text == "请输入密码")
            {
                Passwordtextbox.Text = "";
            }
            if (CheckBox_ShowPassword.Checked == true)
            {
                Passwordtextbox.PasswordChar = newchar;
            }
            else
            {
                Passwordtextbox.PasswordChar = '*';
            }
        }
        /// <summary>
        /// 窗体获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        /// <summary>
        /// 账号密码未填写显示请输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Passwordtextbox_Leave(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text == "")
            {
                Passwordtextbox.PasswordChar = newchar;
                Passwordtextbox.Text = "请输入密码";
            }
        }

        private void UserNametextBox_Leave(object sender, EventArgs e)
        {
            if (UserNametextBox1.Text == "")
            {
                UserNametextBox1.Text = "请输入账号";
            }
        }

        //用Combobox代替原先的Textbox
        private void UserNametextBox_Leave_1(object sender, EventArgs e)
        {
            if (UserNametextBox.Text == "")
            {
                UserNametextBox.Text = "请输入账号";
            }
        }

        private void UserNametextBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (UserNametextBox.Text == "请输入账号")
            {
                UserNametextBox.Text = "";
            }
        }

        private void UserNametextBox_TextChanged_1(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        #endregion

        #region 数据库连接

        //打开数据库连接
        public static SQLiteHelper SL = new SQLiteHelper(Application.StartupPath + @"\Data\Login.db3");



        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //无输入
            if (UserNametextBox.Text == "请输入账号" || UserNametextBox.Text == "" || Passwordtextbox.Text == "" || Passwordtextbox.Text == "请输入密码")
            {
                ErrorLabel.Visible = true;
            }
            //查询结果
            else
            {
                string cmdtxt = "select UserName, Password from Login where UserName = '" + UserNametextBox.Text.Trim() + "' and Password = '" + Passwordtextbox.Text.Trim() + "'";
                if (SL.Query(cmdtxt) == "")
                {
                    //密码正确
                    this.Close();
                }
                else
                {
                    //密码错误
                    ErrorLabel.Visible = true;
                }
            }

        }
        #endregion

        #region 动态绘制渐变


        private void TimerUpdate_Tick(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// 从大图中截取一部分图片
        /// </summary>
        /// <param name="fromImagePath">来源图片地址</param>        
        /// <param name="offsetX">从偏移X坐标位置开始截取</param>
        /// <param name="offsetY">从偏移Y坐标位置开始截取</param>
        /// <param name="width">保存图片的宽度</param>
        /// <param name="height">保存图片的高度</param>
        /// <returns></returns>
        public Image CaptureImage(Image fromImagePath, int offsetX, int offsetY, int width, int height)
        {
            //原图片文件
            using (Image fromImage = fromImagePath)
            {
                //创建新图位图
                Bitmap bitmap = new Bitmap(width, height);
                //创建作图区域
                Graphics graphic = Graphics.FromImage(bitmap);
                //截取原图相应区域写入作图区
                graphic.DrawImage(fromImage, 0, 0, new Rectangle(offsetX, offsetY, width, height), GraphicsUnit.Pixel);
                //从作图区生成新图
                Image a = Image.FromHbitmap(bitmap.GetHbitmap());
                bitmap.Dispose();
                graphic.Dispose();
                return a;
            }
        }

        #endregion
       
        private void Regeditbutton_Click(object sender, EventArgs e)
        {
             NewUserForm nf = new NewUserForm();
            nf.ShowDialog ();
        }

    }  
}
