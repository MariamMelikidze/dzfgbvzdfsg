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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void foremailtocreateaccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void forpasswordtocreateaccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttontocreateaccount_Click(object sender, EventArgs e)
        {
            string email = foremailtocreateaccount.Text.Trim();
            string password = forpasswordtocreateaccount.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("გთხოვ შეავსე ორივე ველი.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new wordleEntities()) 
                {
                    Users newUser = new Users
                    {
                        Username = "DefaultUsername", 
                        Email = email,
                        Password = password
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();
                }

                MessageBox.Show("ანგარიში წარმატებით შეიქმნა!", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foremailtocreateaccount.Text = "";
                forpasswordtocreateaccount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("შეცდომა მოხდა ანგარიშის შექმნისას: " + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
