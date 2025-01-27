using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace gymms
{
    internal class MyConfig
    {
        private String connectionLink = "Data Source=DESKTOP-7GTJGK8\\SQLEXPRESS02;Initial Catalog=gym_db;Integrated Security=True;Trust Server Certificate=True";
        private SqlConnection connection;
        public MyConfig()
        {
            connection = new SqlConnection(connectionLink);
        }
        //red_data



        public void RetrieveData(DataGridView dataGrid)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Create the query
                string query = "SELECT * FROM users";

                // Create the SqlCommand and pass the connection to it
                SqlCommand cmd = new SqlCommand(query, connection); // Using 'con' here directly

                // Create the SqlDataAdapter and bind it to the SqlCommand
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the result of the query
                adapter.Fill(dataTable);

                // Set the DataGridView's data source to the DataTable
                dataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Show the error message in case of an exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection, whether or not an error occurred
                connection.Close();
            }
        }


        //Insert
        public void userInsert(string fname,string uname, string upass, DateTime uregdate)
        {
            try
            {
                connection.Open();
                string query = " insert into users (fullname,username,password,reg_date) values(@fname,@uname,@upass,@uregdate) ";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@fname",fname);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@upass", upass);
                cmd.Parameters.AddWithValue("@uregdate", uregdate);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0) { MessageBox.Show(" successfuly registered"); }

                else
                {
                    MessageBox.Show("Not successfuly registered");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }
        //update
        public void UserUpdate(int user_id, string fname, string uname, string upass, DateTime userRegDate)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Define the SQL query for updating data
                string query = "UPDATE users SET fullname = @fname, username = @uname, password= @upass, reg_date= @userRegDate WHERE user_id = @user_id";

                // Create SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@upass", upass);
                cmd.Parameters.AddWithValue("@userRegDate", userRegDate);
                cmd.Parameters.AddWithValue("@user_id", user_id);



                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the data was updated successfully
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully.");
                }
                else
                {
                    MessageBox.Show("Data update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }
        public void UserDelete(int id)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Define the SQL query for deleting data
                string query = "DELETE FROM users WHERE user_id = @uid";

                // Create SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@uid", id);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the data was deleted successfully
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Data deletion failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }
    }


}