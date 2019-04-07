using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksManagementClient
{
    public partial class Form2 : Form
    {
        public static string clgid;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.MarksManageServiceClient client = new ServiceReference2.MarksManageServiceClient();
            string CollageId = textBox1.Text;
            string Password = textBox2.Text;
            clgid = CollageId;
            string Username = client.Login(CollageId, Password);
            if (Username!=null)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }
    }
}
