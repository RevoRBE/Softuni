CREATE DATABASE Minions;
GO
--Use Minions
CREATE TABLE Minions
(
Id int Primary KEY,
Name nvarchar(50) NOT NULL,
Age int
)
CREATE TABLE Towns
(
Id int Primary Key,
Name nvarchar(50) Not NULL
)
GO
ALTER TABLE Minions
ADD TownsId int Not Null;
Go
ALTER TABLE Minions
ADD CONSTRAINT FK_TownID FOREIGN KEY (TownID)
    REFERENCES Towns(id)
Go
INSERT INTO Towns(Id,Name)
 Values
(1,'Sofia'),(2,'Plovdiv'),(3,'Varna');
Go
INSERT INTO Minions
VALUES
(1,'Kevin',22,1),
(2,'Bob',15,3),
(3,'Steward',Null,2);
Go
TRUNCATE  TABLE Minions;
Go
DROP TABLE Minions;
DROP TABLE Towns;
Go
CREATE TABLE People
(
 [Id] INT PRIMARY KEY Identity,
 [Name] NVARCHAR(200) NOT NULL,
 [Picture] VARBINARY(MAX),
 [Height] DECIMAL(5,2),
 [Weight] DECIMAL(5,2),
 [Gender] char(1) Not null CHECK(Gender='m' OR Gender='f'),
 Birthdate DATE Not Null,
 Biography NVARCHAR(MAX)
)
Go
INSERT INTO People(Name,Picture,Height,Weight,Gender,Birthdate,Biography) Values
('Stela',Null,1.65,44.55,'f','2000-09-22',Null),
('Ivan',Null,2.15,95.55,'m','1989-11-02',Null),
('Qvor',Null,1.55,33.00,'m','2010-04-11',Null),
('Karolina',Null,2.15,55.55,'f','2001-11-11',Null),
('Pesho',Null,1.85,90.00,'m','1983-07-22',Null)
Go
CREATE TABLE Users
(
[Id] BigInt Primary Key Identity,
[Name] NVARCHAR(30) UNIQUE NOT NULL,
[Password] NVARCHAR(26) NOT NULL,
[ProfilePicture] VARBINARY(MAX),
[LastLoginTime] DATETIME,
IsDeleted BIT 
)
INSERT INTO USERS(Name,Password,ProfilePicture,LastLoginTime,IsDeleted)
VALUES
('Kiril','dqdada',NULL,Convert(datetime,'22-3-2018',103),0),
('kkoko','313k1o1',Null,Convert(datetime,'11-12-2018',103),0),
('Ema','311213k1o1',Null,Convert(datetime,'01-12-2018',103),0),
('gamer','313k1o1',Null,Convert(datetime,'21-05-2018',103),0),
('monro','311213k1o1',Null,Convert(datetime,'12-10-2018',103),0)
Go
ALTER TABLE Users
DROP constraint PK__USERS__3214EC0726AFFC55
ALTER TABLE Users
ADD CONSTRAINT PK_users PRIMARY KEY(Id,Username)
Go
ALTER TABLE Users
ADD CONSTRAINT CHK_Passwrd CHECK(LEN(Password)>5)
GO
ALTER TABLE Users
ADD DEFAULT GETDATE() FOR LastLoginTime 
GO
ALTER TABLE Users
DROP CONSTRAINT PK_users 
ALTER TABLE Users
ADD CONSTRAINT PK_users PRIMARY KEY(Id)
ALTER TABLE USERS
ADD CONSTRAINT CHK_UsrnameLen CHECK(LEN(Username)>=3)
Go
CREATE DATABASE Movies
Go
--Use Movies

CREATE TABLE Directors
(
[Id] int PRIMARY KEY IDENTITY,
[DirectorName] NVARCHAR(50) NOT NULL,
[Notes] NVARCHAR(MAX)
)
CREATE TABLE Genres
(
[Id] INT PRIMARY KEY IDENTITY,
[GenreName] NVARCHAR(50) NOT NULL,
[Notes] NVARCHAR(MAX)
)
CREATE TABLE Categories
(
[Id] INT PRIMARY KEY IDENTITY,
[CategoryName] NVARCHAR(50) NOT NULL,
[Notes] NVARCHAR(MAX)
)
CREATE TABLE Movies
(
[Id] INT PRIMARY KEY IDENTITY,
[Title] NVARCHAR(50) NOT NULL,
[DirectorId] INT CONSTRAINT fk_DirID FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
[CopyRightYear] DATETIME NOT NULL,
[Length] DECIMAL(5,2),
[GenreId] INT CONSTRAINT fk_GnrID FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
[CategoryId] INT CONSTRAINT fk_catId FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
[Rating] DECIMAL(3,2),
[Notes] NVARCHAR(MAX)
)
INSERT INTO Categories VALUES 
('Family movies','who watch this?'),
('Rated R','Get out of here'),
('Kid movies','Chuck Norris is coming run!'),
('Chill out','what the hell is this'),
('Greatest of all time','The hell with it')

INSERT INTO Directors VALUES
('Lans Von Trier','The crazy man'),
('James Cameron',Null),
('Fransis Ford Copola','The godfather'),
('Gilermo Del Torro','that spanish guy'),
('Tim Burton','the weirdo')

