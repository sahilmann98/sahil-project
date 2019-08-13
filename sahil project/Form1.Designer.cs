namespace sahil_project
{
    partial class hello
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
            this.btngo = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.Color.Coral;
            this.btngo.Location = new System.Drawing.Point(184, 54);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(287, 121);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "click me";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.Btngo_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbloutput.Location = new System.Drawing.Point(278, 209);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(100, 23);
            this.lbloutput.TabIndex = 1;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(278, 263);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 26);
            this.txtinput.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(646, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            // 
            // hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btngo);
            this.Name = "hello";
            this.Text = "hello";
            this.Load += new System.EventHandler(this.Hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.ListBox listBox1;
    }
}

