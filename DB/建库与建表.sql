use master;
if DB_ID('DB_Cinema') is not null
 drop database DB_Cinema
go
create database DB_Cinema
on
(
	name='DB_Cinema',
	filename='E:\毕业论文与项目设计\DB\DB_Cinema.MDF'
);
use DB_Cinema;
--用户信息表
if Object_ID('UInformations') is not null
 drop table UInformations
create table UInformations
(
	[Uid] varchar(20) not null,			--用户编号
	[Name] varchar(20) not null,		--用户姓名
	[Phone] varchar(20) not null,		--电话
	Idcard varchar(18) not null,		--身份证号码
	[Address] varchar(100) null,		--地址
	ULogin varchar(20) not null,		--登录名
	UPword varchar(20) not null			--登录密码
);
--用户预定表
if Object_ID('UReserves') is not null
 drop table UReserves
create table UReserves
(
	Cid varchar(20) not null,			--预定编号
	[Call] varchar(20) not null,		--电话
	[Address] varchar(40) not null,		--地址
	Idcard varchar(20) not null,		--身份证
	Checkdate Date not null,			--预定日期
	Filmid varchar(20) not null,		--电影编号
	[Uid] varchar(20) not null			--用户编号
);
--部门类型表
if Object_ID('DepartmentTypes') is not null
 drop table DepartmentTypes
create table DepartmentTypes
(
	Did varchar(20) not null,			--部门编号
	DType varchar(20) not null			--部门名称
);
--员工表
if Object_ID('Employees') is not null
 drop table Employees
create table Employees
(
	Eid varchar(20) not null,			--员工编号
	Ename varchar(20) null,				--员工姓名
	Gender varchar(20) null,			--性别
	Birthday varchar(20) null,					--出生日期
	Idcard varchar(20) null,			--身份证号
	Wedlock varchar(20) null,			--婚姻状况
	Nation varchar(20) null,			--民族
	Nationplace varchar(20) null,		--籍贯
	Politicid varchar(20) null,			--政治面貌
	Email varchar(20) null,				--邮箱
	Phone varchar(20) null,				--电话号码
	[Address] varchar(20) null,			--联系地址
	Did varchar(20) null,				--所属部门
	Jodlevelid varchar(20) null,		--职称
	Degindate varchar(20) null,			--入职日期
	School varchar(20) null				--毕业院校
);
--电影表
if Object_ID('Films') is not null
 drop table Films
create table Films
(
	Filmid	varchar(20)	not null,		--电影编号
	Fname varchar(40) not null,			--电影名称
	Id varchar(20) not null,			--电影类型编号
	[Money] float not null,				--价格
	KSTime varchar(20) not null,		--开始时间
	JSTime varchar(20) not null,		--结束时间
	FilmTid varchar(20) not null,				--电影厅编号
	Remark varchar(500) null			--备注
);
--电影类型表
if Object_ID('FilmTypes') is not null
 drop table FilmTypes
create table FilmTypes
(
	Id varchar(20) not null,			--电影类型编号
	FType varchar(20) not null			--类型名称
);
--电影厅表
if Object_ID('FilmTs') is not null
 drop table FilmTs
create table FilmTs
(
	Tid varchar(20) not null,					--电影厅编号
	TName varchar(20) not null,			--电影厅名称
	Number varchar(20) not null,		--座位数量
	[State] varchar(4) not null			--是否开厅
);
--管理员表
if Object_ID('Admins') is not null
 drop table Admins
create table Admins
(
	Id varchar(20) not null,					--管理员编号
	[Name] varchar(20) not null,		--管理员姓名
	[Login] varchar(20) not null,		--登录名
	[Password] varchar(20) not null,	--登录密码
	[State] varchar(4) not null			--状态
);

select * from Films
select * from Employees