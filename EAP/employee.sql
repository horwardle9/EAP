use master
go
create database EmployeeWCF
go
use EmployeeWCF

CREATE TABLE tbEmployees
(
	EmployeeID varchar(10) primary key,
	EmployeeName varchar(30),
	EmployeeDepartment varchar(30),
	EmployeeSalary int
) 

Select * from tbEmployees
