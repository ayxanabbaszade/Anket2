namespace WinFormsApp27
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtxt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptxt = new System.Windows.Forms.MaskedTextBox();
            this.etxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ftxt = new System.Windows.Forms.TextBox();
            this.sbtn = new System.Windows.Forms.Button();
            this.lbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ptxt);
            this.groupBox1.Controls.Add(this.etxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ntxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // dtxt
            // 
            this.dtxt.Location = new System.Drawing.Point(100, 167);
            this.dtxt.Name = "dtxt";
            this.dtxt.Size = new System.Drawing.Size(179, 27);
            this.dtxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number:";
            // 
            // ptxt
            // 
            this.ptxt.Location = new System.Drawing.Point(122, 131);
            this.ptxt.Mask = "(999) 000-0000";
            this.ptxt.Name = "ptxt";
            this.ptxt.Size = new System.Drawing.Size(157, 27);
            this.ptxt.TabIndex = 6;
            // 
            // etxt
            // 
            this.etxt.Location = new System.Drawing.Point(54, 98);
            this.etxt.Name = "etxt";
            this.etxt.Size = new System.Drawing.Size(225, 27);
            this.etxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // stxt
            // 
            this.stxt.Location = new System.Drawing.Point(74, 65);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(205, 27);
            this.stxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // ntxt
            // 
            this.ntxt.Location = new System.Drawing.Point(54, 32);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(225, 27);
            this.ntxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(317, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 229);
            this.listBox1.TabIndex = 1;
            // 
            // ftxt
            // 
            this.ftxt.Location = new System.Drawing.Point(317, 250);
            this.ftxt.Name = "ftxt";
            this.ftxt.Size = new System.Drawing.Size(214, 23);
            this.ftxt.TabIndex = 2;
            // 
            // sbtn
            // 
            this.sbtn.Location = new System.Drawing.Point(317, 289);
            this.sbtn.Name = "sbtn";
            this.sbtn.Size = new System.Drawing.Size(75, 23);
            this.sbtn.TabIndex = 3;
            this.sbtn.Text = "Save";
            this.sbtn.UseVisualStyleBackColor = true;
            this.sbtn.Click += new System.EventHandler(this.sbtn_Click);
            // 
            // lbtn
            // 
            this.lbtn.Location = new System.Drawing.Point(456, 289);
            this.lbtn.Name = "lbtn";
            this.lbtn.Size = new System.Drawing.Size(75, 23);
            this.lbtn.TabIndex = 4;
            this.lbtn.Text = "Load";
            this.lbtn.UseVisualStyleBackColor = true;
            this.lbtn.Click += new System.EventHandler(this.lbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 343);
            this.Controls.Add(this.lbtn);
            this.Controls.Add(this.sbtn);
            this.Controls.Add(this.ftxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtxt;
        private Label label5;
        private Label label4;
        private MaskedTextBox ptxt;
        private TextBox etxt;
        private Label label3;
        private TextBox stxt;
        private Label label2;
        private TextBox ntxt;
        private Label label1;
        private ListBox listBox1;
        private TextBox ftxt;
        private Button sbtn;
        private Button lbtn;
    }
}