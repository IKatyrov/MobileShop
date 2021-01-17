create table customerPurchase(
cid int not null identity(1,1) primary key,
cname varchar(250) not null,
gender varchar(50) not null,
contact bigint not null,
email varchar(250) not null,
caddress varchar(350) not null,
company varchar(250) not null,
model varchar(250) not null,
imei varchar(250) not null,
);

select * from customerPurchase;