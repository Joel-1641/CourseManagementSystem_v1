using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseRepository
    {
        private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB; database=CourseManagement;Trusted_Connection=true;TrustServerCertificate=true;";
        public void AddCourse(string title, string duration, decimal price)
        {

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"INSERT INTO Course(Title,Duration,Price) VALUES(@title,@duration,@price);";
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();
                };
                Console.WriteLine("Course Add Successfully..");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

        }

        public void ListCourses()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT * FROM Course";
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("--- Courses List ---\n");
                        while (reader.Read())
                        {
                            Console.WriteLine($"CourseId: {reader.GetInt32(0)}  Title: {reader.GetString(1)}  Duration: {reader.GetString(2)}  Price: {reader.GetDecimal(3)}");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        public void GetCourseById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT * FROM Course WHERE CourseId == @id";
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine($"CourseId: {reader.GetInt32(0)}  Title: {reader.GetString(1)}  Duration: {reader.GetString(2)}  Price: {reader.GetDecimal(3)}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        public void UpdateCourse(int id, string title, string duration, decimal price)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"UPDATE Course SET Title = @title , Duration = @duration , Price = @price WHERE CourseId = @id";
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@id", id);
                    var rowsaffected = command.ExecuteNonQuery();

                    if (rowsaffected > 0)
                    {
                        Console.WriteLine("Course Update Successfully..");
                    }
                    else
                    {
                        Console.WriteLine("Course Not Found..");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        public void DeleteCourse(int id)
        {
            try
            {
                using (var connections = new SqlConnection(_connectionString))
                {
                    connections.Open();
                    var command = connections.CreateCommand();
                    command.CommandText = @"DELETE FROM Course WHERE CourseId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    var rowsaffected = command.ExecuteNonQuery();

                    if (rowsaffected > 0)
                    {
                        Console.WriteLine("Course Deleted Successfully..");
                    }
                    else
                    {
                        Console.WriteLine("Course Not Found..");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }


       
    }
}


