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

namespace BaumanBooking
{
    public partial class Main_Form : Form
    {
        String _login;
        String _name;
        String _surname;
        String _midname;
        Boolean flag = false;
        public Main_Form()
        {
            InitializeComponent();
        }

        public Main_Form(String login)
        {
            _login = login;
            Take_user_info(_login);
            InitializeComponent();
            user_kabinets_Fill();
            group_kabinets_combobox_Fill();
        }

        void Take_user_info(String login)
        {
            var info = new List<string>();
            Authorization_database db = new Authorization_database();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            MySqlDataReader reader;
            db.OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 3; i < 6; i++)
                {
                    string tmp = reader.GetString(i);
                    info.Add(tmp);

                }
            }
            db.CloseConnection();
            _name = info[0];
            _surname = info[1];
            _midname = info[2];
        }

        private void close_Click(object sender, EventArgs e)
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

        private void Main_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void Main_Form_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        void kabinets_combobox_Fill(String str_date)
        {
            var booked_kabinets = new List<string>();
            var all_kabinets = new List<string>();
            String request = "SELECT `" + str_date + "` FROM `users_info` WHERE `" + str_date + "` != '' ORDER BY `login`";
            Authorization_database db = new Authorization_database();
            MySqlCommand command1 = new MySqlCommand(request, db.GetConnection());
            MySqlDataReader reader1;
            db.OpenConnection();
            reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                string kabinet = reader1.GetString(str_date);
                booked_kabinets.Add(kabinet);
            }
            db.CloseConnection();
            request = "SELECT `kabinet` FROM `kabinets_info`";
            MySqlCommand command2 = new MySqlCommand(request, db.GetConnection());
            MySqlDataReader reader2;
            db.OpenConnection();
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string kabinet = reader2.GetString("kabinet");
                all_kabinets.Add(kabinet);
            }
            db.CloseConnection();
            for (int i = 0; i < booked_kabinets.Count(); i++)
            {
                all_kabinets.Remove(booked_kabinets[i]);
            }
            for (int i = 0; i < all_kabinets.Count(); i++)
            {
                kabinets_combobox.Items.Add(all_kabinets[i]);
            }
        }

        void groups_combobox_Fill(String str_date)
        {
            String request = "SELECT `group` FROM `groups_info` WHERE `" + str_date + "` = '' ORDER BY `group`";
            Authorization_database db = new Authorization_database();
            MySqlCommand command = new MySqlCommand(request, db.GetConnection());
            MySqlDataReader reader;
            db.OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string kabinet = reader.GetString("group");
                groups_combobox.Items.Add(kabinet);
            }
            db.CloseConnection();
        }

        private void continue_but_Click(object sender, EventArgs e)
        {
            if (kabinets_combobox.Items.Count != 0)
            {
                kabinets_combobox.Items.Clear();
            }
            if (groups_combobox.Items.Count != 0)
            {
                groups_combobox.Items.Clear();
            }
            String str_date = "";
            switch (week_combobox.SelectedIndex)
            {
                case 0: str_date += "O_"; break;
                case 1: str_date += "E_"; break;
            }
            switch (day_combobox.SelectedIndex)
            {
                case 0: str_date += "M"; break;
                case 1: str_date += "Tu"; break;
                case 2: str_date += "W"; break;
                case 3: str_date += "Th"; break;
                case 4: str_date += "F"; break;
                case 5: str_date += "S"; break;
            }
            switch (time_combobox.SelectedIndex)
            {
                case 0: str_date += "_1"; break;
                case 1: str_date += "_2"; break;
                case 2: str_date += "_3"; break;
                case 3: str_date += "_4"; break;
                case 4: str_date += "_5"; break;
                case 5: str_date += "_6"; break;
                case 6: str_date += "_7"; break;
            }
            if (str_date.Length >= 5)
            {
                if (flag == false)
                {
                    // 
                    // kabinets_combobox
                    // 
                    this.kabinets_combobox.FormattingEnabled = true;
                    this.kabinets_combobox.Location = new System.Drawing.Point(311, 527);
                    this.kabinets_combobox.Name = "kabinets_combobox";
                    this.kabinets_combobox.Size = new System.Drawing.Size(121, 21);
                    this.kabinets_combobox.TabIndex = 14;
                    // 
                    // groups_combobox
                    // 
                    this.groups_combobox.FormattingEnabled = true;
                    this.groups_combobox.Location = new System.Drawing.Point(311, 576);
                    this.groups_combobox.Name = "groups_combobox";
                    this.groups_combobox.Size = new System.Drawing.Size(121, 21);
                    this.groups_combobox.TabIndex = 25;
                    // 
                    // choose_kabinet_label
                    // 
                    this.choose_kabinet_label.AutoSize = true;
                    this.choose_kabinet_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.choose_kabinet_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.choose_kabinet_label.Location = new System.Drawing.Point(18, 527);
                    this.choose_kabinet_label.Name = "choose_kabinet_label";
                    this.choose_kabinet_label.Size = new System.Drawing.Size(240, 24);
                    this.choose_kabinet_label.TabIndex = 24;
                    this.choose_kabinet_label.Text = "Choose a vacant kabinet:";
                    // 
                    // choose_group_label
                    // 
                    this.choose_group_label.AutoSize = true;
                    this.choose_group_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.choose_group_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.choose_group_label.Location = new System.Drawing.Point(18, 576);
                    this.choose_group_label.Name = "choose_group_label";
                    this.choose_group_label.Size = new System.Drawing.Size(240, 24);
                    this.choose_group_label.TabIndex = 24;
                    this.choose_group_label.Text = "Choose a vacant group:";
                    // 
                    // note
                    // 
                    this.note.AutoSize = true;
                    this.note.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.note.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.note.Location = new System.Drawing.Point(19, 638);
                    this.note.Name = "note";
                    this.note.Size = new System.Drawing.Size(269, 90);
                    this.note.TabIndex = 25;
                    this.note.Text = "*Note:\nIf there is no group on the list \nfor which you wanted to book a kabinet,\n" +
            "it means that this group\nhas a lesson at this time.";
                    // 
                    // booking_but
                    // 
                    this.booking_but.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.booking_but.FlatAppearance.BorderSize = 0;
                    this.booking_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    this.booking_but.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.booking_but.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.booking_but.Location = new System.Drawing.Point(500, 626);
                    this.booking_but.Name = "booking_but";
                    this.booking_but.Size = new System.Drawing.Size(134, 43);
                    this.booking_but.TabIndex = 25;
                    this.booking_but.Text = "book";
                    this.booking_but.UseVisualStyleBackColor = false;
                    this.booking_but.Click += new System.EventHandler(this.booking_but_Click);
                    // 
                    // agree_label
                    // 
                    this.agree_label.AutoSize = true;
                    this.agree_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.agree_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.agree_label.Location = new System.Drawing.Point(497, 527);
                    this.agree_label.Name = "agree_label";
                    this.agree_label.Size = new System.Drawing.Size(168, 72);
                    this.agree_label.TabIndex = 26;
                    this.agree_label.Text = "*Note:\nCheck the correctness\nof the selected data\nbefore booking a kabinet";

                    flag = true;
                }
                kabinets_combobox_Fill(str_date);
                groups_combobox_Fill(str_date);
            }
            else
            {
                MessageBox.Show("Choose all data");
            }
        }

        private void booking_but_Click(object sender, EventArgs e)
        {
            if ((kabinets_combobox.SelectedIndex > -1) && (groups_combobox.SelectedIndex > -1))
            {
                String str_date = "";
                switch (week_combobox.SelectedIndex)
                {
                    case 0: str_date += "O_"; break;
                    case 1: str_date += "E_"; break;
                }
                switch (day_combobox.SelectedIndex)
                {
                    case 0: str_date += "M"; break;
                    case 1: str_date += "Tu"; break;
                    case 2: str_date += "W"; break;
                    case 3: str_date += "Th"; break;
                    case 4: str_date += "F"; break;
                    case 5: str_date += "S"; break;
                }
                switch (time_combobox.SelectedIndex)
                {
                    case 0: str_date += "_1"; break;
                    case 1: str_date += "_2"; break;
                    case 2: str_date += "_3"; break;
                    case 3: str_date += "_4"; break;
                    case 4: str_date += "_5"; break;
                    case 5: str_date += "_6"; break;
                    case 6: str_date += "_7"; break;
                }
                String choosen_kabinet = kabinets_combobox.SelectedItem.ToString();
                String choosen_group = groups_combobox.SelectedItem.ToString();
                String request1 = "UPDATE `users_info` SET `" + str_date + "` = '" + choosen_kabinet + "' WHERE `login` = '" + _login + "'";
                Authorization_database db = new Authorization_database();
                MySqlCommand command1 = new MySqlCommand(request1, db.GetConnection());
                db.OpenConnection();
                command1.ExecuteNonQuery();
                db.CloseConnection();
                String request2 = "UPDATE `groups_info` SET `" + str_date + "` = '" + choosen_kabinet + "' WHERE `group` = '" + choosen_group + "'";
                MySqlCommand command2 = new MySqlCommand(request2, db.GetConnection());
                db.OpenConnection();
                command2.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Booking successful");
                kabinets_combobox.SelectedIndex = -1;
                groups_combobox.SelectedIndex = -1;
                week_combobox.SelectedIndex = -1;
                day_combobox.SelectedIndex = -1;
                time_combobox.SelectedIndex = -1;
                kabinets_combobox.Items.Clear();
                groups_combobox.Items.Clear();
                user_kabinets_Fill();
                group_kabinets_Fill();
            }
            else
            {
                MessageBox.Show("Choose all data");
            }
        }

        void user_kabinets_Fill()
        {
            user_kabinets_box1.Items.Clear();
            user_kabinets_box2.Items.Clear();
            var user_kabinets = new List<string>();
            Authorization_database db = new Authorization_database();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_info` WHERE `login` = @l", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = _login;
            MySqlDataReader reader;
            db.OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 1; i < 85; i++)
                {
                    string tmp = reader.GetString(i);
                    user_kabinets.Add(tmp);

                }
            }
            db.CloseConnection();
            var time = new List<string>();
            time.Add("08:30 - 10:05");
            time.Add("10:15 - 11:50");
            time.Add("12:00 - 13:35");
            time.Add("13:50 - 15:25");
            time.Add("15:40 - 17:15");
            time.Add("17:25 - 19:00");
            time.Add("19:10 - 20:45");
            String columns = "{0, -15}{1, -8}{2, -9}{3, -11}{4, -10}{5, -8}{6, -10}";
            user_kabinets_box1.Items.Add(String.Format(columns, "", "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday"));
            user_kabinets_box2.Items.Add(String.Format(columns, "", "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday"));
            for (int i = 0; i < 7; i++)
            {
                user_kabinets_box1.Items.Add(String.Format(columns, time[i], user_kabinets[i], user_kabinets[7 + i], user_kabinets[14 + i],
                    user_kabinets[21 + i], user_kabinets[28 + i], user_kabinets[35 + i]));
                user_kabinets_box2.Items.Add(String.Format(columns, time[i], user_kabinets[42 + i], user_kabinets[49 + i], user_kabinets[56 + i],
                    user_kabinets[63 + i], user_kabinets[70 + i], user_kabinets[77 + i]));
            }
        }

        void group_kabinets_combobox_Fill()
        {
            String request = "SELECT `group` FROM `groups_info`";
            Authorization_database db = new Authorization_database();
            MySqlCommand command = new MySqlCommand(request, db.GetConnection());
            MySqlDataReader reader;
            db.OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string group = reader.GetString("group");
                group_kabinets_combobox.Items.Add(group);
            }
            db.CloseConnection();
        }

        private void find_but_Click(object sender, EventArgs e)
        {
            if (group_kabinets_combobox.SelectedIndex > -1)
            {
                group_kabinets_Fill();
            }
            else
            {
                MessageBox.Show("Choose a group");
            }
        }

        void group_kabinets_Fill()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            var group_kabinets = new List<string>();
            Authorization_database db = new Authorization_database();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groups_info` WHERE `group` = @g", db.GetConnection());
            command.Parameters.Add("@g", MySqlDbType.VarChar).Value = group_kabinets_combobox.SelectedItem;
            MySqlDataReader reader;
            db.OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 1; i < 85; i++)
                {
                    string tmp = reader.GetString(i);
                    group_kabinets.Add(tmp);

                }
            }
            db.CloseConnection();
            var time = new List<string>();
            time.Add("08:30 - 10:05");
            time.Add("10:15 - 11:50");
            time.Add("12:00 - 13:35");
            time.Add("13:50 - 15:25");
            time.Add("15:40 - 17:15");
            time.Add("17:25 - 19:00");
            time.Add("19:10 - 20:45");
            String columns = "{0, -15}{1, -8}{2, -9}{3, -11}{4, -10}{5, -8}{6, -10}";
            listBox1.Items.Add(String.Format(columns, "", "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday"));
            listBox2.Items.Add(String.Format(columns, "", "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday"));
            for (int i = 0; i < 7; i++)
            {
                listBox1.Items.Add(String.Format(columns, time[i], group_kabinets[i], group_kabinets[7 + i], group_kabinets[14 + i],
                    group_kabinets[21 + i], group_kabinets[28 + i], group_kabinets[35 + i]));
                listBox2.Items.Add(String.Format(columns, time[i], group_kabinets[42 + i], group_kabinets[49 + i], group_kabinets[56 + i],
                    group_kabinets[63 + i], group_kabinets[70 + i], group_kabinets[77 + i]));
            }
        }
    }
}
