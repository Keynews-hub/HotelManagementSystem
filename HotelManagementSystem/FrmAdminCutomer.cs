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
    public partial class FrmAdminCutomer : Form
    {
        public FrmAdminCutomer()
        {
            InitializeComponent();
        }

        private void FrmAdminCutomer_Load(object sender, EventArgs e)
        {
            displayCustomer();
        }
        

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayCustomer();
        }
        public void displayCustomer()
        { 
            customerData cData = new customerData();
            List<customerData> clist = cData.listCustomerData();
            GridViewAdminCustomer.DataSource = clist;
        }
    }
}
