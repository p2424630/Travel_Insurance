CREATE TABLE [dbo].[Table]
(
	[CustomerId] INT NOT NULL PRIMARY KEY DEFAULT 0000000000, 
    [Name ] TEXT NOT NULL , 
    [DoB] DATE NOT NULL , 
    [Address] TEXT NOT NULL, 
    [E-mail] TEXT NULL, 
    [Contact Number] TEXT NULL, 
    [Marketing Preferences] BIT NOT NULL DEFAULT false
)
