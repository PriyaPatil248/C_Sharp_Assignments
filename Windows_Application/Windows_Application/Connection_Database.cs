using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Windows_Application
{
    class Connection_Database
    {
        public SqlConnection cn;

        public Connection_Database()
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#ASSIGNMENTS\Windows_Application\Windows_Application\Windows_Application_Database.mdf;Integrated Security=True;User Instance=True" );

            cn.Open();
        }

        public DataTable GettableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int GetAutoID(string sql)
        {
            int i = 1;

            try
            {
                DataTable dt = GettableData(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                {
                    i = 1;
                }
            }
            catch
            {
                i = 1;
            }

            return i;
        }

        public void ExecuteSqlQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void FillCombo(ComboBox cb, string sql, string dismemb, string val)
        {
            DataTable dt = GettableData(sql);

            cb.ValueMember = val;
            cb.DisplayMember = dismemb;
            cb.DataSource = dt;
        }

        public void FillGrideData(DataGridView dv, string sql)
        {
            DataTable dt = GettableData(sql);
            dv.DataSource = dt;
        }
    }
}
