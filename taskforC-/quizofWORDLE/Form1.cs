using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizofWORDLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void con_Click(object sender, EventArgs e)
        {
            string email = for_mail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("შეიყვანე Email.", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new wordleEntities()) 
                {
                    var user = db.Users.FirstOrDefault(u => u.Email == email);

                    if (user != null)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("არ არსებობს.", "ავტორიზაცია წარუმატებელია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("შეცდომა ავტორიზაციისას: " + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void for_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
