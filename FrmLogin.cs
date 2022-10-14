using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class FrmLogin : Form
    {
        string ConStr = (@"Data Source =DESKTOP-DQA0BC1\SQLEXPRESS;Initial Catalog=SignUp;Integrated Security=true");
        SqlConnection con;
        SqlDataReader dr;
        public FrmLogin()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
      [Username]
      ,[Password]
  FROM [dbo].[Tbl_SignUp] Where Username='"+TbUsername.Text+"'AND Password='"+TbPassword.Text+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }
    }
}
