using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace _131L_EXER2
{
    class DBConnections
    {
        private SqlConnection OpenConn()
        {
            string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ExecuteQuery(string sqlQuery, string tblName)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmdCommand = new SqlCommand();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter();
            DataSet dsDataSet = new DataSet();
            DataTable dtTable = new DataTable();

            conn = OpenConn();
            cmdCommand.Connection = conn;
            cmdCommand.CommandType = CommandType.Text;
            cmdCommand.CommandText = sqlQuery;
            dtaAdapter.SelectCommand = cmdCommand;
            dtaAdapter.Fill(dsDataSet, tblName);
            conn.Close();
            return dsDataSet;



        }
    }
}
