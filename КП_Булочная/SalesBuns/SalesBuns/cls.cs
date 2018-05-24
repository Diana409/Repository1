using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Common;
using System.Data;

namespace SalesBuns
{
    class cls
    {
        public static ArrayList LoadData(string query)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }
            con.Close();
            return records;
        }

        public static ArrayList LoadCMB(string query)
        
        {
            
            
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }
            con.Close();
            return records;
        }
        public struct DataOdrersBuns
        {
            public int id;
            //public int idTypesBuns;
            //public int idBuns;
            //public string title;
            //public string author;
        }
    }
}
