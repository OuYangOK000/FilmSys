use DB_Cinema;
--管理员表
--Id varchar(20) not null,			管理员编号
--[Name] varchar(20) not null,		管理员姓名
--[Login] varchar(20) not null,		登录名
--[Password] varchar(20) not null,	登录密码
--[State] varchar(4) not null		状态

insert into Admins(Id,[Name],[Login],[Password],[State])
 values('GM01','陈某','czq','199621','在线')
insert into Admins(Id,[Name],[Login],[Password],[State])
 values('GM02','高某','gy','131131','在线')
insert into Admins(Id,[Name],[Login],[Password],[State])
 values('GM03','张某','zjj','123456','离线')