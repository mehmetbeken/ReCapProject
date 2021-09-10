CREATE TABLE Users (
    Id        INT          IDENTITY (1, 1) NOT NULL,
    FirstName VARCHAR (25) NULL,
    LastName  VARCHAR (25) NULL,
    Email     VARCHAR (25) NULL,
    Password  VARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE Customers (
    UserId      INT          NULL,
    CompanyName VARCHAR (25) NULL,
    FOREIGN KEY (UserId) REFERENCES Users (Id)
);



CREATE TABLE Rentals (
    Id         INT      IDENTITY (1, 1) NOT NULL,
    CarId      INT      NULL,
    CustomerId INT      NULL,
    RentDate   DATETIME NULL,
    ReturnDate DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY (CarId) REFERENCES Cars (Id),
    FOREIGN KEY (CustomerId) REFERENCES Users (Id)
);