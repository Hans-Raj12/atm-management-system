CREATE TABLE [dbo].[TransctionTbl] (
    [Tid]    INT          IDENTITY (1, 1) NOT NULL,
    [AccNum] VARCHAR (50) NOT NULL,
    [Type]   VARCHAR (50) NOT NULL,
    [Amount] INT          NOT NULL,
    [TDate]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tid] ASC)
);

