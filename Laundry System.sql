create database exercise5

use exercise5

create table CUSTOMER
(CUS_JOBORDER int primary key,
CUS_LNAME varchar(20),
CUS_FNAME varchar(20),
CUS_PHONE varchar(12),
CUS_AMOUNT money,
CUS_DATE date,
CUS_STATUS varchar(10),
CUS_BALANCE money,
CUS_DOWNPAYMENT money)
select * from CUSTOMER
drop table CUSTOMER

create table RECORD
(RECORD_DATE date,
RECORD_ORDERS int,
RECORD_INCOME money



SELECT COUNT(CUS_JOBORDER) FROM CUSTOMER

select * from CUSTOMER
select * from RECORD

insert into RECORD values ('2016-06-24', 0, 0)

SELECT SUM(CUS_AMOUNT) FROM CUSTOMER
                                      
select * from customer
Select * from CUSTOMER
drop table CUSTOMER

create table ORDERS(ORDER_NO int primary key,
		ORDER_TYPE varchar(30),
		ORDER_QTY int,
		ORDER_TOTAL money,
		ORDER_BY int,
		FOREIGN KEY(ORDER_BY) REFERENCES CUSTOMER(CUS_CODE))

create table USERS
(username varchar(20),
pass varchar(20),
secretans varchar(20))