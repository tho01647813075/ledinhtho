using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LeDinhTho_02
{
    public class EmloyeeDAL : DBConnection
    {
        public void DeleteEmloyee(EmloyeeBEL emloyee)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Emloyee where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", emloyee.IdEmployee));
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void NewEmloyee(EmloyeeBEL emloyee)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Emloyee values (@id,@name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", emloyee.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@name", emloyee.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditEmloyee(EmloyeeBEL emloyee)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Emloyee set Name=@name where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", emloyee.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@name", emloyee.Name));
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public List<EmloyeeBEL> ReadEmloyee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Employee", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<EmloyeeBEL> lstEml = new List<EmloyeeBEL>();
            while (reader.Read())
            {
                EmloyeeBEL emloyee = new EmloyeeBEL();
                //emloyee.IdEmployee = reader["id"].ToString();
                emloyee.Name = reader["name"].ToString();
                lstEml.Add(emloyee);
            }
            conn.Close();
            return lstEml;
        }

    }
}

