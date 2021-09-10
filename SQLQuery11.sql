CREATE TABLE Rental (
    Id int PRIMARY KEY IDENTITY(1,1),
    CarId int,
    CustomerId int,
    RentDate datetime,
    ReturnDate datetime,
    FOREIGN KEY (CarId) REFERENCES Cars(Id),
    FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
)
 CREATE TABLE Customer (
   Id int PRIMARY KEY IDENTITY(1,1),
   UserId int,
   CompanyName varchar(25) 
   FOREIGN KEY (UserId) REFERENCES Users(Id)
 )
 CREATE TABLE Users(
  Id int PRIMARY KEY IDENTITY(1,1),
  FirstName varchar(25),
  LastName varchar(25),
  Email varchar(25),
  Password varchar(25)
 )