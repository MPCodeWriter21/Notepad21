using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Notepad21.Forms
{
    public partial class MainForm : Form
    {
        // Path of opend file
        private string path;
        private bool changesSaved = true;
        private bool CanRedo = false;
        private string RedoText;
        FindForm findForm = new FindForm();
        ReplaceForm replaceForm = new ReplaceForm();
        GoToForm gotoForm = new GoToForm();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string path)
        {
            InitializeComponent();
            Open(path);
        }

        private string GetName()
        {
            return Path.GetFileName(path == null ? "Untitled" : path);
        }

        private void Open(string fileName)
        {
            try
            {
                txtContent.Text = File.ReadAllText(fileName);
                path = fileName;
                changesSaved = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save()
        {
            if (path == null)
            {
                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Filter = "Text Document|*.txt|All Files|*.*";
                saveFD.Title = "Save File";
                if (saveFD.ShowDialog() == DialogResult.OK)
                    path = saveFD.FileName;
            }

            if (path != null)
                try
                {
                    File.WriteAllText(path, txtContent.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    path = null;
                    Save();
                }
        }

        private void SaveAs()
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Text Document|*.txt|All Files|*.*";
            saveFD.Title = "Save File";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                path = saveFD.FileName;
                try
                {
                    File.WriteAllText(path, txtContent.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                DialogResult result = MessageBox.Show($"Do you want to save changes to {GetName()}?", "Notepad21", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Save();

                else if (result == DialogResult.Cancel)
                    return;
            }

            path = null;
            txtContent.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Text Document|*.txt|All Files|*.*";
            openFD.Title = "Choose File";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Open(openFD.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
                Save();
            else
                SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (!changesSaved)
            {
                DialogResult result = MessageBox.Show($"Do you want to save changes to {GetName()}?", "Notepad21", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Save();
                else if (result != DialogResult.No)
                    e.Cancel = true;
            }
            findForm.close = !e.Cancel;
            if (!e.Cancel)
                findForm.Dispose();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContent.CanUndo)
            {
                RedoText = txtContent.Text;
                CanRedo = true;
                txtContent.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanRedo)
            {
                txtContent.Text = RedoText;
                RedoText = null;
                CanRedo = false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectedText = "";
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm.Owner = this;
            findForm.Show();
        }

        private void txtContent_TextChanged_1(object sender, EventArgs e)
        {
            changesSaved = false;
        }

        private void repalceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceForm.Owner = this;
            replaceForm.Show();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoForm.Owner = this;
            gotoForm.Show();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goToToolStripMenuItem.Enabled = !(txtContent.WordWrap = wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (findForm.txtToFind.Text == "")
            {
                findForm.Owner = this;
                findForm.Show();
            }
            else
                findForm.btnFindNext_Click(sender, e);
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectedText = DateTime.Now.ToString();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;

            Font printFont = this.txtContent.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            StringReader reader = new StringReader(txtContent.Text);

            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            myBrush.Dispose();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.AllowSomePages = false;

            printDialog.ShowHelp = true;
            printDialog.Document = printDocument;

            DialogResult result = printDialog.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
