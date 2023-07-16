CREATE TABLE [dbo].[AccountTbl] (
    [AccNum]     VARCHAR (50) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [FName]      VARCHAR (50) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
    [Phone]      VARCHAR (50) NOT NULL,
    [Education]  VARCHAR (50) NOT NULL,
    [Pin]        INT          NOT NULL,
    [Dob]        VARCHAR (50) NOT NULL,
    [Occupation] VARCHAR (50) NOT NULL,
    [Balance]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([AccNum] ASC)
);

