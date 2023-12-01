drop table if exists People;
drop table if exists City;
drop table if exists Country;

create table Country (
CountryID int primary key,
CountryName char(50)
);

create table City (
CityID int primary key,
CityName char(50),
CountryID int,
FOREIGN KEY(CountryID) REFERENCES
Country(CountryID)
);


create table People (
PeopleID int primary key,
PeopleName char(50),
CityID int,
FOREIGN KEY(CityID) REFERENCES
City(CityID)
);

insert into Country values 
(1, 'Italia'),
(2, 'USA');

insert into City values 
(1, 'Ancona', 1),
(2, 'Milano', 1),
(3, 'New York', 2);

insert into People values 
(1, 'Mario Rossi', 1),
(2, 'Franciosco Fattura', 2),
(3, 'Jhon Smith', 3);

