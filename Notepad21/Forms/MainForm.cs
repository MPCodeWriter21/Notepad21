using System;
using System.Windows.Forms;
using System.IO;

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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changesSaved)
            {
                path = null;
                txtContent.Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show($"Do you want to save changes to {GetName()}?", "Notepad21", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Save();
                    path = null;
                    txtContent.Clear();
                }
                else if (result == DialogResult.No)
                {
                    path = null;
                    txtContent.Clear();
                }
            }
        }

        private string GetName()
        {
            if (path == null)
                return "Untitled";
            return Path.GetFileName(path);
        }

        private void Save()
        {
            if (path == null)
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
                        path = null;
                        Save();
                    }
                }
            }
            else
            {
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

        private void Open(string fileName)
        {
            try
            {
                txtContent.Text = File.ReadAllText(fileName);
                path = fileName;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                Save();
            }
            else
            {
                SaveAs();
            }
        }

        private void SaveAs()
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Text Document|*.txt|All Files|*.*";
            saveFD.Title = "Save File";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFD.FileName, txtContent.Text);
                    if (path == null)
                        path = saveFD.FileName;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                {
                    Save();
                }
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
    }
}
