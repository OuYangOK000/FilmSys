use DB_Cinema;
--用户预定表
--Cid varchar(20) not null,			预定编号
--[Call] varchar(20) not null,		电话
--[Address] varchar(40) not null,	地址
--Idcard varchar(20) not null,		身份证
--Checkdate Date not null,			预定日期
--Filmid varchar(20) not null,				电影编号
--[Uid] varchar(20) not null				用户编号
insert into UReserves(Cid,[Call],[Address],Idcard,Checkdate,Filmid,[Uid])
 values('C0001','13566910231','广东珠海','430527199909026012','','','U0001')