using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace simpleerp.model.test
{
    public class BaseTest
    {
        protected void setupDB()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["simpleerp"].ConnectionString;
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string[] cleanSql = getDBCleanSql();
                    for (int i = 0; i < cleanSql.Length; i++)
                    {
                        String queryStr = cleanSql[i];
                        SqlCommand command = new SqlCommand(queryStr, conn);
                        command.ExecuteNonQuery();
                    }
                    string[] testDataSql = getDBTestDataSql();
                    for (int i = 0; i < testDataSql.Length; i++)
                    {
                        String queryStr = testDataSql[i];
                        SqlCommand command = new SqlCommand(queryStr, conn);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected string[] getDBCleanSql()
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "clean.sql");

            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }

        protected string[] getDBTestDataSql()
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "test_data.sql");

            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }
    }
}
