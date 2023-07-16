CREATE TABLE [dbo].[AccountTbl]
(
	[AccNum] INT NOT NULL PRIMARY KEY,
	[Name] varchar(50) not null,
	[FName] varchar(50) not null,
	[Address] varchar(50) not null,
	[Phone] varchar(50) not null,
	[Education] varchar(50) not null,
	[Pin] int not null,
	[Occupation] varchar(50) not null,
	[DOB] Date not null,
	[Balance] int not null
	
)
