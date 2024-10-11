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


    }
}