INSERT INTO Genres VALUES
('Horror','who watch this?'),
('Comedy','Get out of here'),
('Action','Chuck Norris is coming run!'),
('Alternative','what the hell is this'),
('Science fiction','the new Expanse')

INSERT INTO Movies VALUES
('Star wars N',2,CONVERT(datetime,'25-12-2030',103),123.44,5,5,9.99,'Come on not another one'),
('Sleepy Hollow',5,CONVERT(datetime,'10-10-2010',103),93.32,1,2,0,'That guy is weird'),
('Home alone',3,CONVERT(datetime,'12-01-1998',103),90.00,2,1,0.99,'Same shit every year'),
('Avatar X',2,CONVERT(datetime,'30-12-2030',103),180.00,5,5,9.99,'The revolution is here 10d movies'),
('Taken',4,CONVERT(datetime,'22-10-2015',103),95.44,3,2,0,'give me Liam Nelson')
Go
CREATE DATABASE CarRental
Go
--Use CarRental

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName nvarchar(50) NOT NULL,
	DailyRate int,
	WeeklyRate int,
	MonthlyRate int NOT NULL,
	WeekendRate int
)
Go
CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Platenumber nvarchar(50) NOT NULL UNIQUE,
	Model nvarchar(255) NOT NULL,
	CarYear int NOT NULL,
	CategoryId nvarchar(255),
	Doors int,
	Picture ntext,
	Condition nvarchar(50) NOT NULL,
	Available INT NOT NULL
)
Go
CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Title nvarchar(255) NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	DriverLicenceNumber int NOT NULL UNIQUE,
	FullName nvarchar(255) NOT NULL,
	Address nvarchar(255),
	City nvarchar(255) NOT NULL,
	ZIPCode nvarchar(255),
	Notes nvarchar(255)
)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT NOT NULL UNIQUE,
	CustomerId INT NOT NULL UNIQUE,
	CarId INT NOT NULL,
	TankLevel INT,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT,
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied nvarchar(50),
	TaxRate nvarchar(50),
	OrderStatus nvarchar(255),
	Notes nvarchar(255)
)
Go
INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES('Somecategory', NULL, 3, 100, 2)
INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES('SomeanotherCategory', 1, NULL, 900, NULL)
INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES('TheLastCategory', 4, 5, 800, 35)

INSERT INTO Cars(Platenumber,Model,CarYear,CategoryId,Doors,Picture,Condition,Available)
VALUES('ÑÀ 2258 ÀÑ', 'BMW', 2017, NULL,4,NULL,'New', 10)
INSERT INTO Cars(Platenumber,Model,CarYear,CategoryId,Doors,Picture,Condition,Available)
VALUES('RA 2299 CA', 'AUDI', 2017, NULL,2,NULL,'New', 21)
INSERT INTO Cars(Platenumber,Model,CarYear,CategoryId,Doors,Picture,Condition,Available)
VALUES('EG 8888 GA', 'MERCEDES', 2017, NULL,4,NULL,'New', 9)

INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Gosho','Peshov','Software Developer',NULL)
INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Pesho','Goshov','Pilot',NULL)
INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Mariika','Petrova','Doctor',NULL)

INSERT INTO Customers(DriverLicenceNumber, FullName, Address,City,ZIPCode,Notes)
VALUES(5821596,'Gosho it-to',NULL,'Sofia', NULL, NULL)
INSERT INTO Customers(DriverLicenceNumber, FullName, Address,City,ZIPCode,Notes)
VALUES(123513,'Pesho Peshov Peshov',NULL,'England', 'TN9T4U', NULL)
INSERT INTO Customers(DriverLicenceNumber, FullName, Address,City,ZIPCode,Notes)
VALUES(09834758,'Pesho Goshov Peshov',NULL,'Switzerland', NULL, NULL)

INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,KilometrageEnd,TotalKilometrage,StartDate,EndDate,TotalDays,RateApplied,TaxRate,OrderStatus,Notes)
VALUES(5315351, 1351, 5, NULL, 5000, 2351, 1231245, NULL,NULL,NULL,NULL,NULL,NULL,NULL)
INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,KilometrageEnd,TotalKilometrage,StartDate,EndDate,TotalDays,RateApplied,TaxRate,OrderStatus,Notes)
VALUES(53453, 643, 3, NULL, 567876, 12323, 3453453, NULL,NULL,NULL,NULL,NULL,NULL,NULL)
INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,KilometrageEnd,TotalKilometrage,StartDate,EndDate,TotalDays,RateApplied,TaxRate,OrderStatus,Notes)
VALUES(7859647, 123, 2, NULL, 12312, 543536, 367787, NULL,NULL,NULL,NULL,NULL,'DELIVERED',NULL)
Go
CREATE DATABASE Hotel
GO
--USE Hotel
CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50),
	Title nvarchar(50) NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	PhoneNumber INT,
	EmergencyName nvarchar(255),
	EmergencyNumber INT NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE RoomStatus
