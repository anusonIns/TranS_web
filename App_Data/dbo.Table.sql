CREATE TABLE [dbo].[TransectionDB]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Transaction_Id] VARCHAR(50) NOT NULL, 
    [Amount] DECIMAL(16, 2) NOT NULL, 
    [Currency_Code] NVARCHAR(8) NOT NULL, 
    [Transaction_Date] DATETIME NOT NULL, 
    [Status] VARCHAR(12) NOT NULL
)
