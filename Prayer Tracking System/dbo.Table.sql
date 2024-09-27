CREATE TABLE [dbo].[att]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [date] DATETIME NOT NULL, 
    [fajr] BIT NOT NULL , 
    [zuhr] BIT NOT NULL , 
    [asar] BIT NOT NULL , 
    [maghrib] BIT NOT NULL , 
    [isha] BIT NOT NULL
)
