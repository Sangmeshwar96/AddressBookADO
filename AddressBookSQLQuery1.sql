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

insert into AddressBook values
('Prajakta','Patil','Udgir','Latur','Maharashtra',413519,1111111111,'prajaktpatil@gmail.com')

select * from AddressBook where city='Latur' or state='MH'

select count(email) TotalPersons from AddressBook

insert into AddressBook values
('Basweshwar','Patil','NairCollege','Mumbai','Maharashtra',400003,4444444444,'basweshwar@gmail.com')

select * from AddressBook where city ='Mumbai' order by firstName

alter table AddressBook add type varchar(20),name varchar(20)
update AddressBook set type='Superstars' where firstName='Sangmeshwar' or firstName='Prajakta'
update AddressBook set name='MumbaiContacts' where firstName='Basweshwar' or firstName='Prajakta'
update AddressBook set type='Me' where firstName='Sangmeshwar'
update AddressBook set name='SelfContact' where firstName='Sangmeshwar'