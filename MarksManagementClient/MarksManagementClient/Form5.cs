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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void SearchID_TextChanged(object sender, EventArgs e)
        {
            string search_ID = SearchID.Text;
            ServiceReference2.MarksManageServiceClient client = new ServiceReference2.MarksManageServiceClient();
           // MarksManagementClient.ServiceReference2.MarksRecords u = new ServiceReference2.MarksRecords();
            ServiceReference2.MarksRecords[] Marks;
            Marks = client.SearchByID(search_ID);
            if (Marks == null)
            {
                listView1.Items.Clear();
            }
            else
            {
                listView1.Items.Clear();
                foreach (var marksRecord in Marks)
                {
                    var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = marksRecord;
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void addmarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int delete_sem = (int)DelSem.Value;
            string CID = Form2.clgid;
            ServiceReference2.MarksManageServiceClient client = new ServiceReference2.MarksManageServiceClient();

            client.DeleteMarksRecordBySem(CID, delete_sem);
            ServiceReference2.MarksRecords[] myMarks;
            myMarks = client.SearchByID(CID);

            listView1.Items.Clear();
            foreach (var marksRecord in myMarks)
            {
                var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = marksRecord;
                listView1.Items.Add(lvi);
            }
          

            MessageBox.Show("Record deleted successfully");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int sem = (int)sem_u.Value;
            int sub = (int)sub_u.Value;
            int mar = (int)mar_u.Value;
            ServiceReference2.MarksManageServiceClient client = new ServiceReference2.MarksManageServiceClient();
            string CID = Form2.clgid;
            string result = client.UpdateMarks(CID, sem, sub, mar);
            ServiceReference2.MarksRecords[] myMarks;

            if (result == null)
            {
                MessageBox.Show("Invalid Updation");
            }
            else
            {
                myMarks = client.SearchByID(CID);

                listView1.Items.Clear();
                foreach (var marksRecord in myMarks)
                {
                    var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = marksRecord;
                    listView1.Items.Add(lvi);
                }

                MessageBox.Show(result);
            }
        }
    }
}
