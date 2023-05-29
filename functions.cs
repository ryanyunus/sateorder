using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderReceipt
{
    public class Functions // perubahan 1: ganti private menjadi public dan tambahkan class
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        public Functions() // perubahan 2: ganti "functions" menjadi "Functions"
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A\Documents\ryanDB.mdf;Integrated Security=True;Connect Timeout=30"; // perubahan 3: ganti "Constr" menjadi "ConStr"
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable(); // perubahan 4: ganti "Dt" menjadi "dt"
            sda = new SqlDataAdapter(Query,ConStr); // perubahan 5: ganti "Constr" menjadi "ConStr"
            sda.Fill(dt);
            return dt;
        }

        public int setData(string query) // perubahan 6: ganti "setData" menjadi "SetData" dan tambahkan tanda kurung
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            cmd.CommandText = query; // perubahan 7: ganti "=" menjadi ".CommandText="
            cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }
}
