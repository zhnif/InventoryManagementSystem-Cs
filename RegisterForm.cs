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
    public partial class RegisterForm : Form
    {
        SqlConnection 
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (regPassword.Text == "" || regCPassword.Text == "" || regUsername.Text == "")
            {
                MessageBox.Show("Please fill all empty fields.", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", regUsername.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(regUsername.Text.Trim() +
                                    "is an alredy taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (regPassword.Text.Length < 8)
                            {
                                MessageBox.Show("Password must be 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (regPassword.Text.Trim() != regCPassword.Text.Trim())
                            {
                                MessageBox.Show("Password must be a same with " + regCPassword.Text.Trim(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                "VALUES (@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", regUsername.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", regPassword.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approve");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Registered Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }  
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection failed!: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void regShowPass_CheckedChanged(object sender, EventArgs e)
        {
            regPassword.PasswordChar = regShowPass.Checked ? '\0' : '*';
            regCPassword.PasswordChar = regShowPass.Checked ? '\0' : '*';
        }
    }
}
