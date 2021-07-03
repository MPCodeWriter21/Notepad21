
namespace Notepad21.Forms
{
    partial class ReplaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chboxMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnDown = new System.Windows.Forms.RadioButton();
            this.radioBtnUp = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToReplace = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chboxMatchCase
            // 
            this.chboxMatchCase.AutoSize = true;
            this.chboxMatchCase.Location = new System.Drawing.Point(9, 126);
            this.chboxMatchCase.Name = "chboxMatchCase";
            this.chboxMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chboxMatchCase.TabIndex = 10;
            this.chboxMatchCase.Text = "Match &case";
            this.chboxMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDown);
            this.groupBox1.Controls.Add(this.radioBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(146, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioBtnDown
            // 
            this.radioBtnDown.AutoSize = true;
            this.radioBtnDown.Checked = true;
            this.radioBtnDown.Location = new System.Drawing.Point(53, 20);
            this.radioBtnDown.Name = "radioBtnDown";
            this.radioBtnDown.Size = new System.Drawing.Size(53, 17);
            this.radioBtnDown.TabIndex = 0;
            this.radioBtnDown.TabStop = true;
            this.radioBtnDown.Text = "&Down";
            this.radioBtnDown.UseVisualStyleBackColor = true;
            // 
            // radioBtnUp
            // 
            this.radioBtnUp.AutoSize = true;
            this.radioBtnUp.Location = new System.Drawing.Point(6, 20);
            this.radioBtnUp.Name = "radioBtnUp";
            this.radioBtnUp.Size = new System.Drawing.Size(39, 17);
            this.radioBtnUp.TabIndex = 0;
            this.radioBtnUp.Text = "&Up";
            this.radioBtnUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(263, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(263, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 8;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // txtToFind
            // 
            this.txtToFind.Location = new System.Drawing.Point(84, 12);
            this.txtToFind.Name = "txtToFind";
            this.txtToFind.Size = new System.Drawing.Size(173, 20);
            this.txtToFind.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fi&nd what:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(263, 39);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(263, 68);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 8;
            this.btnReplaceAll.Text = "Replace &All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace with:";
            // 
            // txtToReplace
            // 
            this.txtToReplace.Location = new System.Drawing.Point(84, 38);
            this.txtToReplace.Name = "txtToReplace";
            this.txtToReplace.Size = new System.Drawing.Size(173, 20);
            this.txtToReplace.TabIndex = 6;
            // 
            // ReplaceForm
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(346, 155);
            this.Controls.Add(this.chboxMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtToReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToFind);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 194);
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chboxMatchCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDown;
        private System.Windows.Forms.RadioButton radioBtnUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToReplace;
    }
}