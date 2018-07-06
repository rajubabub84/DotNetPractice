using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyWindowsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp = new Employee() { EmpAddress = new Address() };
        Employee empCopied;
        StringBuilder sb = new StringBuilder();

        private void btnShallow_Click(object sender, EventArgs e)
        {
            empCopied = (Employee)this.emp.ShallowCopy();
            RefreshEmployee();
        }
        private void RefreshEmployee()
        {
            sb.Clear();
            sb.AppendLine("-------------------------");
            sb.AppendLine(string.Format("Main Employee:{0}", this.emp.ToString()));
            sb.AppendLine();
            sb.AppendLine(string.Format("Copied Employee:{0}", this.empCopied.ToString()));
            sb.AppendLine("--------------------------");
            sb.AppendLine(txtOutput.Text);
            txtOutput.Text = sb.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshEmployee();
        }

        private void btnDeep_Click(object sender, EventArgs e)
        {
            empCopied = (Employee)this.emp.DeepCopy();
            RefreshEmployee();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            emp.ID = txtEmpId.Text;
            emp.Name = txtEmpName.Text;
            emp.EmpAddress.Country = txtCountry.Text;
            emp.EmpAddress.DoorNumber =int.Parse(txtDoorNo.Text);
            emp.EmpAddress.StreetNumber =int.Parse(txtStreetNo.Text);
            emp.EmpAddress.ZipCode = int.Parse(txtZipCode.Text);
            MessageBox.Show("Updated");
        }
    }
}
