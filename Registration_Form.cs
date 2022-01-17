using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaumanBooking
{
    public partial class Registration_Form : Form
    {
        Thread th1;
        public Registration_Form()
        {
            InitializeComponent();
            name_enter.Text = "Enter your name";
            name_enter.ForeColor = Color.Gray;
            surname_enter.Text = "Enter your surname";
            surname_enter.ForeColor = Color.Gray;
            midname_enter.Text = "Enter your midname";
            midname_enter.ForeColor = Color.Gray;
            login_enter.Text = "Enter your login";
            login_enter.ForeColor = Color.Gray;
            password_enter.UseSystemPasswordChar = false;
            password_enter.Text = "Enter your password";
            password_enter.ForeColor = Color.Gray;
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

        private void name_enter_Enter(object sender, EventArgs e)
        {
            if (name_enter.Text == "Enter your name")
            { 
                name_enter.Text = "";
                name_enter.ForeColor = Color.Black;
            }
        }

        private void name_enter_Leave(object sender, EventArgs e)
        {
            if (name_enter.Text == "")
            {
                name_enter.Text = "Enter your name";
                name_enter.ForeColor = Color.Red;
            }
        }

        private void surname_enter_Enter(object sender, EventArgs e)
        {
            if (surname_enter.Text == "Enter your surname")
            {
                surname_enter.Text = "";
                surname_enter.ForeColor = Color.Black;
            }
        }

        private void surname_enter_Leave(object sender, EventArgs e)
        {
            if (surname_enter.Text == "")
            {
                surname_enter.Text = "Enter your surname";
                surname_enter.ForeColor = Color.Red;
            }
        }

        private void midname_enter_Enter(object sender, EventArgs e)
        {
            if (midname_enter.Text == "Enter your midname")
            {
                midname_enter.Text = "";
                midname_enter.ForeColor = Color.Black;
            }
        }

        private void midname_enter_Leave(object sender, EventArgs e)
        {
            if (midname_enter.Text == "")
            {
                midname_enter.Text = "Enter your midname";
                midname_enter.ForeColor = Color.Red;
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

        private void open_new_Form1()
        {
            Application.Run(new Form1());
        }

        private void register_Click(object sender, EventArgs e)
        {
            if ((login_enter.Text == "Enter your login") || (password_enter.Text == "Enter your password") ||
                (name_enter.Text == "Enter your name") || (surname_enter.Text == "Enter your surname")
                || (midname_enter.Text == "Enter your midname"))
            {
                MessageBox.Show("Enter all data");
                return;
            }
            if (UserExists())
            {
                return;
            }
            Authorization_database db = new Authorization_database();
            MySqlCommand command1 = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`, `midname`) VALUES (@l, @p, @n, @s, @m)", db.GetConnection());
            command1.Parameters.Add("@l", MySqlDbType.VarChar).Value = login_enter.Text;
            command1.Parameters.Add("@p", MySqlDbType.VarChar).Value = Encrypt.HashString(password_enter.Text);
            command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = name_enter.Text;
            command1.Parameters.Add("@s", MySqlDbType.VarChar).Value = surname_enter.Text;
            command1.Parameters.Add("@m", MySqlDbType.VarChar).Value = midname_enter.Text;
            db.OpenConnection();
            if (command1.ExecuteNonQuery() == 1)
            {
                String request = "INSERT INTO `users_info` (`login`, ";
                int counter = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int h = 0; h < 7; h++)
                        {
                            switch (i)
                            {
                                case 0: request += "`O_"; break;
                                case 1: request += "`E_"; break;
                            }
                            switch (j)
                            {
                                case 0: request += "M_"; break;
                                case 1: request += "Tu_"; break;
                                case 2: request += "W_"; break;
                                case 3: request += "Th_"; break;
                                case 4: request += "F_"; break;
                                case 5: request += "S_"; break;
                            }
                            switch (h)
                            {
                                case 0: request += "1`"; break;
                                case 1: request += "2`"; break;
                                case 2: request += "3`"; break;
                                case 3: request += "4`"; break;
                                case 4: request += "5`"; break;
                                case 5: request += "6`"; break;
                                case 6: request += "7`"; break;
                            }
                            counter += 1;
                            if (counter != 84)
                            {
                                request += ", ";
                            }
                        }
                    }
                    
                }
                request += ") VALUES (@l, ";
                for (int i = 0; i < 84; i++)
                {
                    request += "''";
                    if (i != 83)
                    {
                        request += ", ";
                    }
                }
                request += ")";
                MySqlCommand command2 = new MySqlCommand(request, db.GetConnection());
                command2.Parameters.Add("@l", MySqlDbType.VarChar).Value = login_enter.Text;
                command2.ExecuteNonQuery();
                MessageBox.Show("Registration successful");
                th1 = new Thread(() => open_new_Form1());
                th1.SetApartmentState(ApartmentState.STA);
                th1.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration error");
            }
            db.CloseConnection();
        }

        public Boolean UserExists()
        {
            Authorization_database db = new Authorization_database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login_enter.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User with this login already exists");
                return true;
            }
            table.Clear();
            command = new MySqlCommand("SELECT * FROM `users` WHERE `name` = @n AND `surname` = @s AND `midname` = @m", db.GetConnection());
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name_enter.Text;
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = surname_enter.Text;
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = midname_enter.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This user already exists");
                adapter.Fill(table);
                return true;
            }
            else
            {
                adapter.Fill(table);
                return false;
            }
        }

        private void Registration_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                register_Click(register, null);
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                button2_Click(close, null);
            }
        }
    }
}
