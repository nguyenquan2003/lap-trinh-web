using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_NhanSu.Models;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhanSu.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult ShowEmployees()
        {
            List<Employee> listemployee = new List<Employee>();
            try
            {
                using (SqlConnection con =new SqlConnection())
                {
                    string conStr = "Data Source=A107PC03;Initial Catalog=QL_NhanSu;Integrated Security=True";
                    con.ConnectionString = conStr;
                    string sql = "select *from tbl_Employee";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);
                    foreach(DataRow row in dt.Rows)
                    {
                        var emp = new Employee();
                        emp.ID=(int)row["ID"];
                        emp.Name = row["Name"].ToString();
                        emp.Gender = row["Gender"].ToString();
                        emp.City = row["City"].ToString();

                        listemployee.Add(emp);
                    }
                }
                return View(listemployee);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        public ActionResult ShowEmployees1()
        {
            ConnectEmployee obj = new ConnectEmployee();
            List<Employee> emplist = obj.getData();
           Session["sl"] = obj.getSL();

            return View(emplist);
        }
        public ActionResult CreateEmployee()
        {
            return View();
        }
        public ActionResult CreateEmployee(FormCollection fc)
        {
            ConnectEmployee obj = new ConnectEmployee();
            var name = fc["FullName"];
            var gender = fc["Gender"];
            var city = fc["City"];
            var deptID = int.Parse(fc["DeptID"]);

            int kt = obj.insertEmployee(name, gender, city, deptID);
            if (kt == 1)
                ViewBag.ThongBao = "Thêm thành công.";
            else
                ViewBag.ThongBao = "Thêm không thành công.";
            return View();
        }
	}
}