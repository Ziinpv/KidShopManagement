using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyShopQuanAoTreEm.Models
{
    internal class Main
    {
        public static readonly string con_string = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public static SqlConnection con = new SqlConnection(con_string);


        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = @"SELECT * FROM users where Username = '" + user + "' and Password '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            if (dt.Rows.Count > 0)

            {

                isValid = true;
                USER = dt.Rows[0]["Username"].ToString();


            }
            return isValid;
        }


        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);

                }
                if (con.State == ConnectionState.Closed)
                { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();


            }

            return res;
        }
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;


        }
    }
}
