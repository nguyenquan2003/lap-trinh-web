using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhanSu.Models
{
    public class ConnectEmployee
    {
        string conStr = "Data Source=A107PC03;Initial Catalog=QL_NhanSu;Integrated Security=True";
        public List<Employee> getData()
        {
            List<Employee> listEmployees = new List<Employee>();

            SqlConnection con = new SqlConnection(conStr);
            string sql = "select *from tbl_Employee";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Gender = rdr.GetValue(2).ToString();
                emp.City = rdr.GetValue(3).ToString();

                listEmployees.Add(emp);
            }
            con.Close();
            return (listEmployees);
        }
        public int getSL()
        {
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select count(*) from tbl_Employee";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
        public int insertEmployee(string name, string gender,string city,int deptID)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            int rs = 0;
            string sql1 = "select*from tbl_Employee where Name ='" + name + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            int kt = (int)cmd1.ExecuteScalar();
            if(kt==0)
            {
                string sql = "Insert into tbl_Employee (Name, Gender, City, DeptID)";
                sql += "values(N'" + name + "', N'" + gender + "',N'" + city + "','" + deptID + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                rs=cmd.ExecuteNonQuery();
            }
            con.Close();
            return rs;
        }
    }

}