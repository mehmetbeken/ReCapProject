Create Table Colors(
ColorId int PRIMARY KEY IDENTITY(1,1),
ColorName nvarchar(25),
)
Create Table Brands(
BrandId int PRIMARY KEY IDENTITY(1,1),
BrandName nvarchar(25),
)
Create Table Cars(
Id int PRIMARY KEY IDENTITY(1,1),
BrandId int,
ColorId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Description nvarchar(25),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
)

