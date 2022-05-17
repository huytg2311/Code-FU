create database MyStore;

use MyStore;

create table Categories (
	CategoryID int IDENTITY primary key,
	CategoryName nvarchar(15)
);

Insert into Categories values (
'Akakaka'
);

select * from Categories;

create table Products (
	ProductID int IDENTITY primary key,
	ProductName nvarchar(40),
	UnitPrice money,
	UnitsInStock smallint,
	CategoryID int,
	foreign key (CategoryID) references Categories (CategoryID)
);

