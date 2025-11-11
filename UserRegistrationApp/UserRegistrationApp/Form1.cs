using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegistrationApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.Text = "Регистрация пользователя";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.BackColor = Color.Red;
                MessageBox.Show("Ошибка заполнения: логин не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtLogin.BackColor = SystemColors.Window;
            }


            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtConfirmPassword.BackColor = Color.Red;
                MessageBox.Show("Ошибка заполнения: пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtConfirmPassword.BackColor = SystemColors.Window;
            }


            string username = txtLogin.Text.Trim();
            MessageBox.Show($"{username}, вы успешно зарегистрированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            txtLogin.BackColor = SystemColors.Window;
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.BackColor = SystemColors.Window;
        }
        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        }
}


