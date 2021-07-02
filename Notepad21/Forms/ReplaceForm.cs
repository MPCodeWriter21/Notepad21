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

namespace Notepad21.Forms
{
    public partial class ReplaceForm : Form
    {
        public bool close = false;
        MainForm form;
        public ReplaceForm()
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
                    MessageBox.Show($"Can't Find '{toFind}'", "Notepad21", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Can't Find '{toFind}'", "Notepad21", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SystemSounds.Beep.Play();
                    return;
                }
                form.txtContent.SelectionStart = index;
            }
            form.txtContent.SelectionLength = txtToFind.TextLength;
            form.txtContent.ScrollToCaret();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            form = (MainForm)Owner;
            string toFind = txtToFind.Text;
            string selected_content = form.txtContent.SelectedText;
            if (!chboxMatchCase.Checked)
            {
                toFind = toFind.ToLower();
                selected_content = selected_content.ToLower();
            }
            if (selected_content == toFind)
                form.txtContent.SelectedText = txtToReplace.Text;
            else
                btnFindNext_Click(sender, e);
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            form = (MainForm)Owner;
            string toFind = txtToFind.Text;
            string content = form.txtContent.Text;
            if (!chboxMatchCase.Checked)
            {
                toFind = toFind.ToLower();
                content = content.ToLower();
            }
            if(radioBtnDown.Checked)
            {
                form.txtContent.SelectionStart = 0;
                form.txtContent.SelectionLength = 0;
            }
            else
            {
                form.txtContent.SelectionLength = 0;
                form.txtContent.SelectionStart = content.Length - 1;
            }
            while (content.Contains(toFind))
            {
                btnFindNext_Click(sender, e);
                btnReplace_Click(sender, e);
                toFind = txtToFind.Text;
                content = form.txtContent.Text;
                if (!chboxMatchCase.Checked)
                {
                    toFind = toFind.ToLower();
                    content = content.ToLower();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !close;
            if (e.Cancel)
                Hide();
            else
                Close();
        }
    }
}
