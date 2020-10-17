using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestSQL
{
    class DataFood_Fix
    {
        String connString;
        SqlConnection connection;
        Menu_Fix parent;
        public DataFood_Fix(Menu_Fix parentf,string server = "DESKTOP-J6GHMMO", string database = "User")
        {
            this.parent = parentf;
            connString = @"Server=" + server + ";Database=" + database + ";User Id=sa;Password=Turtle19520253;";
            connection = new SqlConnection(connString);
            connection.Open();
        }
        public void ReadDATA(string table = "MENU")
        {
            String sqlQuery = "select * from " + table;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                parent.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
        }
        public bool InSertData(string name="",string price ="",string path ="", string table = "MENU")
        {
            try
            {
                String sqlQuery = "insert into " + table +  "(NAME,PRICE,URL) VALUES (@name,@price,@path)";
                MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@path", path);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Món ăn đã tồn tại","Lổi trùng lặp");
                return false;
            }
        }
        public bool DeleteData(string name = "", string table = "MENU")
        {
            try
            {
                String sqlQuery = "DELETE FROM " + table +" WHERE NAME= @name";
                MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Món ăn "+name+ " không tồn tại", "Lổi");
                return false;
            }
        }
    }
}
