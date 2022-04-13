create database HumanResource
use HumanResource
create table manager(
username varchar(20) primary key,
password varchar(30)
)
insert into manager values('Admin','Admin')
select * from manager
create table personal_info(
Employee_ID varchar(30) primary key,
Firstname varchar(50),
Lastname varchar(50),
Email varchar(50),
Gender varchar(10),
City varchar(50),
Subcity varchar(50),
Wereda varchar(50),
Date_ varchar(100),
picture image
)
select Employee_ID from personal_info;