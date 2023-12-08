using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tuan1314.Models;

namespace Tuan1314.Controllers
{
    public class QLNS_ApiController : ApiController
    {
        public List<EmpDepMix> GetEmpDeptLists()
        {
            dbQL_NhanSuNDataContext db = new dbQL_NhanSuNDataContext();
            var listEmpMix = from emp in db.tbl_Employees
                             join dept in db.tbl_Deparments
                             on emp.DeptId equals dept.DeptId
                             select new EmpDepMix()
                             {
                                 Id = emp.Id,
                                 Name = emp.Name,
                                 Gender = emp.Gender,
                                 City = emp.City,
                                 Image = emp.Image,
                                 DeptName = emp.Name
                             };
            return listEmpMix.ToList();
        }
        public EmpDepMix GetEmpDept(int id)
        {
            dbQL_NhanSuNDataContext db = new dbQL_NhanSuNDataContext();
            var EmpMix = from emp in db.tbl_Employees
                         join dept in db.tbl_Deparments
                         on emp.DeptId equals dept.DeptId
                         where emp.Id == id
                         select new EmpDepMix()
                         {
                             Id = emp.Id,
                             Name = emp.Name,
                             Gender = emp.Gender,
                             City = emp.City,
                             Image = emp.Image,
                             DeptName = emp.Name
                         };
            return EmpMix.FirstOrDefault(e => e.Id == id);
        }
    }
}
