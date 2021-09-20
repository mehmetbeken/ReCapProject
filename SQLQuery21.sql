Create Table CarImages(
Id int PRIMARY KEY IDENTITY(1,1),
CarId int,
ImagePath varchar(255),
Date dateTime,
FOREIGN KEY (CarId) REFERENCES Cars(Id)
);