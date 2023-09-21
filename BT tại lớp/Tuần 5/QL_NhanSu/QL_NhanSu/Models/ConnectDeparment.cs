using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhanSu.Models
{
    public class ConnectDeparment
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public List<Deparment> getData()
        {
            List<Deparment> listDeparments = new List<Deparment>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select*from tbl_Deparment";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Deparment dept = new Deparment();
                dept.DeptID = Convert.ToInt32(rdr.GetValue(0).ToString());
                dept.Name = rdr.GetValue(1).ToString();
                listDeparments.Add(dept);
            }
            return (listDeparments);
        }
        public Deparment Details(string id)
        {
            List<Deparment> lisDeparments = new List<Deparment>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select*from tbl_Deparment";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Deparment dept = new Deparment();
                dept.DeptID = Convert.ToInt32(rdr.GetValue(0).ToString());
                dept.Name = rdr.GetValue(1).ToString();
                lisDeparments.Add(dept);
            }
            int ma = int.Parse(id);
            Deparment d = lisDeparments.FirstOrDefault(i => i.DeptID == ma);
            return d;
        }
        public int SoNV(string id)
        {
            int ma = int.Parse(id);
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select count(tbl_Employee.Id) as SoNV from tbl_Deparment,tbl_Employee where tbl_Deparment.DeptId=tbl_Employee.DeptId and tbl_Deparment.DeptId=@MaPB";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter Par = cmd.CreateParameter();
            Par.ParameterName = "@MaPB";
            Par.Value = ma;
            cmd.Parameters.Add(Par);

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
        public List<Employee> ListEmplByDept(string id)
        {
            int ma = int.Parse(id);
            List<Employee> listEmployees = new List<Employee>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select *from tbl_Employee where DeptId=@MaPB";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;
            SqlParameter Par = cmd.CreateParameter();
            Par.ParameterName = "@MaPB";
            Par.Value = ma;
            cmd.Parameters.Add(Par);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
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
    }
}