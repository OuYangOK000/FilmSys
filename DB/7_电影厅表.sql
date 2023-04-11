use DB_Cinema;
--电影厅表
--Tid varchar(20) not null,			电影厅编号
--TName varchar(20) not null,		电影厅名称
--Number varchar(20) not null,		座位数量
--[State] varchar(4) not null		是否开厅

insert into FilmTs(Tid,TName,Number,[State])
 values('T01','一厅','50','已开')
insert into FilmTs(Tid,TName,Number,[State])
 values('T02','二厅','50','已开')
insert into FilmTs(Tid,TName,Number,[State])
 values('T03','三厅','50','已开')
insert into FilmTs(Tid,TName,Number,[State])
 values('T04','四厅','50','已开')
insert into FilmTs(Tid,TName,Number,[State])
 values('T05','五厅','50','未开')