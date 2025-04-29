namespace quizofWORDLE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.for_mail = new System.Windows.Forms.TextBox();
            this.buttontologinin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in or create an account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(101, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // for_mail
            // 
            this.for_mail.Location = new System.Drawing.Point(109, 341);
            this.for_mail.Margin = new System.Windows.Forms.Padding(6);
            this.for_mail.Name = "for_mail";
            this.for_mail.Size = new System.Drawing.Size(700, 30);
            this.for_mail.TabIndex = 2;
            this.for_mail.TextChanged += new System.EventHandler(this.for_mail_TextChanged);
            // 
            // buttontologinin
            // 
            this.buttontologinin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttontologinin.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontologinin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttontologinin.Location = new System.Drawing.Point(109, 430);
            this.buttontologinin.Margin = new System.Windows.Forms.Padding(6);
            this.buttontologinin.Name = "buttontologinin";
            this.buttontologinin.Size = new System.Drawing.Size(700, 160);
            this.buttontologinin.TabIndex = 3;
            this.buttontologinin.Text = "Continue";
            this.buttontologinin.UseVisualStyleBackColor = false;
            this.buttontologinin.Click += new System.EventHandler(this.con_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 665);
            this.Controls.Add(this.buttontologinin);
            this.Controls.Add(this.for_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox for_mail;
        private System.Windows.Forms.Button buttontologinin;
    }
}

