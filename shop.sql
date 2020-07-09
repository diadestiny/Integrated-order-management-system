create table  客户(
客户账号  varchar(30) primary key,
客户姓名 varchar(30),
登录密码   varchar(30) not null,
性别 varchar(5) default '男',
居住地 varchar(30),
手机号码 bigint 
)

create table  商家(
商家账号  varchar(30) primary key ,
登录密码  varchar(30) not null,
店铺名称 varchar(30),
店铺地址 varchar(30),
联系电话 bigint 
)

create table  商品(
商品编号  bigint primary key identity(1,1),
商品名称 varchar(30),
上架时间 date,
价格 int,
商品简介 varchar(100),
发布商家 varchar(30) foreign key references  商家(商家账号)
)

create table  订单(
订单编号  bigint primary key identity(1,1),
送达地址  varchar(30),
下单时间 datetime,
客户账号 varchar(30) foreign key references  客户(客户账号),
商品编号 bigint foreign key references  商品(商品编号)
)

