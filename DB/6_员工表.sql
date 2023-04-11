use DB_Cinema;
--员工表
--Eid varchar(20) not null,			员工编号
--Ename varchar(20) null,			员工姓名
--Gender varchar(20) null,			性别
--Birthday date null,				出生日期
--Idcard varchar(20) null,			身份证号
--Wedlock varchar(20) null,			婚姻状况
--Nation varchar(20) null,			民族
--Nationplace varchar(20) null,		籍贯
--Politicid varchar(20) null,		政治面貌
--Email varchar(20) null,			邮箱
--Phone varchar(20) null,			电话号码
--[Address] varchar(20) null,		联系地址
--Did varchar(20) null,				所属部门
--Jodlevelid varchar(20) null,		职称
--Degindate varchar(20) null,		入职日期
--School varchar(20) null			毕业院校

insert into Employees(Eid,Ename,Gender,Birthday,Idcard,Wedlock,Nation,Nationplace,Politicid
	,Email,Phone,[Address],Did,Jodlevelid,Degindate,School)
  values('E0001','张昊','男','1976-09-10','110500197609106012','已婚','汉族','北京'
  ,'群众','','13569301320','广东珠海','DT001','总经理','2001','')
insert into Employees(Eid,Ename,Gender,Birthday,Idcard,Wedlock,Nation,Nationplace,Politicid
	,Email,Phone,[Address],Did,Jodlevelid,Degindate,School)
  values('E0002','陈思雨','女','1996-10-10','430500199610106002','未婚','汉族','湖南'
  ,'群众','','15693015320','广东珠海','TD005','会计','2019','')
insert into Employees(Eid,Ename,Gender,Birthday,Idcard,Wedlock,Nation,Nationplace,Politicid
	,Email,Phone,[Address],Did,Jodlevelid,Degindate,School)
  values('E0003','高冬青','女','1984-05-15','44040019840515520x','已婚','汉族','广东珠海'
  ,'群众','','15663312330','广东珠海','DT003','业务经理','2005','')
insert into Employees(Eid,Ename,Gender,Birthday,Idcard,Wedlock,Nation,Nationplace,Politicid
	,Email,Phone,[Address],Did,Jodlevelid,Degindate,School)
  values('E0004','李世昌','男','2000-02-12','610100200002122535','未婚','回族','陕西西安'
  ,'群众','','13539055333','广东珠海','DT002','售票员','2022','')