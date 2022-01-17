
namespace BaumanBooking
{
    partial class Registration_Form
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
            this.version = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login_enter = new System.Windows.Forms.TextBox();
            this.password_enter = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.midname = new System.Windows.Forms.Label();
            this.name_enter = new System.Windows.Forms.TextBox();
            this.surname_enter = new System.Windows.Forms.TextBox();
            this.midname_enter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.version.Location = new System.Drawing.Point(375, 550);
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
            this.login.Location = new System.Drawing.Point(54, 303);
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
            this.password.Location = new System.Drawing.Point(54, 359);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(123, 29);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // login_enter
            // 
            this.login_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_enter.Location = new System.Drawing.Point(209, 304);
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
            this.password_enter.Location = new System.Drawing.Point(209, 358);
            this.password_enter.Name = "password_enter";
            this.password_enter.Size = new System.Drawing.Size(279, 30);
            this.password_enter.TabIndex = 8;
            this.password_enter.Enter += new System.EventHandler(this.password_enter_Enter);
            this.password_enter.Leave += new System.EventHandler(this.password_enter_Leave);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register.Location = new System.Drawing.Point(182, 445);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(208, 40);
            this.register.TabIndex = 9;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(185)))), ((int)(((byte)(224)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(550, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 35);
            this.close.TabIndex = 10;
            this.close.Text = "Х";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button2_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registration.Location = new System.Drawing.Point(160, 39);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(214, 38);
            this.Registration.TabIndex = 12;
            this.Registration.Text = "Registration";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surname.Location = new System.Drawing.Point(54, 201);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(119, 29);
            this.surname.TabIndex = 13;
            this.surname.Text = "Surname";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(54, 148);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(81, 29);
            this.name.TabIndex = 14;
            this.name.Text = "Name";
            // 
            // midname
            // 
            this.midname.AutoSize = true;
            this.midname.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midname.Location = new System.Drawing.Point(54, 253);
            this.midname.Name = "midname";
            this.midname.Size = new System.Drawing.Size(125, 29);
            this.midname.TabIndex = 15;
            this.midname.Text = "Midname";
            // 
            // name_enter
            // 
            this.name_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_enter.Location = new System.Drawing.Point(209, 149);
            this.name_enter.Multiline = true;
            this.name_enter.Name = "name_enter";
            this.name_enter.Size = new System.Drawing.Size(279, 29);
            this.name_enter.TabIndex = 16;
            this.name_enter.Enter += new System.EventHandler(this.name_enter_Enter);
            this.name_enter.Leave += new System.EventHandler(this.name_enter_Leave);
            // 
            // surname_enter
            // 
            this.surname_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_enter.Location = new System.Drawing.Point(209, 202);
            this.surname_enter.Multiline = true;
            this.surname_enter.Name = "surname_enter";
            this.surname_enter.Size = new System.Drawing.Size(279, 29);
            this.surname_enter.TabIndex = 17;
            this.surname_enter.Enter += new System.EventHandler(this.surname_enter_Enter);
            this.surname_enter.Leave += new System.EventHandler(this.surname_enter_Leave);
            // 
            // midname_enter
            // 
            this.midname_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midname_enter.Location = new System.Drawing.Point(209, 253);
            this.midname_enter.Multiline = true;
            this.midname_enter.Name = "midname_enter";
            this.midname_enter.Size = new System.Drawing.Size(279, 29);
            this.midname_enter.TabIndex = 18;
            this.midname_enter.Enter += new System.EventHandler(this.midname_enter_Enter);
            this.midname_enter.Leave += new System.EventHandler(this.midname_enter_Leave);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(185)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(586, 583);
            this.Controls.Add(this.midname_enter);
            this.Controls.Add(this.surname_enter);
            this.Controls.Add(this.name_enter);
            this.Controls.Add(this.midname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.close);
            this.Controls.Add(this.register);
            this.Controls.Add(this.password_enter);
            this.Controls.Add(this.login_enter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registration_Form_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox login_enter;
        private System.Windows.Forms.TextBox password_enter;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label midname;
        private System.Windows.Forms.TextBox name_enter;
        private System.Windows.Forms.TextBox surname_enter;
        private System.Windows.Forms.TextBox midname_enter;
    }
}

