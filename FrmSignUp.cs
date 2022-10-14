using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SignUp
{
    public partial class FrmSignUp : Form
    {
        string ConStr = (@"Data Source =DESKTOP-DQA0BC1\SQLEXPRESS;Initial Catalog=SignUp;Integrated Security=true");
        SqlConnection con;
        public FrmSignUp()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Tbl_SignUp]
           ([Username]
           ,[Password])
     VALUES
           ('" + TbUsername.Text + "','" + TbPassword.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfullully Inserted!");
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.Show();
        }
    }
}
