using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.MemberRepository;
using DataAccess;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            
            try
            {
               
                
                BaseDAL baseDAL = new BaseDAL();
                if(txtEmail.Text.Length < 6)
                    throw new Exception("Sai tên đăng nhập");
                if(txtPassword.Text.Length < 4)
                    throw new Exception("Sai mật khẩu");
                String email = txtEmail.Text.Trim();
                String password = txtPassword.Text.Trim();
                var account = new { email, password };
                var admin = baseDAL.GetConnectionString;
                MemberRepository memberRepository = new MemberRepository();
                bool checkLogin = memberRepository.Login(email, password);

                if (checkLogin != false)
                {
                    frmMemberList frmMemberList = new frmMemberList();
                    frmMemberList.ShowDialog();
                } else
                {
                    throw new Exception("Sai tk hoặc mk");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
