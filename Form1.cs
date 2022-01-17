using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BaumanBooking
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
            login_enter.Text = "Enter your login";
            login_enter.ForeColor = Color.Gray;
            password_enter.Text = "Enter your password";
            password_enter.ForeColor = Color.Gray;
            password_enter.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        Point last_point;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void open_new_Main_Form(String _login)
        {
            Application.Run(new Main_Form(_login));
        }

        private void entry_Click(object sender, EventArgs e)
        {
            String _login = login_enter.Text;
            String _password = password_enter.Text;
            if ((login_enter.Text == "Enter your login") || (password_enter.Text == "Enter your password"))
            {
                MessageBox.Show("Enter all data");
                return;
            }
            Authorization_database db = new Authorization_database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l AND `password` = @p", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = _login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = Encrypt.HashString(_password);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Authorization successful");
                th = new Thread(()=>open_new_Main_Form(_login));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
                login_enter.Text = "Enter your login";
                login_enter.ForeColor = Color.Gray;
                password_enter.Text = "Enter your password";
                password_enter.ForeColor = Color.Gray;
                password_enter.UseSystemPasswordChar = false;
            }
        }

        private void login_enter_Enter(object sender, EventArgs e)
        {
            if (login_enter.Text == "Enter your login")
            {
                login_enter.Text = "";
                login_enter.ForeColor = Color.Black;
            }
        }

        private void login_enter_Leave(object sender, EventArgs e)
        {
            if (login_enter.Text == "")
            {
                login_enter.Text = "Enter your login";
                login_enter.ForeColor = Color.Red;
            }
        }

        private void password_enter_Enter(object sender, EventArgs e)
        {
            if (password_enter.Text == "Enter your password")
            {
                password_enter.Text = "";
                password_enter.ForeColor = Color.Black;
                password_enter.UseSystemPasswordChar = true;
            }
        }

        private void password_enter_Leave(object sender, EventArgs e)
        {
            if (password_enter.Text == "")
            {
                password_enter.UseSystemPasswordChar = false;
                password_enter.Text = "Enter your password";
                password_enter.ForeColor = Color.Red;
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_new_Registration_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void open_new_Registration_Form(object obj)
        {
            Application.Run(new Registration_Form());
        }

        private void register_button_MouseEnter(object sender, EventArgs e)
        {
            register_button.ForeColor = Color.Blue;
        }

        private void register_button_MouseLeave(object sender, EventArgs e)
        {
            register_button.ForeColor = Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                entry_Click(entry, null);
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                button2_Click(close, null);
            }

        }
    }
}
