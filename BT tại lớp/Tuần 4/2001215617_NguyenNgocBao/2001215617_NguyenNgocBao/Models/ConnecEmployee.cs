using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace _2001215617_NguyenNgocBao.Models
{
    public class ConnecEmployee
    {
        string conStr = "Data Source=MSI\\MSSQLSERVER2022;Initial Catalog=QL_NhanSu;Integrated Security=True";
        public List<Employee> getData()
        {
            List<Employee> listEmployees = new List<Employee>();

            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from tbl_Emloyee";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Employee emd = new Employee();
                emd.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
                emd.Name = rdr.GetValue(0).ToString();
                emd.Gender = rdr.GetValue(0).ToString();
                emd.City = rdr.GetValue(0).ToString();

                listEmployees.Add(emd);
            }
            return listEmployees;
        }
        public int getSl()
        {
            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from tbl_Emloyee";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
    }
}