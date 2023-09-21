using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\TUF GAMING\\OneDrive\\รูปภาพ\\WorkFolder\\Visual Programming\\MiniProject\\MiniProject\\Database1.mdf\";Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //Method to Check user validation

        /*public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = ("SELECT * FROM Login WHERE username = @username AND upass = @password");
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }*/
    }
}
