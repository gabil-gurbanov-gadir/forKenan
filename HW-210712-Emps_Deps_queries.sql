
create database WorkDb

use WorkDb

create table Deprtments
(
Id int primary key identity,
Name nvarchar(30) not null, constraint CK_Department_Name check(len(Name)>2)
)

insert Deprtments
values('Marketting'),('Operations'),('Finance'),('Sales')

EXEC sp_rename 'Deprtments', 'Departments'

create table Employees
(
Id int primary key identity,
FullName nvarchar(50) not null, constraint CK_Employee_FullName check(len(FullName)>3),
Salary decimal(8,2) constraint CK_Employee_Salary check(Salary>0),
DepartmentId int constraint FK_DEPARTMENTS_EMPLOYEES foreign key 
references Departments(Id)
)

insert Employees
values('Veli Kazimov',600,1),('Eli Hemidov',800,2),('Seymur Esedov',450,1),('Kerim Rehimli',6000,3),('Leyla Melikzade',1600,4)

select Emp.Id,FullName,Salary,Dep.Name from Employees as Emp
join Departments as Dep
on Emp.DepartmentId=Dep.Id