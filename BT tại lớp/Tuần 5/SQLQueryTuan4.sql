use QL_NhanSu
select *from tbl_Employee
select count(*) from tbl_Employee

select *
from tbl_Employee,tbl_Deparment
where tbl_Deparment.Name=tbl_Employee.Name