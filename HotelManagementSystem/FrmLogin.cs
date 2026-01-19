using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            FrmRegistrasi registrasi = new FrmRegistrasi();
            registrasi.Show ();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
