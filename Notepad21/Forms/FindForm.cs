using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad21
{
    public partial class FindForm : Form
    {
        public bool close = false;
        MainForm form;
        public FindForm()
        {
            InitializeComponent();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            form = (MainForm)Owner;
            string toFind = txtToFind.Text;
            string content = form.txtContent.Text;
            if (!chboxMatchCase.Checked)
            {
                toFind = toFind.ToLower();
                content = content.ToLower();
            }
            if (radioBtnDown.Checked)
            {
                form.txtContent.SelectionStart += form.txtContent.SelectionLength;
                form.txtContent.SelectionLength = 0;
                int index = content.Substring(form.txtContent.SelectionStart + form.txtContent.SelectionLength).IndexOf(toFind);
                if (index == -1)
                {
                    SystemSounds.Beep.Play();
                    return;
                }
                form.txtContent.SelectionStart = form.txtContent.SelectionStart + index;
            }
            else if (radioBtnUp.Checked)
            {
                int index = content.Substring(0, form.txtContent.SelectionStart).LastIndexOf(toFind);
                if (index == -1)
                {
                    SystemSounds.Beep.Play();
                    return;
                }
                form.txtContent.SelectionStart = index;
            }
            form.txtContent.SelectionLength = txtToFind.TextLength;
            form.txtContent.ScrollToCaret();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !close;
            if (e.Cancel)
                Hide();
            else
                Close();
        }
    }
}
