
namespace BaumanBooking
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flag = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login_enter = new System.Windows.Forms.TextBox();
            this.password_enter = new System.Windows.Forms.TextBox();
            this.entry = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            this.SuspendLayout();
            // 
            // flag
            // 
            this.flag.Image = ((System.Drawing.Image)(resources.GetObject("flag.Image")));
            this.flag.Location = new System.Drawing.Point(0, 0);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(263, 303);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 0;
            this.flag.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(380, 117);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(500, 65);
            this.name.TabIndex = 1;
            this.name.Text = "Bauman Booking";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info1.Location = new System.Drawing.Point(457, 69);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(347, 24);
            this.info1.TabIndex = 2;
            this.info1.Text = "A service for booking classrooms in ";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info2.Location = new System.Drawing.Point(377, 93);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(513, 24);
            this.info2.TabIndex = 3;
            this.info2.Text = "the Educational and Laboratory Building of BMSTU";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.version.Location = new System.Drawing.Point(797, 697);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(199, 24);
            this.version.TabIndex = 4;
            this.version.Text = "Software version 1.1";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(376, 372);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(84, 29);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(337, 455);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(123, 29);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // login_enter
            // 
            this.login_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_enter.Location = new System.Drawing.Point(505, 372);
            this.login_enter.Multiline = true;
            this.login_enter.Name = "login_enter";
            this.login_enter.Size = new System.Drawing.Size(279, 29);
            this.login_enter.TabIndex = 7;
            this.login_enter.Enter += new System.EventHandler(this.login_enter_Enter);
            this.login_enter.Leave += new System.EventHandler(this.login_enter_Leave);
            // 
            // password_enter
            // 
            this.password_enter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_enter.Location = new System.Drawing.Point(505, 455);
            this.password_enter.Name = "password_enter";
            this.password_enter.Size = new System.Drawing.Size(279, 30);
            this.password_enter.TabIndex = 8;
            this.password_enter.UseSystemPasswordChar = true;
            this.password_enter.Enter += new System.EventHandler(this.password_enter_Enter);
            this.password_enter.Leave += new System.EventHandler(this.password_enter_Leave);
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entry.FlatAppearance.BorderSize = 0;
            this.entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entry.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entry.Location = new System.Drawing.Point(591, 535);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(107, 40);
            this.entry.TabIndex = 9;
            this.entry.Text = "Log in";
            this.entry.UseVisualStyleBackColor = false;
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(185)))), ((int)(((byte)(224)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(973, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 35);
            this.close.TabIndex = 10;
            this.close.Text = "Х";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button2_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_button.Location = new System.Drawing.Point(603, 587);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(78, 24);
            this.register_button.TabIndex = 11;
            this.register_button.Text = "Register";
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            this.register_button.MouseEnter += new System.EventHandler(this.register_button_MouseEnter);
            this.register_button.MouseLeave += new System.EventHandler(this.register_button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(185)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.close);
            this.Controls.Add(this.entry);
            this.Controls.Add(this.password_enter);
            this.Controls.Add(this.login_enter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.version);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.flag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flag;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox login_enter;
        private System.Windows.Forms.TextBox password_enter;
        private System.Windows.Forms.Button entry;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label register_button;
    }
}

