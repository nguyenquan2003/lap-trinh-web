using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using _2001215617_NguyenNgocBao.Models;
namespace _2001215617_NguyenNgocBao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult ShowEmployees()
        {
            List<Employee> listEmployee = new List<Employee>();

            try
            {
                string conStr = "Data Source=MSI\\MSSQLSERVER2022;Initial Catalog=QL_NhanSu;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.ConnectionString = conStr;
                    string sql = "Select * from tbl_Employee";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var emp = new Employee();
                        emp.ID = (int)row["Id"];
                        emp.Name = row["Name"].ToString();
                        emp.Gender = row["Gender"].ToString();
                        emp.City = row["City"].ToString();
                        listEmployee.Add(emp);
                    }
                }

                return View(listEmployee);
            }
            catch
            {
                
                return RedirectToAction("Error", "Home");
            }
        }
        public ActionResult ShowEmployees1()
        {
            ConnecEmployee obj = new ConnecEmployee();
            List<Employee> empList = obj.getData();
            Session["s1"] = obj.getSl();

            return View(empList);
        }
    }
}