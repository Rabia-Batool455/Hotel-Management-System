namespace WindowsFormsApp2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1_login = new System.Windows.Forms.Button();
            this.label1_Username = new System.Windows.Forms.Label();
            this.label1_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "abc";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "password";
            // 
            // button1_login
            // 
            this.button1_login.BackColor = System.Drawing.Color.Aqua;
            this.button1_login.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1_login.Location = new System.Drawing.Point(80, 270);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(113, 34);
            this.button1_login.TabIndex = 2;
            this.button1_login.Text = "login";
            this.button1_login.UseVisualStyleBackColor = false;
            this.button1_login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1_Username
            // 
            this.label1_Username.AutoSize = true;
            this.label1_Username.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Username.ForeColor = System.Drawing.Color.Aqua;
            this.label1_Username.Location = new System.Drawing.Point(75, 51);
            this.label1_Username.Name = "label1_Username";
            this.label1_Username.Size = new System.Drawing.Size(121, 26);
            this.label1_Username.TabIndex = 3;
            this.label1_Username.Text = "Username:";
            // 
            // label1_Password
            // 
            this.label1_Password.AutoSize = true;
            this.label1_Password.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Password.ForeColor = System.Drawing.Color.Aqua;
            this.label1_Password.Location = new System.Drawing.Point(75, 155);
            this.label1_Password.Name = "label1_Password";
            this.label1_Password.Size = new System.Drawing.Size(129, 26);
            this.label1_Password.TabIndex = 4;
            this.label1_Password.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(212, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = " Hotel Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1_Username);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1_login);
            this.panel1.Controls.Add(this.label1_Password);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(320, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 337);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Label label1_Username;
        private System.Windows.Forms.Label label1_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}