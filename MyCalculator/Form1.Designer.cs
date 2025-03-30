namespace MyCalculator
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.NumericUpDown();
            this.txtnum2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnzarb = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(45, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Number1:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(45, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(82, 18);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Number2:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(133, 36);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(227, 26);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(133, 68);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(227, 26);
            this.txtnum2.TabIndex = 1;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(136, 100);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(49, 31);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(191, 100);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(49, 31);
            this.btnminus.TabIndex = 2;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnzarb
            // 
            this.btnzarb.Location = new System.Drawing.Point(246, 100);
            this.btnzarb.Name = "btnzarb";
            this.btnzarb.Size = new System.Drawing.Size(49, 31);
            this.btnzarb.TabIndex = 2;
            this.btnzarb.Text = "*";
            this.btnzarb.UseVisualStyleBackColor = true;
            this.btnzarb.Click += new System.EventHandler(this.btnzarb_Click);
            // 
            // btndivid
            // 
            this.btndivid.Location = new System.Drawing.Point(301, 100);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(49, 31);
            this.btndivid.TabIndex = 2;
            this.btndivid.Text = "/";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.btndivid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 160);
            this.Controls.Add(this.btndivid);
            this.Controls.Add(this.btnzarb);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calaulate   ➗   ✖️   ➖   ➕";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown txtnum1;
        private System.Windows.Forms.NumericUpDown txtnum2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnzarb;
        private System.Windows.Forms.Button btndivid;
    }
}

