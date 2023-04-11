use master;
if DB_ID('DB_Cinema') is not null
 drop database DB_Cinema
go
create database DB_Cinema
on
(
	name='DB_Cinema',
	filename='E:\��ҵ��������Ŀ���\DB\DB_Cinema.MDF'
);
use DB_Cinema;
--�û���Ϣ��
if Object_ID('UInformations') is not null
 drop table UInformations
create table UInformations
(
	[Uid] varchar(20) not null,			--�û����
	[Name] varchar(20) not null,		--�û�����
	[Phone] varchar(20) not null,		--�绰
	Idcard varchar(18) not null,		--���֤����
	[Address] varchar(100) null,		--��ַ
	ULogin varchar(20) not null,		--��¼��
	UPword varchar(20) not null			--��¼����
);
--�û�Ԥ����
if Object_ID('UReserves') is not null
 drop table UReserves
create table UReserves
(
	Cid varchar(20) not null,			--Ԥ�����
	[Call] varchar(20) not null,		--�绰
	[Address] varchar(40) not null,		--��ַ
	Idcard varchar(20) not null,		--���֤
	Checkdate Date not null,			--Ԥ������
	Filmid varchar(20) not null,		--��Ӱ���
	[Uid] varchar(20) not null			--�û����
);
--�������ͱ�
if Object_ID('DepartmentTypes') is not null
 drop table DepartmentTypes
create table DepartmentTypes
(
	Did varchar(20) not null,			--���ű��
	DType varchar(20) not null			--��������
);
--Ա����
if Object_ID('Employees') is not null
 drop table Employees
create table Employees
(
	Eid varchar(20) not null,			--Ա�����
	Ename varchar(20) null,				--Ա������
	Gender varchar(20) null,			--�Ա�
	Birthday varchar(20) null,					--��������
	Idcard varchar(20) null,			--���֤��
	Wedlock varchar(20) null,			--����״��
	Nation varchar(20) null,			--����
	Nationplace varchar(20) null,		--����
	Politicid varchar(20) null,			--������ò
	Email varchar(20) null,				--����
	Phone varchar(20) null,				--�绰����
	[Address] varchar(20) null,			--��ϵ��ַ
	Did varchar(20) null,				--��������
	Jodlevelid varchar(20) null,		--ְ��
	Degindate varchar(20) null,			--��ְ����
	School varchar(20) null				--��ҵԺУ
);
--��Ӱ��
if Object_ID('Films') is not null
 drop table Films
create table Films
(
	Filmid	varchar(20)	not null,		--��Ӱ���
	Fname varchar(40) not null,			--��Ӱ����
	Id varchar(20) not null,			--��Ӱ���ͱ��
	[Money] float not null,				--�۸�
	KSTime varchar(20) not null,		--��ʼʱ��
	JSTime varchar(20) not null,		--����ʱ��
	FilmTid varchar(20) not null,				--��Ӱ�����
	Remark varchar(500) null			--��ע
);
--��Ӱ���ͱ�
if Object_ID('FilmTypes') is not null
 drop table FilmTypes
create table FilmTypes
(
	Id varchar(20) not null,			--��Ӱ���ͱ��
	FType varchar(20) not null			--��������
);
--��Ӱ����
if Object_ID('FilmTs') is not null
 drop table FilmTs
create table FilmTs
(
	Tid varchar(20) not null,					--��Ӱ�����
	TName varchar(20) not null,			--��Ӱ������
	Number varchar(20) not null,		--��λ����
	[State] varchar(4) not null			--�Ƿ���
);
--����Ա��
if Object_ID('Admins') is not null
 drop table Admins
create table Admins
(
	Id varchar(20) not null,					--����Ա���
	[Name] varchar(20) not null,		--����Ա����
	[Login] varchar(20) not null,		--��¼��
	[Password] varchar(20) not null,	--��¼����
	[State] varchar(4) not null			--״̬
);

select * from Films
select * from Employees