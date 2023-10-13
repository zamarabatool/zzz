using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //                             Task 8: ADO.NET Console Application

            string connectionstring = "Server=DESKTOP-RFCECQI\\SQLEXPRESS;Database=DB_5083;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                //                                             TASK-8
                // task-8_1
                using (SqlCommand command = new SqlCommand("AddNewStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", "Shahzaib");
                    command.Parameters.AddWithValue("@LastName", "Ali");
                    command.Parameters.AddWithValue("@Age", "20");
                    command.Parameters.AddWithValue("@CourseID", "2");
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                // task-8_2
                using (SqlCommand command = new SqlCommand("UpdateAge", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Age", 24);
                    command.Parameters.AddWithValue("@StudentID", 1019);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                // task-8_3
                using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", 1019);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                // task-8_4
                using (SqlCommand command = new SqlCommand("AllStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine($"StudentID=> {reader["StudentID"]},FirstName=> {reader["FirstName"]},LastName=> {reader["LastName"]},Age=> {reader["Age"]},CourseID=> {reader["CourseID"]}");
                    }
                    connection.Close();
                }

                //                                             TASK-8
                // task-9_1
                using (SqlCommand command = new SqlCommand("NotEnrolled", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The students who are not enrolled in any course are:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"StudentID=> {reader["StudentID"]},FirstName=> {reader["FirstName"]},LastName=> {reader["LastName"]},Age=> {reader["Age"]}");
                    }
                    connection.Close();
                }
                // task-9_2
                using (SqlCommand command = new SqlCommand("PopularCourse", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The Most Popular Course is ");
                    while (reader.Read())
                    {
                        Console.Write($"{reader["CourseID"]} with {reader["totalstudents"]}total number of students");
                    }
                    connection.Close();
                }
                // task-9_3
                using (SqlCommand command = new SqlCommand("AvgAgeOldStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The students who are older than average age are:");
                    while (reader.Read())
                    {
                        Console.Write($"StudentID=> {reader["StudentID"]},FirstName=> {reader["FirstName"]},LastName=> {reader["LastName"]},Age=> {reader["Age"]}");
                        Console.WriteLine("");
                    }
                    connection.Close();
                }
                // task-9_4
                using (SqlCommand command = new SqlCommand("CourseStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The total number of students and average age for each course is" );
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseName=> {reader["CourseName"]}\n");
                        Console.WriteLine($"CourseID=> {reader["CourseID"]},,total Students=> {reader["Total_Students"]},Age=> {reader["Age"]}\n");
                    }
                    connection.Close();
                }
                // task-9_5
                using (SqlCommand command = new SqlCommand("NoStudentCourse", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The courses that have no students enrolled in them are");
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseID=> {reader["CourseName"]}\n");
                    }
                    connection.Close();
                }
                // task-9_6
                using (SqlCommand command = new SqlCommand("CourseShare", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The total number of students and average age for each course is");
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseName=> {reader["CourseName"]}\n");
                        Console.WriteLine($"CourseID=> {reader["CourseID"]},,total Students=> {reader["Total_Students"]},Age=> {reader["Age"]}\n");
                    }
                    connection.Close();
                }
                // task-9_7
                using (SqlCommand command = new SqlCommand("YoungOldStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine($"The total number of students and average age for each course is");
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseName=> {reader["CourseName"]}\n");
                        Console.WriteLine($"CourseID=> {reader["CourseID"]},,total Students=> {reader["Total_Students"]},Age=> {reader["Age"]}\n");
                    }
                    connection.Close();
                }
            }
        }
    }
}
