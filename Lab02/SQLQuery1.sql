create database MyStock;

use MyStock;

create table Cars (
	CarID int primary key,
	CarName nvarchar(50),
	Manufacturer nvarchar(50),
	Price money,
	ReleasedYear int 
);

insert into Cars values
(1, 'Accord', 'Honda Motor Company', 24970.0000, 2021),
(3, 'Clarity', 'Honda Motor Company', 33400.0000, 2021),
(4, 'BMW 8 Series', 'BMW', 85000.0000, 2021),
(5, 'Audi A6', 'Audi', 14000.0000, 2021);

select * from Cars;