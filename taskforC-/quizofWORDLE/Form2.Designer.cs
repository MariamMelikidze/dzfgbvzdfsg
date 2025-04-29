namespace quizofWORDLE
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.foremailtocreateaccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.forpasswordtocreateaccount = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttontocreateaccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create your free account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email Address";
            // 
            // foremailtocreateaccount
            // 
            this.foremailtocreateaccount.Location = new System.Drawing.Point(72, 213);
            this.foremailtocreateaccount.Name = "foremailtocreateaccount";
            this.foremailtocreateaccount.Size = new System.Drawing.Size(648, 20);
            this.foremailtocreateaccount.TabIndex = 1;
            this.foremailtocreateaccount.TextChanged += new System.EventHandler(this.foremailtocreateaccount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // forpasswordtocreateaccount
            // 
            this.forpasswordtocreateaccount.Location = new System.Drawing.Point(72, 296);
            this.forpasswordtocreateaccount.Name = "forpasswordtocreateaccount";
            this.forpasswordtocreateaccount.Size = new System.Drawing.Size(649, 20);
            this.forpasswordtocreateaccount.TabIndex = 1;
            this.forpasswordtocreateaccount.TextChanged += new System.EventHandler(this.forpasswordtocreateaccount_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(74, 343);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(643, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "You agree to recive updates and offers from the fimes. you may opt out or contact" +
    " us anytime.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(68, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(653, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "By creating an account, you agree to the updated Terms of Sale, Terms of Servce, " +
    "and Privacy Police.";
            // 
            // buttontocreateaccount
            // 
            this.buttontocreateaccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttontocreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontocreateaccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttontocreateaccount.Location = new System.Drawing.Point(74, 441);
            this.buttontocreateaccount.Name = "buttontocreateaccount";
            this.buttontocreateaccount.Size = new System.Drawing.Size(649, 51);
            this.buttontocreateaccount.TabIndex = 4;
            this.buttontocreateaccount.Text = "Create Account";
            this.buttontocreateaccount.UseVisualStyleBackColor = false;
            this.buttontocreateaccount.Click += new System.EventHandler(this.buttontocreateaccount_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.buttontocreateaccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.forpasswordtocreateaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foremailtocreateaccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox foremailtocreateaccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forpasswordtocreateaccount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttontocreateaccount;
    }
}