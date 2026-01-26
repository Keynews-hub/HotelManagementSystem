using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            FrmAdminAddUser addUser = new FrmAdminAddUser();
            addUser.Show();
            this.Hide();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            FrmRooms addRooms = new FrmRooms();
            addRooms.Show();
            this.Hide();
        }
    }
}
