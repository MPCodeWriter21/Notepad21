
namespace Notepad21
{
    partial class FindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToFind = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnUp = new System.Windows.Forms.RadioButton();
            this.radioBtnDown = new System.Windows.Forms.RadioButton();
            this.chboxMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fi&nd what:";
            // 
            // txtToFind
            // 
            this.txtToFind.Location = new System.Drawing.Point(74, 12);
            this.txtToFind.Name = "txtToFind";
            this.txtToFind.Size = new System.Drawing.Size(189, 20);
            this.txtToFind.TabIndex = 1;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(269, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDown);
            this.groupBox1.Controls.Add(this.radioBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(152, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
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
            // chboxMatchCase
            // 
            this.chboxMatchCase.AutoSize = true;
            this.chboxMatchCase.Location = new System.Drawing.Point(13, 73);
            this.chboxMatchCase.Name = "chboxMatchCase";
            this.chboxMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chboxMatchCase.TabIndex = 4;
            this.chboxMatchCase.Text = "Match &case";
            this.chboxMatchCase.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(356, 102);
            this.Controls.Add(this.chboxMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtToFind);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToFind;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDown;
        private System.Windows.Forms.RadioButton radioBtnUp;
        private System.Windows.Forms.CheckBox chboxMatchCase;
    }
}