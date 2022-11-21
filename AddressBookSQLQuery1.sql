create database AddressBookServiceDB

use AddressBookServiceDB
create table AddressBook
(
firstName varchar(25),
lastName varchar(25),
address varchar(200),
city varchar(25),
state varchar(25),
zip int,
phoneNumber bigint,
email varchar(100)
);
select * from AddressBook;


insert into AddressBook values
('Sangmeshwar','Patil','Latur','Udgir','MH',413517,8888888888,'patil@gmail.com'),
('Pramod','Patil','Latur','Ausa','Maharashtra',413518,78577964412,'pramod@gmail.com')

update AddressBook set zip =413517 where firstName='Pramod'
delete from AddressBook where firstName='Pramod'