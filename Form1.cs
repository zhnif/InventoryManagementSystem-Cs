using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();  
            regForm.Show();

            this.Hide();
        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = loginShowPass.Checked ? '\0' : '*';
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", loginUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", loginPassword.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm dForm = new MainForm();
                            dForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("incorrect username or password", "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection Failed!: " + ex, "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    connect.Close();
                }
            }
        }
    }
}
