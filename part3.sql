use HumanResource
select * from personal_info
create table department(
dep_ID varchar(30) primary key,
Dep_name varchar(100),
Administror_name varchar(100),
Administror_ID varchar(30),
effective_date varchar(100)
)
select *from department
create table assign(
Emp_ID varchar(30),
Dep_ID varchar(30),
Dep_name varchar(100),
position varchar(100),
salary float,
password_ varchar(100),
primary key(Emp_ID,Dep_ID)
)
select * from assign
