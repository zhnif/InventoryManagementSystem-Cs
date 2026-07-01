namespace InventoryManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.regCPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.regShowPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.regShowPass);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.regCPassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.regBtn);
            this.panel1.Controls.Add(this.regPassword);
            this.panel1.Controls.Add(this.regUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(73, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 270);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(172, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(172, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginLabel.Location = new System.Drawing.Point(287, 243);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(57, 13);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login here";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alredy have an account?";
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.Cyan;
            this.regBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.regBtn.Location = new System.Drawing.Point(129, 190);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(242, 42);
            this.regBtn.TabIndex = 3;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // regPassword
            // 
            this.regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(221, 107);
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '*';
            this.regPassword.Size = new System.Drawing.Size(242, 26);
            this.regPassword.TabIndex = 2;
            // 
            // regUsername
            // 
            this.regUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(221, 67);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(242, 26);
            this.regUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Account";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(607, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // regCPassword
            // 
            this.regCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCPassword.Location = new System.Drawing.Point(221, 147);
            this.regCPassword.Name = "regCPassword";
            this.regCPassword.PasswordChar = '*';
            this.regCPassword.Size = new System.Drawing.Size(242, 26);
            this.regCPassword.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventoryManagementSystem.Properties.Resources.padlock;
            this.pictureBox4.Location = new System.Drawing.Point(172, 147);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // regShowPass
            // 
            this.regShowPass.AutoSize = true;
            this.regShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regShowPass.Location = new System.Drawing.Point(393, 179);
            this.regShowPass.Name = "regShowPass";
            this.regShowPass.Size = new System.Drawing.Size(122, 20);
            this.regShowPass.TabIndex = 11;
            this.regShowPass.Text = "Show Password";
            this.regShowPass.UseVisualStyleBackColor = true;
            this.regShowPass.CheckedChanged += new System.EventHandler(this.regShowPass_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(665, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox regCPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox regShowPass;
    }
}