(
	RoomType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE RoomTypes
(
	RoomType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE BedTypes
(
	BedType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY IDENTITY(1,1),
	RoomType nvarchar(50) NOT NULL,
	BedType nvarchar(50) NOT NULL,
	Rate nvarchar(50),
	RoomStatus nvarchar(50),
	Notes nvarchar(255)
)
Go
CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT UNIQUE NOT NULL,
	PaymentDate date,
	AccountNumber INT NOT NULL,
	FirstDateOccupied date,
	LastDateOccupied date,
	TotalDays INT NOT NULL,
	AmountCharged INT NOT NULL,
	TaxRate INT,
	TaxAmount INT,
	PaymentTotal INT NOT NULL,
	Notes nvarchar(255)
)
Go
CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT UNIQUE NOT NULL,
	DateOccupied date,
	AccountNumber INT NOT NULL,
	RoomNumber INT NOT NULL,
	RateApplied INT,
	PhoneCharge INT,
	Notes nvarchar(255)
)
Go
INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Pesho', 'Peshov', 'Software Developer',NULL)
INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Gosho', 'Peshov', 'Pilot',NULL)
INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES('Pesho', 'Petrov', 'Engineer',NULL)
INSERT INTO Customers(FirstName,LastName,PhoneNumber,EmergencyName,EmergencyNumber, Notes)
VALUES('Pesho', 'Peshov', NULL, NULL, 112, NULL)
INSERT INTO Customers(FirstName,LastName,PhoneNumber,EmergencyName,EmergencyNumber, Notes)
VALUES('Pesho', 'Petrov', NULL, NULL, 911, NULL)
INSERT INTO Customers(FirstName,LastName,PhoneNumber,EmergencyName,EmergencyNumber, Notes)
VALUES('Pesho', 'Peshov', NULL, NULL, 912, NULL)
INSERT INTO RoomStatus(RoomType, Notes)
VALUES('Free', NULL)
INSERT INTO RoomStatus(RoomType, Notes)
VALUES('Reserved', NULL)
INSERT INTO RoomStatus(RoomType, Notes)
VALUES('Currently not available', NULL)
INSERT INTO RoomTypes(RoomType,Notes)
VALUES('Luxury', NULL)
INSERT INTO RoomTypes(RoomType,Notes)
VALUES('Standard', NULL)
INSERT INTO RoomTypes(RoomType,Notes)
VALUES('Small', NULL)

INSERT INTO BedTypes(BedType,Notes)
VALUES('LARGE', NULL)
INSERT INTO BedTypes(BedType,Notes)
VALUES('Medium', NULL)
INSERT INTO BedTypes(BedType,Notes)
VALUES('Small', NULL)

INSERT INTO Rooms(RoomType, BedType, Rate,RoomStatus,Notes)
VALUES('Luxury', 'Large', 'Perfect for rich people', 'Available', NULL)
INSERT INTO Rooms(RoomType, BedType, Rate,RoomStatus,Notes)
VALUES('Medium', 'Medium', NULL, 'Not available', NULL)
INSERT INTO Rooms(RoomType, BedType, Rate,RoomStatus,Notes)
VALUES('Economy', 'Small', NULL, 'Available', NULL)

INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied,LastDateOccupied,TotalDays,AmountCharged,TaxRate,TaxAmount,PaymentTotal,Notes)
VALUES(231, NULL, 2311, NULL,NULL, 7, 5000, 0,0,5000,NULL)
INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied,LastDateOccupied,TotalDays,AmountCharged,TaxRate,TaxAmount,PaymentTotal,Notes)
VALUES(321, NULL, 3211, NULL,NULL, 7, 5000, 0,2000,7000,NULL)
INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied,LastDateOccupied,TotalDays,AmountCharged,TaxRate,TaxAmount,PaymentTotal,Notes)
VALUES(999, NULL, 9989, NULL,NULL, 7, 5000, 0,50,5500,NULL)

INSERT INTO Occupancies(EmployeeId,DateOccupied,AccountNumber,RoomNumber,RateApplied,PhoneCharge,Notes)
VALUES(991, NULL, 534, 8, NULL,NULL,NULL)
INSERT INTO Occupancies(EmployeeId,DateOccupied,AccountNumber,RoomNumber,RateApplied,PhoneCharge,Notes)
VALUES(561, NULL, 75, 9, NULL,NULL,NULL)
INSERT INTO Occupancies(EmployeeId,DateOccupied,AccountNumber,RoomNumber,RateApplied,PhoneCharge,Notes)
VALUES(135, NULL, 8, 10, NULL,NULL,NULL)
Go
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees
GO
SELECT * FROM Towns
ORDER BY Name
SELECT * FROM Departments
ORDER BY Name
SELECT * FROM Employees
ORDER BY Salary DESC
Go
SELECT Name FROM Towns ORDER BY Name
SELECT Name FROM Departments ORDER BY Name
SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC
GO
UPDATE Employees
SET Salary+=Salary*10/100
SELECT Salary FROM Employees
Go
UPDATE Payments
SET TaxRate-=TaxRate*3/100
SELECT TaxRate FROM Payments
Go
TRUNCATE TABLE Occupancies
Go