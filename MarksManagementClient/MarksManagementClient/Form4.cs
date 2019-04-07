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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.MarksManageServiceClient client = new ServiceReference2.MarksManageServiceClient();
            MarksManagementClient.ServiceReference2.MarksRecords u = new ServiceReference2.MarksRecords();
            //ServiceReference2.MarksRecords marks = new ServiceReference2.MarksRecords();
            u.UserID = Form2.clgid;
            u.Semester = (int)numericUpDown1.Value;
            u.Subject1 = (int)numericUpDown2.Value;
            u.Subject2 = (int)numericUpDown3.Value;
            u.Subject3 = (int)numericUpDown4.Value;

            string result = client.AddMarks(u);
            
            if (result == null)
            {
                MessageBox.Show("Invalid Updation");
            }
            else
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
        }
    }
}
