using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Electronic_shop.DAL
{
    class PL
    {

        Connection_Setting ob = new Connection_Setting();
        DataTable dt = new DataTable();
        /////////////////////////Login
        public DataTable Login_Verify(string UserName,string Password)
        {
            
            dt = new DataTable();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            p[0].Value = UserName;
            p[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            p[1].Value = Password;

            ob.Open();
            dt = ob.Reader("Login_Verify", p);
            ob.Close();
            return dt;
        }

        ///////////////////////register
        public void UserCreate(string UserName, string FirstName, string LastName, string Email, string Password, string UserType, string Phone)
        {
            
            SqlParameter[] p = new SqlParameter[7];
            p[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
            p[0].Value = FirstName;
            p[1] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
            p[1].Value = LastName;
            p[2] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            p[2].Value = Email;
            p[3] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            p[3].Value = Password;
            p[4] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            p[4].Value = UserType;
            p[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            p[5].Value = Phone;
            p[6] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            p[6].Value = UserName;
            ob.Open();
            ob.RUA("UserCreate", p);
            ob.Close();
        }

        //////////////////Update
        public void UpdateUser(int id, string UserName, string FirstName, string LastName, string Email, string Password, string UserType, string Phone)
        {
            
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
            p[0].Value = FirstName;
            p[1] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
            p[1].Value = LastName;
            p[2] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            p[2].Value = Email;
            p[3] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            p[3].Value = Password;
            p[4] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            p[4].Value = UserType;
            p[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            p[5].Value = Phone;
            p[6] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            p[6].Value = UserName;
            p[7] = new SqlParameter("@id", SqlDbType.Int);
            p[7].Value = id;
            ob.Open();
            ob.RUA("UpdateUser", p);
            ob.Close();
        }

        /////////// Delete User
        public void DeleteUser(int id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.Open();
            ob.RUA("DeleteUser", p);
            ob.Close();
        }

        /////////// Select Users
        public DataTable selectAll()
        {

            dt = new DataTable();
            ob.Open();
            dt = ob.Reader("selectAll", null);
            ob.Close();
            return dt;
        }

        //////////// Search
        public DataTable SearchUser(string input)
        {

            dt = new DataTable();

            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@input", SqlDbType.NVarChar, 50);
            p[0].Value = input;

            ob.Open();
            dt = ob.Reader("SearchUser", p);
            ob.Close();
            return dt;
        }


        /////////////////////add product
        public void Add_Product(string item_name,string description,double price,string type,byte[] image)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@item_name", SqlDbType.NVarChar, 50);
            p[0].Value = item_name;
            p[1] = new SqlParameter("@description", SqlDbType.NVarChar, 50);
            p[1].Value = description;
            p[2] = new SqlParameter("@price", SqlDbType.Float);
            p[2].Value = price;
            p[3] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            p[3].Value = type;
            p[4] = new SqlParameter("@image", SqlDbType.Image);
            p[4].Value = image;
            
            ob.Open();
            ob.RUA("Add_Product", p);
            ob.Close();

        }
        /////////////Select Products
        public DataTable SelectProducts()
        {
            dt = new DataTable();
            ob.Open();
            dt = ob.Reader("SelectProducts", null);
            ob.Close();
            return dt;
        }


    }
}
