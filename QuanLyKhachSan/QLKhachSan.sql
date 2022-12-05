create database QLKhachSan
use QLKhachSan
create table Account
(
	username varchar(10),
	password varchar(30)
)
create table Employee
(
	ID varchar(10),
	SName nvarchar(30),
	bd date,
	CV nvarchar(30),
	Luong int
)

insert into Account values ('nam', '123')
insert into Employee values('KT001', N'Nguyễn Văn A', '12/02/2000', N'Kế toán', 15000000),('KT002', N'Nguyễn Thị B', '11/12/2000', N'Kế toán', 20000000)
select * from Employee
drop table Employee
