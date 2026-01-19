using PMS.Models;
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

namespace PMS.View
{
    public partial class AdminUpdateProfile : Form
    {
        public AdminUpdateProfile()
        {
            InitializeComponent();
        }

        private void AdminUpdateProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
           // ProfileUpdate();
        }

        private void LoadProfileData()
        {
            string uname = Session.CurrentUsername;

            //if (string.IsNullOrEmpty(uname))
            //{
            //    MessageBox.Show("Current username is empty!");
            //    return;
            //}

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM UserAccounts WHERE username = @uname";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", uname); // must match @uname in query

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_fname.Text = reader["fullname"].ToString();
                                tb_uname.Text = reader["username"].ToString();
                                tb_pass.Text = reader["password"].ToString();
                                tb_phone.Text = reader["phoneNumber"].ToString();
                                tb_email.Text = reader["email"].ToString();

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ProfileUpdate()
        {
            // New values from textboxes
            string newFullname = tb_fname.Text;
            string newUsername = tb_uname.Text;
            string newPassword = tb_pass.Text;
            string newPhone = tb_phone.Text;
            string newEmail = tb_email.Text;

            // Original username stored in session
            string originalUsername = Session.CurrentUsername;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();

                    string updateQuery = @"UPDATE UserAccounts 
                                   SET Fullname = @Fullname, 
                                       Username = @NewUsername, 
                                       Password = @Password, 
                                       PhoneNumber = @PhoneNumber, 
                                       Email = @Email 
                                   WHERE Username = @OriginalUsername";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", newFullname);
                        cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@PhoneNumber", newPhone);
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@OriginalUsername", originalUsername);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");

                            // Update session with new username
                            Session.CurrentUsername = newUsername;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Username not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ProfileUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile q = new AdminProfile();    
            q.Show();
            this.Hide();
            
        }
    }
}
