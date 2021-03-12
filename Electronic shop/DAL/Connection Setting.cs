using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Electronic_shop.DAL
{
    class Connection_Setting
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        //Connection String
        public Connection_Setting()
        {
            cn = new SqlConnection("Server=.\\SQLEXPRESS;database=Electronic_Shop;integrated Security=true");
        }
        
        //Open Connection
        public void Open()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        //Close Connection
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        //Delete Update Insert Data
        public void RUA(string Stored_Command,SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Command;
            cmd.Connection = cn;

            if(p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cmd.ExecuteNonQuery();
        }

        //Read Data
        public DataTable Reader(string Stored_Command, SqlParameter[] p)
        {
            dt = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Command;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }

}
