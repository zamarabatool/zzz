using System.Data;
using System.Data.SqlClient;

string connectionString = "Server=cmdlhrdb01;Database=5076_DB;Trusted_Connection=True;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    // Task 7.1: Execute Stored Procedure to Add an Employee
    using (SqlCommand command = new SqlCommand("AddStudent", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@FirstName", "Hamza");
        command.Parameters.AddWithValue("@LastName", "Nazir");
        command.Parameters.AddWithValue("@Age", 30);
        command.Parameters.AddWithValue("@StudentID", 1100);
        command.Parameters.AddWithValue("@CourseID", 1);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    // Task 7.2: Execute Stored Procedure to Update an Employee's Age
    using (SqlCommand command = new SqlCommand("UpdateEmployeeAge", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StudentID", 1);
        command.Parameters.AddWithValue("@NewAge", 41);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    // 4. Execute Stored Procedure to Delete an Employee
    using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StudentID", 1);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

 // 1. Execute Stored Procedure to Get All Employees
    using (SqlCommand command = new SqlCommand("GetAllStudents", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Student ID: {reader["StudentID"]}, First Name: {reader["FirstName"]},  Last Name: {reader["LastName"]}, Age: {reader["Age"]}, CourseID: {reader["CourseID"]}");
        }
        connection.Close();
    }
}