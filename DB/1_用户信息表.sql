use DB_Cinema;
select * from UInformations
--用户信息表
--[Uid] varchar(20) not null,		用户编号
--[Name] varchar(20) not null,		用户姓名
--[Phone] varchar(20) not null,		电话
--Idcard varchar(18) not null,		身份证号码
--[Address] varchar(100) null		地址
--ULogin varchar(20) not null,		登录名
--UPword varchar(20) not null		登录密码
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0001','张三','13566910231','430527199909026012','广东珠海','zhangsan','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0002','李四','13532010231','61010019980517600x','陕西西安','lisi','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0003','王五','13966410221','410000197805022052','河南','wangwu','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0004','赵六','13533122131','420000199707026032','湖北','zhaoliu','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0005','陈琦','15669310274','430100200001013002','湖南长沙','chenqi','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0006','刘三','13537910263','110000199801202112','北京','liusan','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0007','王志涛','13510120417','230000200102216012','东北黑龙江','wangzhitao','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0008','张裕','13563950731','360000198910126032','江西','zhangyu','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0009','李琛','13734570195','530000199609026002','云南','lichen','123456')
insert into UInformations([Uid],[Name],[Phone],Idcard,[Address],ULogin,UPword)
 values('U0010','赵芸','13534041520','13000019996051602','河北','zhaoyun','123456')