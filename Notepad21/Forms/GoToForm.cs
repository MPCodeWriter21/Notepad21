using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad21.Forms
{
    public partial class GoToForm : Form
    {
        public bool close = false;
        public GoToForm()
        {
            InitializeComponent();
        }

        private void txtLineNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!"0123456789".Contains(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (txtLineNumber.Text == "" || txtLineNumber.Text == "0")
                MessageBox.Show("Please enter a valid line number!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MainForm form = (MainForm)Owner;
            if (int.Parse(txtLineNumber.Text) <= form.txtContent.Lines.Length)
            {
                form.txtContent.Select(form.txtContent.GetFirstCharIndexFromLine(int.Parse(txtLineNumber.Text) - 1), 0);
                form.txtContent.ScrollToCaret();
                form.txtContent.Focus();
                Hide();
            }
            else
            {
                MessageBox.Show($"Please enter a valid line number!\nTotal lines: {form.txtContent.Lines.Length}", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GoToForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !close;
            if (e.Cancel)
                Hide();
            else
                Close();
        }
    }
}
