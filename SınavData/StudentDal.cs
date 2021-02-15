using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavData
{
    public class StudentDal
    {
        public List<Student> GetAll()
        {
            SqlConnection connection=new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=School;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command=new SqlCommand("Select * from Students",connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students=new List<Student>();
            while (reader.Read())
            {
                Student student=new Student
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Not = Convert.ToInt32(reader["Not"])
                };
                students.Add(student);
            }
            connection.Close();
            reader.Close();
            return students;
        }
    }
}
